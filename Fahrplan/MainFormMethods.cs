using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrplan
{
    class MainFormMethods
    {
        readonly TableLayoutPanel TpnlHeadButtons;
        readonly Strecke strecke;
        readonly Fahrplan fahrplan;
        readonly Verbindungen verbindungen;

        public MainFormMethods(TableLayoutPanel tableLayoutPanel, Panel pnlStrecke, Panel pnlFahrplan, Panel pnlVerbindungen)
        {
            TpnlHeadButtons = tableLayoutPanel;
            strecke = new Strecke(pnlStrecke);
            fahrplan = new Fahrplan(pnlFahrplan);
            verbindungen = new Verbindungen(pnlVerbindungen);
        }

        internal void OnBtnStreckeClick(Button button)
        {
            HilightButton(button);
            strecke.LoadPanel();
        }

        internal void OnBtnFahrplanClick(Button button)
        {
            HilightButton(button);
            fahrplan.LoadPanel();
        }

        internal void OnBtnVernindungClick(Button button)
        {
            HilightButton(button);
            verbindungen.LoadPanel();
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
            if (textBox.TextLength == 3)
            {
                strecke.LoadStations(textBox);
            }
            else if (textBox.TextLength < 3)
            {
                strecke.ClearStations(textBox);
            }
        }
    }
}
