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
        bool stationsLoaded = false;

        public MainFormMethods(TableLayoutPanel tableLayoutPanel, Panel pnlStrecke, Panel pnlFahrplan, Panel pnlVerbindungen, Button _BtnStrecke, Button _BtnFahrplan, Button _BtnVerbindung, ListView lvConnections)
        {
            TpnlHeadButtons = tableLayoutPanel;
            BtnStrecke = _BtnStrecke;
            BtnFahrplan = _BtnFahrplan;
            BtnVerbindung = _BtnVerbindung;
            strecke = new Strecke(pnlStrecke, this);
            fahrplan = new Fahrplan(pnlFahrplan, lvConnections);
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

        internal void LoadFahrplan(Connections connections)
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

        public void OnTextChanged(TextBox textBox)
        {
            if (textBox.TextLength >= 3 && !stationsLoaded)
            {
                //strecke.LoadStations(textBox);
                stationsLoaded = true;
            }
            else if (textBox.TextLength <= 2 && stationsLoaded)
            {
                //strecke.ClearStations(textBox);
                stationsLoaded = false;
            }
        }
    }
}
