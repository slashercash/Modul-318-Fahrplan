using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fahrplan
{
    public partial class MainForm : Form
    {
        Strecke strecke;
        Fahrplan fahrplan;
        Verbindungen verbindungen;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            strecke = new Strecke(PnlStrecke);
            fahrplan = new Fahrplan(PnlFahrplan);
            verbindungen = new Verbindungen(PnlVerbindungen);
            HilightButton(BtnStrecke);
            strecke.LoadPanel();
        }

        private void BtnStrecke_Click(object sender, EventArgs e)
        {
            HilightButton(BtnStrecke);
            strecke.LoadPanel();
        }

        private void BtnFahrplan_Click(object sender, EventArgs e)
        {
            HilightButton(BtnFahrplan);
            fahrplan.LoadPanel();
        }

        private void BtnVerbindung_Click(object sender, EventArgs e)
        {
            HilightButton(BtnVerbindung);
            verbindungen.LoadPanel();
        }

        private void HilightButton(Button hilightButton)
        {
            foreach (Button button in TableLayoutPanelHead.Controls)
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
