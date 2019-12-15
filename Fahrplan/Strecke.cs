using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SwissTransport;

namespace Fahrplan
{
    class Strecke
    {
        readonly Transport transport = new Transport();
        readonly Stations stations = new Stations();
        readonly List<string> stationNames = new List<string>();

        readonly Panel pnlStrecke;
        readonly TextBox tbxVon;
        readonly TextBox tbxNach;

        public Strecke(Panel _pnlStrecke, TextBox _tbxVon, TextBox _tbxNach)
        {
            pnlStrecke         = _pnlStrecke;
            tbxVon             = _tbxVon;
            tbxNach            = _tbxNach;

            pnlStrecke.Dock = DockStyle.Fill;
        }

        public void LoadPanel()
        {
            pnlStrecke.BringToFront();
        }

        internal void VonNachKeyDown(TextBox textBox, KeyEventArgs key)
        {
            if(key.KeyCode == Keys.Enter && textBox.TextLength > 0)
            {
                LoadStations(textBox);
            }
        }

        public void VonNachTextChanged(TextBox textBox, Button button)
        {
            button.Enabled = textBox.TextLength == 0 ? false : true;
        }

        public void LoadStations(TextBox textBox)
        {
            stations.StationList = transport.GetStations(textBox.Text).StationList;

            foreach (Station station in stations.StationList)
            {
                stationNames.Add(station.Name);
            }
            tbxVon.AutoCompleteCustomSource.AddRange(stationNames.ToArray());
            tbxNach.AutoCompleteCustomSource.AddRange(stationNames.ToArray());

            string text = textBox.Text;
            textBox.Text = "";
            textBox.Focus();
            SendKeys.Send(text);
        }
    }
}
