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
        Button btnVonDurchsuchen;
        Button btnNachDurchsuchen;

        public Strecke(Panel panel, MainFormMethods _mainFormMethods, Button _btnVonDurchsuchen, Button _btnNachDurchsuchen)
        {
            mainFormMethods = _mainFormMethods;
            streckePanel = panel;
            btnVonDurchsuchen = _btnVonDurchsuchen;
            btnNachDurchsuchen = _btnNachDurchsuchen;
            streckePanel.Dock = DockStyle.Fill;
        }

        public void LoadPanel()
        {
            streckePanel.BringToFront();
        }

        public void LoadStations(TextBox textBox)
        {
            stations.StationList = transport.GetStations(textBox.Text).StationList;

            foreach (Station station in stations.StationList)
            {
                stationNames.Add(station.Name);
            }
            textBox.AutoCompleteCustomSource.AddRange(stationNames.ToArray());

            string text = textBox.Text;
            textBox.Text = "";
            textBox.Focus();
            SendKeys.Send(text);
        }

        public void LoadConnections(string from, string to)
        {
            connections = transport.GetConnections(from, to).ConnectionList;
            mainFormMethods.LoadFahrplan(connections);
        }

        internal void VonTextChanged(TextBox textBox)
        {
            if (textBox.TextLength > 0)
            {
                btnVonDurchsuchen.Enabled = true;
            }
        }

        internal void NachTextChanged(TextBox textBox)
        {
            if (textBox.TextLength > 0)
            {
                btnNachDurchsuchen.Enabled = true;
            }
        }
    }
}
