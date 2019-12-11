using System.Windows.Forms;

namespace Fahrplan
{
    class Verbindungen
    {
        readonly Panel verbindungenPanel;

        public Verbindungen(Panel panel)
        {
            verbindungenPanel = panel;
            verbindungenPanel.Dock = DockStyle.Fill;
        }

        public void LoadPanel()
        {
            verbindungenPanel.BringToFront();
        }
    }
}
