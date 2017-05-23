using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransport.WindowsClient
{
    public enum StationKinds { To, From }

    /// <summary>
    /// The Main Controller of the Application
    /// </summary>
    public class MainController : ITransportController
    {
        ITransport _Transport = null;
        ITransportView _View = null;

        public MainController()
        {
            _Transport = new Transport();
            _View = new frmMain();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="transport"></param>
        /// <param name="view"></param>
        public MainController(ITransport transport, ITransportView view)
        {
            _Transport = transport;
            _View = view;
        }

#region EventHandlers
        public void ShowConnectionsHandler(Object sender, EventArgs e)
        {
            try
            {
                if (_View.GetToStation() == "Alle Richtungen")
                    NewStationBoard(_View.GetFromStation());
                else
                    NewConnection(_View.GetFromStation(), _View.GetToStation(), _View.GetDate(), _View.GetTime());
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Es ist ein Fehler bei der Suche nach Verbindungen aufgetreten \r\n\r\n"
                    + ex.Message + "\r\n\r\n Es können keine Verbindungen angezeigt werden.");
            }
        }

        public void GetSuggestionsForFromStationHandler(Object sender, EventArgs e)
        {
            try
            {
                string query = _View.GetFromStation();
                StationQuery(query, StationKinds.From);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Es ist ein Fehler bei der Suche nach Start-Stationen aufgetreten: \r\n\r\n"
                    + ex.Message + "\r\n\r\n Es können keine Vorschläge angezeigt werden.");
            }
        }

        public void GetSuggestionsForToStationHandler(Object sender, EventArgs e)
        {
            try
            {
                string query = _View.GetToStation();
                StationQuery(query, StationKinds.To);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Es ist ein Fehler bei der Suche nach End-Stationen aufgetreten. \r\n\r\n"
                    + ex.Message + "\r\n\r\n Es können keine Vorschläge angezeigt werden.");
            }
        }
#endregion

        /// <summary>
        /// Sets the Eventshandlers on _View, they will be executed after the 
        /// Eventhandlers implemented on the View itself
        /// </summary>
        public void SetAllViewHandlers()
        {
            _View.SetOnShowConnections(ShowConnectionsHandler);
            _View.SetOnGetSuggestions(GetSuggestionsForFromStationHandler, GetSuggestionsForToStationHandler);
        }
     
        /// <summary>
        /// Gets the connections from the API and Adds them all to the Form
        /// </summary>
        /// <param name="fromStation">start Station string</param>
        /// <param name="toStation">end Station string</param>
        public void NewConnection(string fromStation, string toStation, string date, string time)
        {
            if (fromStation == "" || toStation == "")
                return;

            if (fromStation == toStation)
                throw new System.Exception("Startstation und Endstation dürfen nicht gleich sein!");

            Connections TempConnections = _Transport.GetConnections(fromStation, toStation, date, time);

            if (TempConnections.ConnectionList.Count == 0)
                throw new System.Exception("Keine Verbindungen gefunden. Fehler bei API abfrage");

            foreach (Connection connect in TempConnections.ConnectionList)
            {
                _View.AddNewConnection(connect.From.Station.Name, connect.To.Station.Name,
                    FormatArrivalDeparture(connect.From.Departure), FormatArrivalDeparture(connect.To.Arrival),
                    connect.To.Platform, connect.From.Platform, FormatDuration(connect.Duration));
            }
        }

        /// <summary>
        /// searches the list for the Id of the "fromStation", if found it
        /// gets a new station board from the API, Adds all the new Data on the Form.
        /// </summary>
        /// <param name="fromStation">Requested station string</param>
        public void NewStationBoard(string fromStation)
        {
            string id = "";
            List<Station> QueriedStations = _Transport.GetStations(fromStation).StationList;

            foreach (Station TempStation in QueriedStations)
            {
                if (TempStation.Name == fromStation)
                {
                    id = TempStation.Id;
                    break;
                }
            }

            if (id == "")
                return;

            StationBoardRoot BoardRoot = _Transport.GetStationBoard(fromStation, id);

            foreach (StationBoard Board in BoardRoot.Entries)
            {
                _View.AddNewConnection(Board.Name, Board.To, Board.Stop.Departure.ToString(), "",
                    "", BoardRoot.Station.Name, "");
            }
        }

        /// <summary>
        /// Queries the API for Station Suggestions and Sets them on the View
        /// </summary>
        /// <param name="query">Query string</param>
        /// <param name="stationKind">Which Stationkind needs the Suggestions, important
        /// for the View</param>
        public void StationQuery(string query, StationKinds stationKind)
        {
            List<Station> QueriedStations = _Transport.GetStations(query).StationList;
            List<string> StationStrings = new List<string>();
            if (stationKind == StationKinds.To)
                StationStrings.Add("Alle Richtungen");

            foreach (Station TempStation in QueriedStations)
                StationStrings.Add(TempStation.Name);

             _View.SetPossibleStations(StationStrings, stationKind);
        }

        private string FormatArrivalDeparture(string value)
        {
            value = value.Remove(0, value.IndexOf("T")+ 1);
            value = value.Remove(value.IndexOf("+"));

            return value;            
        }

        private string FormatDuration(string value)
        {
            value = value.Remove(0, value.IndexOf("d") + 1);

            return value;
        }
    }
}
