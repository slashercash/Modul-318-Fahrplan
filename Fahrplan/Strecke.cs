using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SwissTransport;

namespace Fahrplan
{
    class Strecke
    {
        readonly Panel streckePanel;
        Transport transport = new Transport();
        Stations stations = new Stations();
        List<Connection> connections = new List<Connection>();
        List<string> stationNames = new List<string>();
        MainFormMethods mainFormMethods;

        public Strecke(Panel panel, MainFormMethods _mainFormMethods)
        {
            mainFormMethods = _mainFormMethods;
            streckePanel = panel;
            streckePanel.Dock = DockStyle.Fill;
        }

        public void LoadPanel()
        {
            streckePanel.BringToFront();
        }

        public void LoadStations(TextBox textBoxLoad)
        {
            try
            {
                stations.StationList = transport.GetStations(textBoxLoad.Text).StationList;

                foreach (Station station in stations.StationList)
                {
                    stationNames.Add(station.Name);
                }

                textBoxLoad.AutoCompleteCustomSource.AddRange(stationNames.ToArray());
            }
            catch (Exception)
            {
                throw new System.AccessViolationException("there was error in method LoadStations()");
            }
        }

        public void ClearStations(TextBox textBoxClear)
        {
            try
            {
                textBoxClear.AutoCompleteCustomSource.Clear();
            }
            catch (Exception)
            {
                throw new System.AccessViolationException("there was error in method ClearStations()");
            }
        }

        public void LoadConnections(string from, string to)
        {
            connections = transport.GetConnections(from, to).ConnectionList;
            mainFormMethods.LoadFahrplan(connections);
        }
    }
}
