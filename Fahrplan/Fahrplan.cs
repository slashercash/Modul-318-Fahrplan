using System;
using System.Globalization;
using System.Windows.Forms;
using SwissTransport;

namespace Fahrplan
{
    class Fahrplan
    {
        readonly Panel fahrplanPanel;
        readonly ListView lvConnections;

        public Fahrplan(Panel panel, ListView _lvConnections)
        {
            fahrplanPanel = panel;
            lvConnections = _lvConnections;
            fahrplanPanel.Dock = DockStyle.Fill;
        }

        internal void LoadConnections(Connections connections)
        {
            lvConnections.Items.Clear();

            foreach (Connection connection in connections.ConnectionList)
            {
                string departure = Convert.ToDateTime(connection.From.Departure).ToString("HH:mm");
                string arival = Convert.ToDateTime(connection.To.Arrival).ToString("HH:mm");

                string duration;
                string durationUnformatted = connection.Duration.Substring(connection.Duration.IndexOf('d') + 1);
                DateTime dtDuration = Convert.ToDateTime(durationUnformatted);
                if(dtDuration.Hour == 0)
                {
                    duration = String.Format("{0} Min", dtDuration.Minute.ToString());
                }
                else
                {
                    duration = String.Format("{0} Std, {1} Min", dtDuration.Hour.ToString(), dtDuration.Minute.ToString());
                }

                string[] connectionArray = new string[] 
                {
                    departure,
                    connection.From.Platform,
                    arival,
                    duration
                };

                ListViewItem listViewItem = new ListViewItem(connectionArray);
                lvConnections.Items.Add(listViewItem);
            }
        }

        public void LoadPanel()
        {
            fahrplanPanel.BringToFront();
        }
    }
}
