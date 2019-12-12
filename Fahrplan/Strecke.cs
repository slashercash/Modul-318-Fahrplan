using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SwissTransport;

namespace Fahrplan
{
    class Strecke
    {
        readonly Panel streckePanel;
        TextBox fromTextbox;
        TextBox toTextbox;
        Transport transport = new Transport();
        Stations stations = new Stations();
        List<string> stationNames = new List<string>();

        public Strecke(Panel panel, TextBox tbxVon, TextBox tbxNach)
        {
            streckePanel = panel;
            fromTextbox = tbxVon;
            toTextbox = tbxNach;
            streckePanel.Dock = DockStyle.Fill;
        }

        public void LoadPanel()
        {
            streckePanel.BringToFront();
        }

        internal void LoadStations(TextBox textBoxLoad)
        {
            stations = transport.GetStations(textBoxLoad.Text);
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
