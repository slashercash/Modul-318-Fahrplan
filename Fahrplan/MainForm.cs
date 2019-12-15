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
            Label[] lbConnectionTable = new Label[] { lb1A, lb1B, lb1C, lb1D, lb2A, lb2B, lb2C, lb2D, lb3A, lb3B, lb3C, lb3D, lb4A, lb4B, lb4C, lb4D, lb5A, lb5B, lb5C, lb5D, lb6A, lb6B, lb6C, lb6D };

            strecke = new Strecke(pnlStrecke, tbxVon, tbxNach);
            fahrplan = new Fahrplan(pnlFahrplan, tlpConnectionTable, tlpConnectionTableHeader, btnStreckeEingeben, lbVonNach, lbGleisKante, lbConnectionTable);
            verbindungen = new Verbindungen(pnlVerbindungen);

            HilightButton(btnStrecke);
            strecke.LoadPanel();
        }

        private void BtnStrecke_Click(object sender, EventArgs e)
        {
            HilightButton(btnStrecke);
            strecke.LoadPanel();
        }

        private void BtnFahrplan_Click(object sender, EventArgs e)
        {
            HilightButton(btnFahrplan);
            fahrplan.LoadPanel();
        }

        private void BtnVerbindung_Click(object sender, EventArgs e)
        {
            HilightButton(btnVerbindung);
            verbindungen.LoadPanel();
        }

        private void BtnVerbindungenAnzeigen_Click(object sender, EventArgs e)
        {
            HilightButton(btnFahrplan);
            fahrplan.LoadConnections(tbxVon.Text, tbxNach.Text);
        }

        private void BtnVonDurchsuchen_Click(object sender, EventArgs e)
        {
            strecke.LoadStations(tbxVon);
        }

        private void BtnNachDurchsuchen_Click(object sender, EventArgs e)
        {
            strecke.LoadStations(tbxNach);
        }

        private void TbxVonNach_KeyDown(object sender, KeyEventArgs key)
        {
            strecke.VonNachKeyDown((TextBox)sender, key);
        }

        private void TbxVon_TextChanged(object sender, EventArgs e)
        {
            strecke.VonNachTextChanged((TextBox)sender, btnVonDurchsuchen);
        }

        private void TbxNach_TextChanged(object sender, EventArgs e)
        {
            strecke.VonNachTextChanged((TextBox)sender, btnNachDurchsuchen);
        }

        private void HilightButton(Button hilightButton)
        {
            foreach (Button button in tlpHeadButtons.Controls)
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
