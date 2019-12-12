using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SwissTransport;

namespace Fahrplan
{
    class Strecke
    {
        readonly Panel streckePanel;
        Transport transport = new Transport();
        Stations stations = new Stations();
        List<string> stationNames = new List<string>();

        public Strecke(Panel panel)
        {
            streckePanel = panel;
            streckePanel.Dock = DockStyle.Fill;
        }

        public void LoadPanel()
        {
            streckePanel.BringToFront();
        }

        internal void LoadStations(TextBox textBoxLoad)
        {
            stations.StationList = transport.GetStations(textBoxLoad.Text).StationList;
            foreach (Station station in stations.StationList)
            {
                stationNames.Add(station.Name);
            }
            textBoxLoad.AutoCompleteCustomSource.AddRange(stationNames.ToArray());
        }

        internal void ClearStations(TextBox textBoxClear)
        {
            textBoxClear.AutoCompleteCustomSource.Clear();
        }
    }
}
