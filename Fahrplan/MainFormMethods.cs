using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace Fahrplan
{
    class MainFormMethods
    {
        readonly TableLayoutPanel TpnlHeadButtons;
        readonly Strecke strecke;
        readonly Fahrplan fahrplan;
        readonly Verbindungen verbindungen;
        readonly Button BtnStrecke;
        readonly Button BtnFahrplan;
        readonly Button BtnVerbindung;

        public MainFormMethods(TableLayoutPanel tableLayoutPanel, Panel pnlStrecke, Panel pnlFahrplan, Panel pnlVerbindungen, Button _BtnStrecke, Button _BtnFahrplan, Button _BtnVerbindung, Label lbFromTo, Label[] connectionTable, TableLayoutPanel tlpConnectionTable, TableLayoutPanel tlpConnectionTableHeader, Button btnStreckeEingeben, Button btnVonDurchsuchen, Button btnNachDurchsuchen)
        {
            TpnlHeadButtons = tableLayoutPanel;
            BtnStrecke = _BtnStrecke;
            BtnFahrplan = _BtnFahrplan;
            BtnVerbindung = _BtnVerbindung;
            strecke = new Strecke(pnlStrecke, this, btnVonDurchsuchen, btnNachDurchsuchen);
            fahrplan = new Fahrplan(pnlFahrplan, lbFromTo, connectionTable, tlpConnectionTable, tlpConnectionTableHeader, btnStreckeEingeben);
            verbindungen = new Verbindungen(pnlVerbindungen);
        }

        public void LoadStrecke()
        {
            HilightButton(BtnStrecke);
            strecke.LoadPanel();
        }

        public void LoadFahrplan()
        {
            HilightButton(BtnFahrplan);
            fahrplan.LoadPanel();
        }

        internal void LoadFahrplan(List<Connection> connections)
        {
            HilightButton(BtnFahrplan);
            fahrplan.LoadConnections(connections);
            fahrplan.LoadPanel();
        }

        public void LoadVerbindung()
        {
            HilightButton(BtnVerbindung);
            verbindungen.LoadPanel();
        }

        public void OnBtnVerbindungenAnzeigenClick(string from, string to)
        {
            strecke.LoadConnections(from, to);
        }

        internal void OnVonTextChanged(TextBox textBox)
        {
            strecke.VonTextChanged(textBox);
        }

        internal void OnNachTextChanged(TextBox textBox)
        {
            strecke.NachTextChanged(textBox);
        }

        public void OnDurchsuchen(TextBox textBox)
        {
            strecke.LoadStations(textBox);
        }

        private void HilightButton(Button hilightButton)
        {
            foreach (Button button in TpnlHeadButtons.Controls)
            {
                if (button.Name.Equals(hilightButton.Name))
                {
                    button.BackColor = Color.Honeydew;
                    button.FlatAppearance.MouseOverBackColor = Color.Honeydew;
                }
                else
                {
                    button.BackColor = Color.LightGreen;
                    button.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
                }
            }
        }
    }
}
