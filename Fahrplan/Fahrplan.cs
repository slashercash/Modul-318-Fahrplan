using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using SwissTransport;

namespace Fahrplan
{
    class Fahrplan
    {
        readonly Button btnStreckeEingeben;
        readonly Panel fahrplanPanel;
        readonly Label lbFromTo;
        readonly Label[] connectionTable;
        readonly TableLayoutPanel tlpConnectionTable;
        readonly TableLayoutPanel tlpConnectionTableHeader;

        public Fahrplan(Panel panel, Label _lbFromTo, Label[] _connectionTable, TableLayoutPanel _tlpConnectionTable, TableLayoutPanel _tlpConnectionTableHeader, Button _btnStreckeEingeben)
        {
            btnStreckeEingeben = _btnStreckeEingeben;
            fahrplanPanel = panel;
            lbFromTo = _lbFromTo;
            connectionTable = _connectionTable;
            tlpConnectionTable = _tlpConnectionTable;
            tlpConnectionTableHeader = _tlpConnectionTableHeader;
            fahrplanPanel.Dock = DockStyle.Fill;
        }

        internal void LoadConnections(List<Connection> connections)
        {
            lbFromTo.Text = String.Format("{0}  🡺  {1}", connections.First().From.Station.Name, connections.First().To.Station.Name);
            tlpConnectionTable.Visible = true;
            tlpConnectionTableHeader.Visible = true;
            btnStreckeEingeben.Visible = false;


            int pointer = 0;
            foreach (Connection connection in connections)
            {
                string departure = Convert.ToDateTime(connection.From.Departure).ToString("HH:mm");
                string arival = Convert.ToDateTime(connection.To.Arrival).ToString("HH:mm");
                string duration;
                string durationUnformatted = connection.Duration.Substring(connection.Duration.IndexOf('d') + 1);
                DateTime dtDuration = Convert.ToDateTime(durationUnformatted);
                if (dtDuration.Hour == 0)
                {
                    duration = String.Format("{0} Min", dtDuration.Minute.ToString());
                }
                else
                {
                    duration = String.Format("{0} Std, {1} Min", dtDuration.Hour.ToString(), dtDuration.Minute.ToString());
                }

                connectionTable[pointer].Text = departure;
                pointer++;
                connectionTable[pointer].Text = String.IsNullOrEmpty(connection.From.Platform) ? "-" : connection.From.Platform;
                pointer++;
                connectionTable[pointer].Text = arival;
                pointer++;
                connectionTable[pointer].Text = duration;
                pointer++;
            }

            for (int i = pointer; i < connectionTable.Length; i++)
            {
                connectionTable[i].Text = "";
            }
        }

        public void LoadPanel()
        {
            fahrplanPanel.BringToFront();
        }
    }
}
