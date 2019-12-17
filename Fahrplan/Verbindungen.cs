using SwissTransport;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Fahrplan
{
    class Verbindungen
    {
        private string connectionFrom;

        readonly Transport transport = new Transport();
        readonly MainForm mainForm;
        readonly Panel pnlVerbindungen;
        readonly TableLayoutPanel tlpConnectionsTable;
        readonly TableLayoutPanel tlpConnectionsHeader;
        readonly TextBox tbxAb;

        public Verbindungen(MainForm _mainForm, Panel _pnlVerbindungen, TableLayoutPanel _tlpConnectionsTable, TableLayoutPanel _tlpConnectionsHeader, TextBox _tbxAb)
        {
            mainForm             = _mainForm;
            pnlVerbindungen      = _pnlVerbindungen;
            tlpConnectionsTable  = _tlpConnectionsTable;
            tlpConnectionsHeader = _tlpConnectionsHeader;
            tbxAb                = _tbxAb;

            pnlVerbindungen.Dock = DockStyle.Fill;
        }

        // Panel Verbindungen anzeigen, Fokus auf Textbox setzen.
        public void LoadPanel()
        {
            pnlVerbindungen.BringToFront();
            tbxAb.Focus();
        }

        // Von einer Station aus zu erreichende Ziele auflisten
        public void LoadConnections(TextBox textBox)
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

                // Stationen Laden und UI Ansicht zurücksetzen
                Station station = transport.GetStations(textBox.Text).StationList.First();
                connectionFrom = station.Name;
                textBox.Text = connectionFrom;
                tlpConnectionsHeader.Visible = true;
                tlpConnectionsTable.Controls.Clear();

                // Fehler abfangen, falls die Adresse keine Haltestelle ist
                if (station.Id == null)
                {
                    tlpConnectionsHeader.Visible = false;
                    MessageBox.Show("Die ausgewählte Adresse ist keine Haltestelle", "Keine Haltestelle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Eine Liste mit Verbindungen erstellen in der jede nur einmal vorkommt.
                List<StationBoard> allStationBoards = transport.GetStationBoard(station.Name, station.Id).Entries;
                List<StationBoard> uniqueStationBoards = new List<StationBoard>();
                foreach (StationBoard stationBoard in allStationBoards)
                {
                    if (!uniqueStationBoards.Any(unique => unique.Number == stationBoard.Number && unique.To == stationBoard.To))
                    {
                        uniqueStationBoards.Add(stationBoard);
                    }
                }

                // Liste sortieren nach Zug / Bus Nr
                uniqueStationBoards = uniqueStationBoards.OrderBy(o => o.Number).ToList();

                // Verbindungen der Tabelle hinzufügen
                for (int i = 0; i < uniqueStationBoards.Count(); i++)
                {
                    // Elemente für eine Reihe definieren
                    string tag = string.Format("{0};{1}", connectionFrom, uniqueStationBoards.ElementAt(i).To);
                    Label number = new LabelTemplate { Text = uniqueStationBoards.ElementAt(i).Number };
                    Label destination = new LabelTemplate { Text = uniqueStationBoards.ElementAt(i).To };
                    Button route = new ButtonTemplate(mainForm) { Tag = tag };

                    // Eine weitere Reihe in der Tabelle hinzufügen, falls zu wenig Platz ist.
                    if (tlpConnectionsTable.RowStyles.Count <= i)
                    {
                        tlpConnectionsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
                    }

                    // Elemente der Tabelle hinzufügen
                    tlpConnectionsTable.Controls.Add(number, 0, i);
                    tlpConnectionsTable.Controls.Add(destination, 1, i);
                    tlpConnectionsTable.Controls.Add(route, 2, i);
                    
                }
                // Platzhalter aus Darstellungsgründen hinzufügen
                tlpConnectionsTable.Controls.Add(new Label(), 0, uniqueStationBoards.Count());
            }
            catch (Exception exeption)
            {
                throw new System.InvalidOperationException("\nThere was an exeption in Verbindungen LoadConnections() \nMessage: " + exeption.Message);
            }
        }
    }

    public class LabelTemplate : Label
    {
        public LabelTemplate()
        {
            Dock = DockStyle.Fill;
            Font = new Font("Calibri", 16);
            ForeColor = Color.DarkGreen;
            Margin = new Padding(0, 0, 0, 0);
            TextAlign = ContentAlignment.TopCenter;
        }
    }

    public class ButtonTemplate : Button
    {
        public ButtonTemplate(MainForm mainForm)
        {
            Text = "Fahrplan";
            Dock = DockStyle.Fill;
            Font = new Font("Calibri", 16);
            ForeColor = Color.DarkGreen;
            BackColor = Color.LightGreen;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Margin = new Padding(0, 3, 0, 3);
            Click += mainForm.BtnSelectConnection_Click;
        }
    }
}
