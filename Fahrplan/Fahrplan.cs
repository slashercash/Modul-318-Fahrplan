using System.Windows.Forms;

namespace Fahrplan
{
    class Fahrplan
    {
        readonly Panel fahrplanPanel;

        public Fahrplan(Panel panel)
        {
            fahrplanPanel = panel;
            fahrplanPanel.Dock = DockStyle.Fill;
        }

        public void LoadPanel()
        {
            fahrplanPanel.BringToFront();
        }
    }
}
