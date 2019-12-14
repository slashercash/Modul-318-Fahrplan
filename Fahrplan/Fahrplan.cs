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
        readonly Transport transport = new Transport();
        List<Connection> connections = new List<Connection>();

        readonly Panel pnlFahrplan;
        readonly TableLayoutPanel tlpConnectionTable;
        readonly TableLayoutPanel tlpConnectionTableHeader;
        readonly Button btnStreckeEingeben;
        readonly Label lbFromTo;
        readonly Label lbGleisKante;
        readonly Label[] lbConnectionTable;

        public Fahrplan(Panel _pnlFahrplan, TableLayoutPanel _tlpConnectionTable, TableLayoutPanel _tlpConnectionTableHeader, Button _btnStreckeEingeben, Label _lbFromTo, Label _lbGleisKante, Label[] _lbConnectionTable)
        {
            pnlFahrplan              = _pnlFahrplan;
            tlpConnectionTable       = _tlpConnectionTable;
            tlpConnectionTableHeader = _tlpConnectionTableHeader;
            btnStreckeEingeben       = _btnStreckeEingeben;
            lbFromTo                 = _lbFromTo;
            lbGleisKante             = _lbGleisKante;
            lbConnectionTable        = _lbConnectionTable;

            pnlFahrplan.Dock = DockStyle.Fill;
        }

        public void LoadPanel()
        {
            pnlFahrplan.BringToFront();
        }

        public void LoadConnections(string from, string to)
        {
            connections = transport.GetConnections(from, to).ConnectionList;

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

                lbConnectionTable[pointer].Text = departure;
                pointer++;
                lbConnectionTable[pointer].Text = String.IsNullOrEmpty(connection.From.Platform) ? "-" : connection.From.Platform;
                pointer++;
                lbConnectionTable[pointer].Text = arival;
                pointer++;
                lbConnectionTable[pointer].Text = duration;
                pointer++;
            }

            for (int i = pointer; i < lbConnectionTable.Length; i++)
            {
                lbConnectionTable[i].Text = "";
            }

            Connection firstConnection = connections.First();
            lbGleisKante.Text = int.TryParse(firstConnection.From.Platform, out _) ? "Gleis" : "Kante";
            lbFromTo.Text = String.Format("{0}  🡺  {1}", firstConnection.From.Station.Name, firstConnection.To.Station.Name);
            tlpConnectionTable.Visible = true;
            tlpConnectionTableHeader.Visible = true;
            btnStreckeEingeben.Visible = false;

            LoadPanel();
        }
    }
}
