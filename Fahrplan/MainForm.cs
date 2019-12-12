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
            mainFormMethods = new MainFormMethods(TpnlHeadButtons, PnlStrecke, PnlFahrplan, PnlVerbindungen, BtnStrecke, BtnFahrplan, BtnVerbindung, lvConnections);
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

        private void TbxVon_TextChanged(object sender, EventArgs e)
        {
            mainFormMethods.OnTextChanged(TbxVon);
        }

        private void TbxNach_TextChanged(object sender, EventArgs e)
        {
            mainFormMethods.OnTextChanged(TbxNach);
        }

    }
}
