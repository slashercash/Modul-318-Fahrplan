using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SwissTransport;

namespace Fahrplan
{
    class Strecke
    {
        readonly Transport transport = new Transport();
        readonly MainForm mainForm;
        readonly Panel pnlStrecke;
        readonly TextBox tbxVon;
        readonly TextBox tbxNach;
        readonly TextBox tbxAb;
        readonly DateTimePicker datePicker;
        readonly DateTimePicker timePicker;
        readonly Button btnFahrplanAnzeigen;

        public Strecke(MainForm _mainForm, Panel _pnlStrecke, TextBox _tbxVon, TextBox _tbxNach, TextBox _tbxAb, DateTimePicker _datePicker, DateTimePicker _timePicker, Button _btnFahrplanAnzeigen)
        {
            mainForm            = _mainForm;
            pnlStrecke          = _pnlStrecke;
            tbxVon              = _tbxVon;
            tbxNach             = _tbxNach;
            tbxAb               = _tbxAb;
            datePicker          = _datePicker;
            timePicker          = _timePicker;
            btnFahrplanAnzeigen = _btnFahrplanAnzeigen;

            pnlStrecke.Dock = DockStyle.Fill;
        }

        // Panel Strecke anzeigen, Fokus über Parameter definiert
        public void LoadPanel(bool focusToButton)
        {
            datePicker.Value = DateTime.Now;
            timePicker.Value = DateTime.Now;
            pnlStrecke.BringToFront();
            if (focusToButton)
            {
                btnFahrplanAnzeigen.Focus();
            }
            else
            {
                tbxVon.Focus();
            }
        }

        // Bei Enter Stationen laden
        internal void VonNachAbKeyDown(TextBox textBox, KeyEventArgs key)
        {
            if(key.KeyCode == Keys.Enter && textBox.TextLength > 0)
            {
                LoadStations(textBox);
            }
        }

        // Buttons zu Textboxen aktivieren sobald mind. ein Zeichen enthalten ist.
        public void VonNachTextChanged(TextBox textBox, Button btnDurchsuchen, Button btnStandortAnzeigen)
        {
            if (textBox.TextLength == 0)
            {
                btnDurchsuchen.Enabled = false;
                btnDurchsuchen.BackColor = Color.LightGray;
                btnStandortAnzeigen.Enabled = false;
                btnStandortAnzeigen.BackColor = Color.LightGray;
            }
            else
            {
                btnDurchsuchen.Enabled = true;
                btnDurchsuchen.BackColor = Color.LightGreen;
                btnStandortAnzeigen.Enabled = true;
                btnStandortAnzeigen.BackColor = Color.LightGreen;
            }
        }

        // Inhalt der Textboxen "Von" und "Nach" tauschen.
        internal void ChangeDirection()
        {
            string temp = tbxVon.Text;
            tbxVon.Text = tbxNach.Text;
            tbxNach.Text = temp;
        }

        // Parameter Spliten und in die Textboxen "Von" und "Nach" einfügen.
        internal void SetFromTo(string fromTo)
        {
            string[] fromToSplitted = fromTo.Split(';');
            tbxVon.Text = fromToSplitted[0];
            tbxNach.Text = fromToSplitted[1];
        }

        // Nach Stationen suchen und der Autocompletesource hinzufügen.
        public void LoadStations(TextBox textBox)
        {
            try
            {
                // Internet Verbindung Prüfen
                if(!transport.CheckForInternetConnection())
                {
                    mainForm.LoadNoConnectionPanel();
                    return;
                }

                // Fehler abfangen, falls keine Stationen gefunden werden
                if (!transport.GetStations(textBox.Text).StationList.Any())
                {
                    MessageBox.Show("Es konnten keine Stationen mit den von Ihnen eingegebenen Suchkriterien gefunden werden", "Keine Treffer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Stationen in Liste abfüllen
                Stations stations = new Stations
                {
                    StationList = transport.GetStations(textBox.Text).StationList
                };

                // Namen der Stationen in Liste abfüllen
                List<string> stationNames = new List<string>();
                foreach (Station station in stations.StationList)
                {
                    stationNames.Add(station.Name);
                }

                // Namen der Stationen allen drei Textboxen hinzufügen
                tbxVon.AutoCompleteCustomSource.AddRange(stationNames.ToArray());
                tbxNach.AutoCompleteCustomSource.AddRange(stationNames.ToArray());
                tbxAb.AutoCompleteCustomSource.AddRange(stationNames.ToArray());

                // Text aus der Textbox über Sendkeys neu einspielen, damit das Dropdown aktiviert wird.
                string text = textBox.Text;
                textBox.Text = "";
                textBox.Focus();
                SendKeys.Send(text);
            }
            catch (Exception exeption)
            {
                throw new System.InvalidOperationException("\nThere was an exeption in Strecke LoadStations() \nMessage: " + exeption.Message);
            }
        }

        // Station aus Textbox via Koordinaten in GoogleMaps anzeigen
        internal void LoadLocation(TextBox textBox)
        {
            try
            {
                // Internet Verbindung Prüfen
                if (!transport.CheckForInternetConnection())
                {
                    mainForm.LoadNoConnectionPanel();
                    return;
                }

                // Fehler abfangen, falls keine Stationen gefunden werden
                if (!transport.GetStations(textBox.Text).StationList.Any())
                {
                    MessageBox.Show("Es konnten keine Stationen mit den von Ihnen eingegebenen Suchkriterien gefunden werden", "Keine Treffer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Fehler abfangen, falls Station keine Koordinaten enthält
                Station station = transport.GetStations(textBox.Text).StationList.First();
                if (station.Coordinate.XCoordinate == 0 && station.Coordinate.YCoordinate == 0)
                {
                    MessageBox.Show("Der Standort kann nicht angezeigt werden, \nda keine Koordinaten hinterlegt sind.", "Standort nicht gefunden", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Mit den Koordinaten die URL für Google Maps zusammensetzen und aufrufen.
                textBox.Text = station.Name;
                string xCoordinate = station.Coordinate.XCoordinate.ToString().Replace(",", ".");
                string yCoordinate = station.Coordinate.YCoordinate.ToString().Replace(",", ".");
                string webAdress = String.Format("http://maps.google.com/?q={0},{1}&zoom=21", xCoordinate, yCoordinate);
                System.Diagnostics.Process.Start(webAdress);
            }
            catch (Exception exeption)
            {
                throw new System.InvalidOperationException("\nThere was an exeption in Strecke LoadLocation() \nMessage: " + exeption.Message);
            }
        }

        internal void CheckInternetConnection()
        {
            // Internet Verbindung Prüfen
            if (transport.CheckForInternetConnection())
            {
                mainForm.EnableHeaderButtons(true);
                LoadPanel(false);
            }
        }
    }
}
