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
        readonly Stations stations = new Stations();
        readonly List<string> stationNames = new List<string>();

        readonly Panel pnlStrecke;
        readonly TextBox tbxVon;
        readonly TextBox tbxNach;
        readonly TextBox tbxAb;
        DateTimePicker datePicker;
        DateTimePicker timePicker;

        public Strecke(Panel _pnlStrecke, TextBox _tbxVon, TextBox _tbxNach, TextBox _tbxAb, DateTimePicker _datePicker, DateTimePicker _timePicker)
        {
            pnlStrecke = _pnlStrecke;
            tbxVon     = _tbxVon;
            tbxNach    = _tbxNach;
            tbxAb      = _tbxAb;
            datePicker = _datePicker;
            timePicker = _timePicker;

            pnlStrecke.Dock = DockStyle.Fill;
        }

        public void LoadPanel()
        {
            datePicker.Value = DateTime.Now;
            timePicker.Value = DateTime.Now;
            pnlStrecke.BringToFront();
        }

        internal void VonNachAbKeyDown(TextBox textBox, KeyEventArgs key)
        {
            if(key.KeyCode == Keys.Enter && textBox.TextLength > 0)
            {
                LoadStations(textBox);
            }
        }

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

        internal void ChangeDirection()
        {
            string temp = tbxVon.Text;
            tbxVon.Text = tbxNach.Text;
            tbxNach.Text = temp;
        }

        internal void SetFromTo(string fromTo)
        {
            string[] fromToSplitted = fromTo.Split(';');
            tbxVon.Text = fromToSplitted[0];
            tbxNach.Text = fromToSplitted[1];
        }

        public void LoadStations(TextBox textBox)
        {
            stations.StationList = transport.GetStations(textBox.Text).StationList;

            foreach (Station station in stations.StationList)
            {
                stationNames.Add(station.Name);
            }
            tbxVon.AutoCompleteCustomSource.AddRange(stationNames.ToArray());
            tbxNach.AutoCompleteCustomSource.AddRange(stationNames.ToArray());
            tbxAb.AutoCompleteCustomSource.AddRange(stationNames.ToArray());

            string text = textBox.Text;
            textBox.Text = "";
            textBox.Focus();
            SendKeys.Send(text);
        }

        internal void LoadLocation(TextBox textBox)
        {
            Station station = transport.GetStations(textBox.Text).StationList.First();
            textBox.Text = station.Name;
            string xCoordinate = station.Coordinate.XCoordinate.ToString().Replace(",", ".");
            string yCoordinate = station.Coordinate.YCoordinate.ToString().Replace(",", ".");
            string webAdress = String.Format("http://maps.google.com/?q={0},{1}&zoom=21", xCoordinate, yCoordinate);
            System.Diagnostics.Process.Start(webAdress);
        }
    }
}
