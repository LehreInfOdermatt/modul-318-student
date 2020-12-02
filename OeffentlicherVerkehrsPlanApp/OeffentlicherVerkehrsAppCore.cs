using System;
using System.Collections.Generic;
using System.Linq;
using SwissTransport;

namespace OeffentlicherVerkehrsPlanApp
{
  public class OeffentlicherVerkehrsAppCore
  {
    private ITransport transport = new Transport();

    public string getStation(string Station) 
    {
      var Stations = transport.GetStations(Station).StationList;
      if (Stations.Count == 0) 
      {
        return null;
      } 
      else 
      {
        return Stations.First().Name;
      }
      
    }

    public Coordinate getCoordinatesOf(string Station) 
    {
      if (getStation(Station) != null) 
      {
        return transport.GetStations(Station).StationList.First().Coordinate;
      } 
      else 
      {
        return null;
      }
    }

    public List<String> getStations(string Stations) 
    {
      List<String> strings = new List<string>();
      foreach (var Station in transport.GetStations(Stations).StationList) 
      {
        strings.Add(Station.Name);
      }
      return strings;
    }

    public List<String> getStations(string Stations, int max)
    {
      List<String> strings = new List<string>();
      foreach (var Station in transport.GetStations(Stations).StationList)
      {
        strings.Add(Station.Name);
      }
      if (strings.Count < max)
      {
        return strings.GetRange(0, strings.Count);
      }
      else 
      {
        return strings.GetRange(0, max);
      }
      
    }

    internal List<Connection> getConnections(string text1, string text2)
    {
      return transport.GetConnections(text1, text2).ConnectionList;
    }

    internal StationBoardRoot getStationBoard(string station)
    {
      return transport.GetStationBoard(station, getStation(station));
    }

    public List<Connection> getConnections(string text1, string text2, string text3, string text4) 
    {
      return transport.GetConnections(text1, text2, text3, text4).ConnectionList;
    }

    public List<String> getStations(string x, string y)
    {
      List<String> strings = new List<string>();
      foreach (var Station in transport.GetStations(x, y).StationList)
      {
        strings.Add(Station.Name);
      }
      return strings;
    }
  }
}
