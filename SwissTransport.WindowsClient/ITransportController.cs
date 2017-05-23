using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransport.WindowsClient
{
    public interface ITransportController
    {
        void SetAllViewHandlers();
        void NewConnection(string fromStation , string toStation, string date, string time);
        void NewStationBoard(string Station);
        void StationQuery(string Query, StationKinds StationKind);
    }
}
