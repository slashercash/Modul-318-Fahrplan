﻿using System;
using System.Collections.Generic;
using System.Drawing;
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
        bool isArivalTime = false;

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

        internal void SetArrivalDeparture(Button btnActivate, Button btnDeactivate, bool _isArivalTime)
        {
            isArivalTime = _isArivalTime;
            btnActivate.FlatAppearance.BorderColor = Color.Gray;
            btnDeactivate.FlatAppearance.BorderColor = Color.LightGreen;
        }

        public void LoadTimeTable(string from, string to, DateTime date, DateTime time)
        {
            DateTime departureTime = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);

            connections = transport.GetConnections(from, to, 5, departureTime, isArivalTime).ConnectionList;

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
