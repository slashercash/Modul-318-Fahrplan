using System;
using System.IO;
using System.Linq;
using System.Net;
using Newtonsoft.Json;

namespace SwissTransport
{
    public class Transport : ITransport
    {
        public Stations GetStations(string query)
        {
            try
            {
                query = System.Uri.EscapeDataString(query);
                var request = CreateWebRequest("http://transport.opendata.ch/v1/locations?query=" + query);
                var response = request.GetResponse();
                var responseStream = response.GetResponseStream();

                if (responseStream != null)
                {
                    var message = new StreamReader(responseStream).ReadToEnd();
                    var stations = JsonConvert.DeserializeObject<Stations>(message
                        , new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                    return stations;
                }

                return null;
            }
            catch (Exception exeption)
            {
                throw new System.InvalidOperationException("\nThere was an exeption in Transport GetStations() \nMessage: " + exeption.Message);
            }
        }

        public Stations GetStations(Coordinate coordinates)
        {
            try
            {
                if (coordinates != null)
                {
                    var request = CreateWebRequest("http://transport.opendata.ch/v1/locations?" +
                                                   $"x={coordinates.XCoordinate}&" +
                                                   $"y={coordinates.YCoordinate}");
                    var response = request.GetResponse();
                    var responseStream = response.GetResponseStream();

                    var message = new StreamReader(responseStream).ReadToEnd();
                    var stations = JsonConvert.DeserializeObject<Stations>(message
                        , new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

                    return stations;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception exeption)
            {
                throw new System.InvalidOperationException("\nThere was an exeption in Transport GetStations() \nMessage: " + exeption.Message);
            }
        }

        public StationBoardRoot GetStationBoard(string station, string id)
        {
            try
            {
                station = System.Uri.EscapeDataString(station);
                id = System.Uri.EscapeDataString(id);
                var request = CreateWebRequest("http://transport.opendata.ch/v1/stationboard?station=" + station + "&id=" + id);
                var response = request.GetResponse();
                var responseStream = response.GetResponseStream();

                if (responseStream != null)
                {
                    var readToEnd = new StreamReader(responseStream).ReadToEnd();
                    var stationboard =
                        JsonConvert.DeserializeObject<StationBoardRoot>(readToEnd);
                    return stationboard;
                }

                return null;
            }
            catch (Exception exeption)
            {
                throw new System.InvalidOperationException("\nThere was an exeption in Transport GetStationBoard() \nMessage: " + exeption.Message);
            }
        }

        public Connections GetConnections(string fromStation, string toStation)
        {
            try
            {
                fromStation = System.Uri.EscapeDataString(fromStation);
                toStation = System.Uri.EscapeDataString(toStation);
                var request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStation);
                var response = request.GetResponse();
                var responseStream = response.GetResponseStream();

                if (responseStream != null)
                {
                    var readToEnd = new StreamReader(responseStream).ReadToEnd();
                    var connections =
                        JsonConvert.DeserializeObject<Connections>(readToEnd);
                    return connections;
                }

                return null;
            }
            catch (Exception exeption)
            {
                throw new System.InvalidOperationException("\nThere was an exeption in Transport GetConnections() \nMessage: " + exeption.Message);
            }
        }


        public Connections GetConnections(string fromStation, string toStation, int connectionsCount, DateTime departureDateTime, bool isArrivalTime = false)
        {
            try
            {
                fromStation = System.Uri.EscapeDataString(fromStation);
                toStation = System.Uri.EscapeDataString(toStation);
                var request = CreateWebRequest(
                        "http://transport.opendata.ch/v1/connections?" +
                        $"from={fromStation}&to={toStation}" +
                        $"&limit={connectionsCount}" +
                        $"&date={departureDateTime:yyyy-MM-dd}" +
                        $"&time={departureDateTime:HH:mm}" +
                        $"&isArrivalTime={(isArrivalTime ? "1" : "0")}");
                var response = request.GetResponse();
                var responseStream = response.GetResponseStream();

                if (responseStream != null)
                {
                    var readToEnd = new StreamReader(responseStream).ReadToEnd();
                    if (!readToEnd.Contains("\"station\":{\"id\":null"))
                    {
                        var connections = JsonConvert.DeserializeObject<Connections>(readToEnd);
                        return connections;
                    }
                    return null;
                }
                return null;
            }
            catch (Exception exeption)
            {
                throw new System.InvalidOperationException("\nThere was an exeption in Transport GetConnections() \nMessage: " + exeption.Message);
            }
        }

        private static WebRequest CreateWebRequest(string url)
        {
            try
            {
                var request = WebRequest.Create(url);
                var webProxy = WebRequest.DefaultWebProxy;

                webProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
                request.Proxy = webProxy;

                return request;
            }
            catch (Exception exeption)
            {
                throw new System.InvalidOperationException("\nThere was an exeption in Transport CreateWebRequest() \nMessage: " + exeption.Message);
            }
        }

        public bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
