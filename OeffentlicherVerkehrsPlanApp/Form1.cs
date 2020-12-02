using System;
using System.Linq;
using System.Windows.Forms;
using System.Device.Location;
using System.Diagnostics;

namespace OeffentlicherVerkehrsPlanApp
{
  public partial class OVPApp : Form
  {
    private OeffentlicherVerkehrsAppCore ovpCore = new OeffentlicherVerkehrsAppCore();
    private const int NUMBER_OF_CONNECTIONS_TO_DISPLAY = 4;

    public OVPApp()
    {
      InitializeComponent();
    }

    private void btnShowBoard_Click(object sender, EventArgs e)
    {
      var board = ovpCore.getStationBoard(BoardSelectComboBox.Text);

      foreach (var entrie in board.Entries) 
      {
        BoardDataGrid.Rows.Add(entrie.Name,entrie.Number,entrie.To);
      }

    }

    private void cmbVon_TextChanged(object sender, EventArgs e)
    {
      
    }

    private void cmbVon_SelectedValueChanged(object sender, EventArgs e)
    {

    }

    private void tbxSearch_Change(object sender, KeyEventArgs e)
    {
      if (e.KeyData != Keys.Up && e.KeyData != Keys.Down && e.KeyData != Keys.Enter && e.KeyData != Keys.Tab) 
      {

        var comboBox = (ComboBox)sender;
        string varia = comboBox.Text;
        comboBox.SelectedIndex = -1;
        comboBox.SelectionStart = comboBox.Text.Length;
        comboBox.SelectionLength = 0;
        if (comboBox.Text == "")
        {
          comboBox.DropDownStyle = ComboBoxStyle.DropDown;
          comboBox.Items.Clear();
        }
        else
        {
          comboBox.Items.Clear();
          foreach (var variable in ovpCore.getStations(comboBox.Text, 4))
          {
            if (variable != null) 
            { 
              comboBox.Items.Add(variable); 
            }
            
          }
          comboBox.DropDownStyle = ComboBoxStyle.Simple;
          comboBox.Height = 80;
          comboBox.SelectionStart = comboBox.Text.Length;
          comboBox.SelectionLength = 0;
          comboBox.Text = varia;
        }
      } 
      else if (e.KeyData == Keys.Enter) 
      {
        ((ComboBox)sender).DropDownStyle = ComboBoxStyle.DropDown;
      }
    }

    private void tabPage1_Click(object sender, EventArgs e)
    {

    }
    private GeoCoordinateWatcher watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.Default);
    private void btnCurrentLocation_Click(object sender, EventArgs e)
    {
      var Location = watcher.Position.Location;
      var Latitude = Location.Latitude.ToString();
      var Longitude = Location.Longitude.ToString();

      if (Location.IsUnknown) 
      {
        switch (((Button)sender).Name)
        {
          case "btnCLVon":
            VonStationComboBox.Text = "Position nicht gefunden";
            break;
          case "btnCLBis":
            BisStationComboBox.Text = "Position nicht gefunden";
            break;
        }
      } 
      else
      {
        switch (((Button)sender).Name)
        {
          case "btnCLVon":
            VonStationComboBox.Text = ovpCore.getStations(Latitude, Longitude).First();
            break;
          case "btnCLBis":
            BisStationComboBox.Text = ovpCore.getStations(Latitude, Longitude).First();
            break;
        }
      }
      
    }

    private void ConnectionSearch(object sender, EventArgs e)
    {
      VonStationComboBox.Text = ovpCore.getStation(VonStationComboBox.Text);
      BisStationComboBox.Text = ovpCore.getStation(BisStationComboBox.Text);
      string searchDate = datePickerConnections.Value.ToString("yyyy-MM-dd");
      string searchTime = timePickerConnections.Value.ToString("HH:mm");
      var connections = ovpCore.getConnections(VonStationComboBox.Text, BisStationComboBox.Text, searchDate, searchTime);

      if (connections.Count != 0) 
      {
        for (int i = 1; i <= NUMBER_OF_CONNECTIONS_TO_DISPLAY; ++i)
        {
          var currentElement = connections.ElementAt(i - 1);
          ConnectionsDataGrid.Rows.Add(currentElement.From.Platform, currentElement.From.Departure, currentElement.To.Arrival);
        }
      }
      
    }

    private void ShowVonLocationOnMap(object sender, EventArgs e)
    {
      var VonStationCoordinat = ovpCore.getCoordinatesOf(VonStationComboBox.Text);
      if(VonStationCoordinat != null) 
      {
        string googleUrl = "https://www.google.ch/maps/?q=loc:" + VonStationCoordinat.XCoordinate.ToString().Replace(",", ".") + "+" + VonStationCoordinat.YCoordinate.ToString().Replace(",", ".");
        Process.Start(googleUrl);
      }
      
    }

    private void ShowBisLocationOnMap(object sender, EventArgs e)
    {
      var BisStationCoordinat = ovpCore.getCoordinatesOf(BisStationComboBox.Text);
      if (BisStationCoordinat != null)
      {
        string googleUrl = "https://www.google.ch/maps/?q=loc:" + BisStationCoordinat.XCoordinate.ToString().Replace(",", ".") + "+" + BisStationCoordinat.YCoordinate.ToString().Replace(",", ".");
        Process.Start(googleUrl);
      }
    }
  }
}
