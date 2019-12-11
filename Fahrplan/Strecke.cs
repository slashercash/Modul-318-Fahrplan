using System.Windows.Forms;

namespace Fahrplan
{
    class Strecke
    {
        readonly Panel streckePanel;

        public Strecke(Panel panel)
        {
            streckePanel = panel;
            streckePanel.Dock = DockStyle.Fill;
        }

        public void LoadPanel()
        {
            streckePanel.BringToFront();
        }
    }
}
