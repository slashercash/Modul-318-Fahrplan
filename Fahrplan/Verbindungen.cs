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
        readonly Panel pnlVerbindungen;
        readonly TableLayoutPanel tlpConnectionsTable;
        readonly TableLayoutPanel tlpConnectionsHeader;
        readonly Transport transport = new Transport();
        readonly MainForm mainForm;
        private string connectionFrom;



        public Verbindungen(Panel _pnlVerbindungen, TableLayoutPanel _tlpConnectionsTable, TableLayoutPanel _tlpConnectionsHeader, MainForm _mainForm)
        {
            pnlVerbindungen      = _pnlVerbindungen;
            tlpConnectionsTable  = _tlpConnectionsTable;
            tlpConnectionsHeader = _tlpConnectionsHeader;
            mainForm             = _mainForm;

            pnlVerbindungen.Dock = DockStyle.Fill;
        }

        public void LoadPanel()
        {
            pnlVerbindungen.BringToFront();
        }

        public void LoadConnections(TextBox textBox)
        {
            tlpConnectionsHeader.Visible = true;
            tlpConnectionsTable.Controls.Clear();

            Station station = transport.GetStations(textBox.Text).StationList.First();
            connectionFrom = station.Name;
            textBox.Text = connectionFrom;

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

            for (int i = 0; i < uniqueStationBoards.Count(); i++)
            {
                string tag = string.Format("{0};{1}", connectionFrom, uniqueStationBoards.ElementAt(i).To);

                Label number = new LabelTemplate { Text = uniqueStationBoards.ElementAt(i).Number };
                Label destination = new LabelTemplate { Text = uniqueStationBoards.ElementAt(i).To };
                Button route = new ButtonTemplate(mainForm) { Tag = tag };

                tlpConnectionsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
                tlpConnectionsTable.Controls.Add(number, 0, i);
                tlpConnectionsTable.Controls.Add(destination, 1, i);
                tlpConnectionsTable.Controls.Add(route, 2, i);
            }
            tlpConnectionsTable.Controls.Add(new Label(), 0, uniqueStationBoards.Count());
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
