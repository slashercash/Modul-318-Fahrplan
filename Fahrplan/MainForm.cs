using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fahrplan
{
    public partial class MainForm : Form
    {
        MainFormMethods mainFormMethods;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Label[] connectionTable = new Label[] { lb1A, lb1B, lb1C, lb1D, lb2A, lb2B, lb2C, lb2D, lb3A, lb3B, lb3C, lb3D, lb4A, lb4B, lb4C, lb4D, lb5A, lb5B, lb5C, lb5D, lb6A, lb6B, lb6C, lb6D };
            mainFormMethods = new MainFormMethods(TpnlHeadButtons, PnlStrecke, PnlFahrplan, PnlVerbindungen, BtnStrecke, BtnFahrplan, BtnVerbindung, lbVonNach, connectionTable, tlpConnectionTable, tlpConnectionTableHeader, btnStreckeEingeben, btnVonDurchsuchen, btnNachDurchsuchen);
            mainFormMethods.LoadStrecke();
        }

        private void BtnStrecke_Click(object sender, EventArgs e)
        {
            mainFormMethods.LoadStrecke();
        }

        private void BtnFahrplan_Click(object sender, EventArgs e)
        {
            mainFormMethods.LoadFahrplan();
        }

        private void BtnVerbindung_Click(object sender, EventArgs e)
        {
            mainFormMethods.LoadVerbindung();
        }

        private void BtnVerbindungenAnzeigen_Click(object sender, EventArgs e)
        {
            mainFormMethods.OnBtnVerbindungenAnzeigenClick(TbxVon.Text, TbxNach.Text);
        }

        private void BtnVonDurchsuchen_Click(object sender, EventArgs e)
        {
            mainFormMethods.OnDurchsuchen(TbxVon);
        }

        private void BtnNachDurchsuchen_Click(object sender, EventArgs e)
        {
            mainFormMethods.OnDurchsuchen(TbxNach);
        }

        private void TbxVon_TextChanged(object sender, EventArgs e)
        {
            mainFormMethods.OnVonTextChanged((TextBox)sender);
        }

        private void TbxNach_TextChanged(object sender, EventArgs e)
        {
            mainFormMethods.OnNachTextChanged((TextBox)sender);
        }
    }
}
