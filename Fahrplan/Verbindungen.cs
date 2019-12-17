using SwissTransport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Fahrplan
{
    class Verbindungen
    {
        readonly Panel verbindungenPanel;
        readonly Transport transport = new Transport();

        public Verbindungen(Panel panel)
        {
            verbindungenPanel = panel;
            verbindungenPanel.Dock = DockStyle.Fill;
        }

        public void LoadPanel()
        {
            verbindungenPanel.BringToFront();
        }

        internal void LoadConnections(TextBox textBox)
        {
            Station station = transport.GetStations(textBox.Text).StationList.First();
            textBox.Text = station.Name;

            List<StationBoard> allStationBoards = transport.GetStationBoard(station.Name, station.Id).Entries;
            List<StationBoard> uniqueStationBoards = new List<StationBoard>();
            foreach (StationBoard stationBoard in allStationBoards)
            {
                if (!uniqueStationBoards.Any(unique => unique.Number == stationBoard.Number && unique.To == stationBoard.To))
                {
                    uniqueStationBoards.Add(stationBoard);
                }
            }

            uniqueStationBoards = uniqueStationBoards.OrderBy(o => o.Number).ToList();

        }
    }
}
