﻿namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoard(string station, string id);
        Connections GetConnections(string fromStation, string toStattion);
    Connections GetConnections(string fromStation, string toStation, string date, string time);

    Stations GetStations(string x, string y);
  }
}