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
            Label[] lbTimeTable = new Label[] { lb1A, lb1B, lb1C, lb1D, lb2A, lb2B, lb2C, lb2D, lb3A, lb3B, lb3C, lb3D, lb4A, lb4B, lb4C, lb4D, lb5A, lb5B, lb5C, lb5D, lb6A, lb6B, lb6C, lb6D };

            strecke = new Strecke(this, pnlStrecke, tbxVon, tbxNach, tbxAb, datePicker, timePicker, btnFahrplanAnzeigen);
            fahrplan = new Fahrplan(this, pnlFahrplan, tlpTimeTable, tlpTimeTableHeader, btnStreckeEingeben, lbVonNach, lbGleisKante, lbTimeTable);
            verbindungen = new Verbindungen(pnlVerbindungen, tlpConnectionsTable, tlpConnectionsHeader, this, tbxAb);

            pnlNoInternet.Dock = DockStyle.Fill;

            datePicker.CustomFormat = "ddd, dd. MMMM";
            timePicker.CustomFormat = "HH:mm";
            timePicker.ShowUpDown = true;

            tlpConnectionsTable.HorizontalScroll.Maximum = 0;
            tlpConnectionsTable.HorizontalScroll.Enabled = false;
            tlpConnectionsTable.AutoScroll = true;

            HilightButton(btnStrecke.Name);
            strecke.LoadPanel(false);
        }

        private void BtnStrecke_Click(object sender, EventArgs e)
        {
            HilightButton(btnStrecke.Name);
            strecke.LoadPanel(false);
        }

        private void BtnFahrplan_Click(object sender, EventArgs e)
        {
            HilightButton(btnFahrplan.Name);
            fahrplan.LoadPanel();
        }

        private void BtnVerbindung_Click(object sender, EventArgs e)
        {
            HilightButton(btnVerbindung.Name);
            verbindungen.LoadPanel();
        }

        private void BtnFahrplanAnzeigen_Click(object sender, EventArgs e)
        {
            HilightButton(btnFahrplan.Name);
            fahrplan.LoadTimeTable(tbxVon.Text, tbxNach.Text, datePicker.Value, timePicker.Value);
        }

        private void BtnVonDurchsuchen_Click(object sender, EventArgs e)
        {
            strecke.LoadStations(tbxVon);
        }

        private void BtnNachDurchsuchen_Click(object sender, EventArgs e)
        {
            strecke.LoadStations(tbxNach);
        }

        private void BtnAbDurchsuchen_Click(object sender, EventArgs e)
        {
            strecke.LoadStations(tbxAb);
        }

        private void TbxVonNachAb_KeyDown(object sender, KeyEventArgs key)
        {
            strecke.VonNachAbKeyDown((TextBox)sender, key);
        }

        private void TbxVon_TextChanged(object sender, EventArgs e)
        {
            strecke.VonNachTextChanged((TextBox)sender, btnVonDurchsuchen, btnVonStandortAnzeigen);
        }

        private void TbxNach_TextChanged(object sender, EventArgs e)
        {
            strecke.VonNachTextChanged((TextBox)sender, btnNachDurchsuchen, btnNachStandortAnzeigen);
        }

        private void TbxAb_TextChanged(object sender, EventArgs e)
        {
            strecke.VonNachTextChanged((TextBox)sender, btnAbDurchsuchen, btnAbStandortAnzeigen);
        }

        private void BtnAbfahrtsZeit_Click(object sender, EventArgs e)
        {
            fahrplan.SetArrivalDeparture(btnAbfahrtsZeit, btnAnkunftsZeit, false);
        }

        private void BtnAnkunftsZeit_Click(object sender, EventArgs e)
        {
            fahrplan.SetArrivalDeparture(btnAnkunftsZeit, btnAbfahrtsZeit, true);
        }

        private void BtnVonStandortAnzeigen_Click(object sender, EventArgs e)
        {
            strecke.LoadLocation(tbxVon);
        }

        private void BtnNachStandortAnzeigen_Click(object sender, EventArgs e)
        {
            strecke.LoadLocation(tbxNach);
        }

        private void BtnAbStandortAnzeigen_Click(object sender, EventArgs e)
        {
            strecke.LoadLocation(tbxAb);
        }

        private void BtnChangeDirection_Click(object sender, EventArgs e)
        {
            strecke.ChangeDirection();
        }

        private void BtnVerbindungenAnzeigen_Click(object sender, EventArgs e)
        {
            verbindungen.LoadConnections(tbxAb);
        }

        public void BtnSelectConnection_Click(object sender, EventArgs e)
        {
            strecke.SetFromTo(((Button)sender).Tag.ToString());
            HilightButton(btnStrecke.Name);
            strecke.LoadPanel(true);
        }

        private void BtnErneutVersuchen_Click(object sender, EventArgs e)
        {
            strecke.CheckInternetConnection();
        }

        public void LoadNoConnectionPanel()
        {
            EnableHeaderButtons(false);
            pnlNoInternet.BringToFront();
        }

        public void EnableHeaderButtons(bool enable)
        {
            if(enable)
            {
                foreach (Button button in tlpHeadButtons.Controls)
                {
                    button.Enabled = true;
                }
            }
            else
            {
                foreach (Button button in tlpHeadButtons.Controls)
                {
                    button.Enabled = false;
                    button.BackColor = Color.LightGreen;
                    button.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
                }
            }
        }

        private void HilightButton(string hilightButton)
        {
            foreach (Button button in tlpHeadButtons.Controls)
            {
                if (button.Name.Equals(hilightButton))
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
