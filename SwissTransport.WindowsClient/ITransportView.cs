using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransport.WindowsClient
{
    public interface ITransportView
    {
        void SetFromStation(string value);
        void SetToStation(string value);
        void SetPossibleStations(List<string> value, StationKinds StationKind);
        void SetOnShowConnections(EventHandler Event);
        void SetOnGetSuggestions(EventHandler FromEvent, EventHandler ToEvent);

        string GetFromStation();
        string GetToStation();
        string GetDate();
        string GetTime();

        /// <summary>
        /// Adds a new connection to the Form. Used for both normal connections and the station board
        /// </summary>
        /// <param name="from">starting Station</param>
        /// <param name="to">end Station</param>
        /// <param name="Departure">Departure Time</param>
        /// <param name="Arrival">Arrival Time. Empty for the station board</param>
        /// <param name="toPlatform">Platform at the end Station, empty for station board</param>
        /// <param name="fromPlatform">Platform at the start Station</param>
        /// <param name="Duration">Duration of travel, empty for the station board</param>
        void AddNewConnection(string from, string to, string Departure, string Arrival,
            string toPlatform, string fromPlatform, string Duration);
    }
}
