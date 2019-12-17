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
        readonly Panel verbindungenPanel;
        readonly TableLayoutPanel tlpConnectionsTable;
        readonly Transport transport = new Transport();

        public Verbindungen(Panel panel, TableLayoutPanel _tlpConnectionsTable)
        {
            verbindungenPanel = panel;
            tlpConnectionsTable = _tlpConnectionsTable;

            verbindungenPanel.Dock = DockStyle.Fill;
        }

        public void LoadPanel()
        {
            verbindungenPanel.BringToFront();
        }

        internal void LoadConnections(TextBox textBox)
        {
            Station station = transport.GetStations(textBox.Text).StationList.First();
            textBox.Text = station.Name;

            List<StationBoard> allStationBoards = transport.GetStationBoard(station.Name, station.Id).Entries;
            List<StationBoard> uniqueStationBoards = new List<StationBoard>();
            foreach (StationBoard stationBoard in allStationBoards)
            {
                if (!uniqueStationBoards.Any(unique => unique.Number == stationBoard.Number && unique.To == stationBoard.To))
                {
                    uniqueStationBoards.Add(stationBoard);
                }
            }

            uniqueStationBoards = uniqueStationBoards.OrderBy(o => o.Number).ToList();

            Label template = new Label()
            {
                Dock = DockStyle.Fill,
                Font = new Font("Calibri", 16),
                ForeColor = Color.DarkGreen,
                Margin = new Padding(0, 0, 0, 0),
            };

            for (int i = 0; i < uniqueStationBoards.Count(); i++)
            {
                Label number = new LabelTemplate { Text = uniqueStationBoards.ElementAt(i).Number };
                Label destination = new LabelTemplate { Text = uniqueStationBoards.ElementAt(i).To };
                Button route = new ButtonTemplate { Tag = uniqueStationBoards.ElementAt(i).To };

                tlpConnectionsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
                tlpConnectionsTable.Controls.Add(number, 0, i);
                tlpConnectionsTable.Controls.Add(destination, 1, i);
                tlpConnectionsTable.Controls.Add(route, 2, i);
            }
            tlpConnectionsTable.Controls.Add(new Label(), 0, uniqueStationBoards.Count());
        }
    }

    internal class LabelTemplate : Label
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

    internal class ButtonTemplate : Button
    {
        public ButtonTemplate()
        {
            Text = "Fahrplan";
            Dock = DockStyle.Fill;
            Font = new Font("Calibri", 16);
            ForeColor = Color.DarkGreen;
            BackColor = Color.LightGreen;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Margin = new Padding(0, 3, 0, 3);
        }
    }
}
