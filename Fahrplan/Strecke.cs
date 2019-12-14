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
        readonly Button btnVonDurchsuchen;
        readonly Button btnNachDurchsuchen;

        public Strecke(Panel _pnlStrecke, TextBox _tbxVon, TextBox _tbxNach, Button _btnVonDurchsuchen, Button _btnNachDurchsuchen)
        {
            pnlStrecke         = _pnlStrecke;
            tbxVon             = _tbxVon;
            tbxNach            = _tbxNach;
            btnVonDurchsuchen  = _btnVonDurchsuchen;
            btnNachDurchsuchen = _btnNachDurchsuchen;

            pnlStrecke.Dock = DockStyle.Fill;
        }

        public void LoadPanel()
        {
            pnlStrecke.BringToFront();
        }

        public void VonTextChanged(TextBox textBox)
        {
            if (textBox.TextLength > 0)
            {
                btnVonDurchsuchen.Enabled = true;
            }
        }

        public void NachTextChanged(TextBox textBox)
        {
            if (textBox.TextLength > 0)
            {
                btnNachDurchsuchen.Enabled = true;
            }
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
