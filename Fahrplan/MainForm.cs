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
            mainFormMethods = new MainFormMethods(TpnlHeadButtons, PnlStrecke, PnlFahrplan, PnlVerbindungen);
            mainFormMethods.OnBtnStreckeClick(BtnStrecke);
        }

        private void BtnStrecke_Click(object sender, EventArgs e)
        {
            mainFormMethods.OnBtnStreckeClick(BtnStrecke);
        }

        private void BtnFahrplan_Click(object sender, EventArgs e)
        {
            mainFormMethods.OnBtnFahrplanClick(BtnFahrplan);
        }

        private void BtnVerbindung_Click(object sender, EventArgs e)
        {
            mainFormMethods.OnBtnVernindungClick(BtnVerbindung);
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
