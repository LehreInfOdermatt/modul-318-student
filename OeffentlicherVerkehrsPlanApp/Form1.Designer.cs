namespace OeffentlicherVerkehrsPlanApp
{
  partial class OVPApp
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.tab = new System.Windows.Forms.TabControl();
      this.ConnectionsTab = new System.Windows.Forms.TabPage();
      this.ConnectionTimeGroup = new System.Windows.Forms.GroupBox();
      this.timePickerConnections = new System.Windows.Forms.DateTimePicker();
      this.datePickerConnections = new System.Windows.Forms.DateTimePicker();
      this.ConnectionsDataGrid = new System.Windows.Forms.DataGridView();
      this.Train = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ConnectionSearchButton = new System.Windows.Forms.Button();
      this.VonStationGroup = new System.Windows.Forms.GroupBox();
      this.button2 = new System.Windows.Forms.Button();
      this.btnCLVon = new System.Windows.Forms.Button();
      this.VonStationComboBox = new System.Windows.Forms.ComboBox();
      this.BisStationGroup = new System.Windows.Forms.GroupBox();
      this.button4 = new System.Windows.Forms.Button();
      this.btnCLBis = new System.Windows.Forms.Button();
      this.BisStationComboBox = new System.Windows.Forms.ComboBox();
      this.BoardTab = new System.Windows.Forms.TabPage();
      this.BoardOfGroup = new System.Windows.Forms.GroupBox();
      this.BoardSelectComboBox = new System.Windows.Forms.ComboBox();
      this.BoardSearchButton = new System.Windows.Forms.Button();
      this.BoardTimeGroup = new System.Windows.Forms.GroupBox();
      this.timePickerBoard = new System.Windows.Forms.DateTimePicker();
      this.datePickerBoard = new System.Windows.Forms.DateTimePicker();
      this.BoardDataGrid = new System.Windows.Forms.DataGridView();
      this.FahrzeugName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tab.SuspendLayout();
      this.ConnectionsTab.SuspendLayout();
      this.ConnectionTimeGroup.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ConnectionsDataGrid)).BeginInit();
      this.VonStationGroup.SuspendLayout();
      this.BisStationGroup.SuspendLayout();
      this.BoardTab.SuspendLayout();
      this.BoardOfGroup.SuspendLayout();
      this.BoardTimeGroup.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.BoardDataGrid)).BeginInit();
      this.SuspendLayout();
      // 
      // tab
      // 
      this.tab.Controls.Add(this.ConnectionsTab);
      this.tab.Controls.Add(this.BoardTab);
      this.tab.Location = new System.Drawing.Point(12, 12);
      this.tab.Name = "tab";
      this.tab.SelectedIndex = 0;
      this.tab.Size = new System.Drawing.Size(804, 531);
      this.tab.TabIndex = 0;
      // 
      // ConnectionsTab
      // 
      this.ConnectionsTab.Controls.Add(this.ConnectionTimeGroup);
      this.ConnectionsTab.Controls.Add(this.ConnectionsDataGrid);
      this.ConnectionsTab.Controls.Add(this.ConnectionSearchButton);
      this.ConnectionsTab.Controls.Add(this.VonStationGroup);
      this.ConnectionsTab.Controls.Add(this.BisStationGroup);
      this.ConnectionsTab.Location = new System.Drawing.Point(4, 22);
      this.ConnectionsTab.Name = "ConnectionsTab";
      this.ConnectionsTab.Padding = new System.Windows.Forms.Padding(3);
      this.ConnectionsTab.Size = new System.Drawing.Size(796, 505);
      this.ConnectionsTab.TabIndex = 0;
      this.ConnectionsTab.Text = "Verbindungen Suchen";
      this.ConnectionsTab.UseVisualStyleBackColor = true;
      this.ConnectionsTab.Click += new System.EventHandler(this.tabPage1_Click);
      // 
      // ConnectionTimeGroup
      // 
      this.ConnectionTimeGroup.Controls.Add(this.timePickerConnections);
      this.ConnectionTimeGroup.Controls.Add(this.datePickerConnections);
      this.ConnectionTimeGroup.Location = new System.Drawing.Point(616, 13);
      this.ConnectionTimeGroup.Name = "ConnectionTimeGroup";
      this.ConnectionTimeGroup.Size = new System.Drawing.Size(147, 77);
      this.ConnectionTimeGroup.TabIndex = 15;
      this.ConnectionTimeGroup.TabStop = false;
      this.ConnectionTimeGroup.Text = "Zeiteinschränkungen";
      // 
      // timePickerConnections
      // 
      this.timePickerConnections.Format = System.Windows.Forms.DateTimePickerFormat.Time;
      this.timePickerConnections.Location = new System.Drawing.Point(25, 45);
      this.timePickerConnections.Name = "timePickerConnections";
      this.timePickerConnections.ShowUpDown = true;
      this.timePickerConnections.Size = new System.Drawing.Size(106, 20);
      this.timePickerConnections.TabIndex = 7;
      // 
      // datePickerConnections
      // 
      this.datePickerConnections.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.datePickerConnections.Location = new System.Drawing.Point(25, 19);
      this.datePickerConnections.Name = "datePickerConnections";
      this.datePickerConnections.Size = new System.Drawing.Size(106, 20);
      this.datePickerConnections.TabIndex = 7;
      // 
      // ConnectionsDataGrid
      // 
      this.ConnectionsDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
      this.ConnectionsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.ConnectionsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Train,
            this.Departure,
            this.ArrivalTime});
      this.ConnectionsDataGrid.Location = new System.Drawing.Point(15, 180);
      this.ConnectionsDataGrid.Name = "ConnectionsDataGrid";
      this.ConnectionsDataGrid.ReadOnly = true;
      this.ConnectionsDataGrid.Size = new System.Drawing.Size(762, 308);
      this.ConnectionsDataGrid.TabIndex = 4;
      // 
      // Train
      // 
      this.Train.HeaderText = "Zug";
      this.Train.Name = "Train";
      this.Train.ReadOnly = true;
      // 
      // Departure
      // 
      this.Departure.HeaderText = "Abfahrt Um";
      this.Departure.Name = "Departure";
      this.Departure.ReadOnly = true;
      // 
      // ArrivalTime
      // 
      this.ArrivalTime.HeaderText = "Ankunft Um";
      this.ArrivalTime.Name = "ArrivalTime";
      this.ArrivalTime.ReadOnly = true;
      // 
      // ConnectionSearchButton
      // 
      this.ConnectionSearchButton.Location = new System.Drawing.Point(15, 140);
      this.ConnectionSearchButton.Name = "ConnectionSearchButton";
      this.ConnectionSearchButton.Size = new System.Drawing.Size(762, 23);
      this.ConnectionSearchButton.TabIndex = 9;
      this.ConnectionSearchButton.Text = "Verbindungen Suchen";
      this.ConnectionSearchButton.UseVisualStyleBackColor = true;
      this.ConnectionSearchButton.Click += new System.EventHandler(this.ConnectionSearch);
      // 
      // VonStationGroup
      // 
      this.VonStationGroup.Controls.Add(this.button2);
      this.VonStationGroup.Controls.Add(this.btnCLVon);
      this.VonStationGroup.Controls.Add(this.VonStationComboBox);
      this.VonStationGroup.Location = new System.Drawing.Point(15, 13);
      this.VonStationGroup.Name = "VonStationGroup";
      this.VonStationGroup.Size = new System.Drawing.Size(278, 100);
      this.VonStationGroup.TabIndex = 13;
      this.VonStationGroup.TabStop = false;
      this.VonStationGroup.Text = "Von Station";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(20, 48);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(87, 23);
      this.button2.TabIndex = 3;
      this.button2.Text = "Show on map";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.ShowVonLocationOnMap);
      // 
      // btnCLVon
      // 
      this.btnCLVon.Location = new System.Drawing.Point(20, 19);
      this.btnCLVon.Name = "btnCLVon";
      this.btnCLVon.Size = new System.Drawing.Size(87, 23);
      this.btnCLVon.TabIndex = 1;
      this.btnCLVon.Text = "Nearest to me";
      this.btnCLVon.UseVisualStyleBackColor = true;
      this.btnCLVon.Click += new System.EventHandler(this.btnCurrentLocation_Click);
      // 
      // VonStationComboBox
      // 
      this.VonStationComboBox.FormattingEnabled = true;
      this.VonStationComboBox.Location = new System.Drawing.Point(117, 19);
      this.VonStationComboBox.MaxDropDownItems = 5;
      this.VonStationComboBox.Name = "VonStationComboBox";
      this.VonStationComboBox.Size = new System.Drawing.Size(146, 21);
      this.VonStationComboBox.TabIndex = 2;
      this.VonStationComboBox.SelectedValueChanged += new System.EventHandler(this.cmbVon_SelectedValueChanged);
      this.VonStationComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxSearch_Change);
      // 
      // BisStationGroup
      // 
      this.BisStationGroup.Controls.Add(this.button4);
      this.BisStationGroup.Controls.Add(this.btnCLBis);
      this.BisStationGroup.Controls.Add(this.BisStationComboBox);
      this.BisStationGroup.Location = new System.Drawing.Point(318, 13);
      this.BisStationGroup.Name = "BisStationGroup";
      this.BisStationGroup.Size = new System.Drawing.Size(278, 100);
      this.BisStationGroup.TabIndex = 14;
      this.BisStationGroup.TabStop = false;
      this.BisStationGroup.Text = "Bis Station";
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(22, 49);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(87, 23);
      this.button4.TabIndex = 6;
      this.button4.Text = "Show on map";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.ShowBisLocationOnMap);
      // 
      // btnCLBis
      // 
      this.btnCLBis.Location = new System.Drawing.Point(22, 20);
      this.btnCLBis.Name = "btnCLBis";
      this.btnCLBis.Size = new System.Drawing.Size(87, 23);
      this.btnCLBis.TabIndex = 4;
      this.btnCLBis.Text = "Nearest to me";
      this.btnCLBis.UseVisualStyleBackColor = true;
      this.btnCLBis.Click += new System.EventHandler(this.btnCurrentLocation_Click);
      // 
      // BisStationComboBox
      // 
      this.BisStationComboBox.FormattingEnabled = true;
      this.BisStationComboBox.Location = new System.Drawing.Point(115, 22);
      this.BisStationComboBox.Name = "BisStationComboBox";
      this.BisStationComboBox.Size = new System.Drawing.Size(146, 21);
      this.BisStationComboBox.TabIndex = 5;
      this.BisStationComboBox.SelectedValueChanged += new System.EventHandler(this.cmbVon_SelectedValueChanged);
      this.BisStationComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxSearch_Change);
      // 
      // BoardTab
      // 
      this.BoardTab.Controls.Add(this.BoardOfGroup);
      this.BoardTab.Controls.Add(this.BoardSearchButton);
      this.BoardTab.Controls.Add(this.BoardTimeGroup);
      this.BoardTab.Controls.Add(this.BoardDataGrid);
      this.BoardTab.Location = new System.Drawing.Point(4, 22);
      this.BoardTab.Name = "BoardTab";
      this.BoardTab.Padding = new System.Windows.Forms.Padding(3);
      this.BoardTab.Size = new System.Drawing.Size(796, 505);
      this.BoardTab.TabIndex = 1;
      this.BoardTab.Text = "Abfahrtstafel";
      this.BoardTab.UseVisualStyleBackColor = true;
      // 
      // BoardOfGroup
      // 
      this.BoardOfGroup.Controls.Add(this.BoardSelectComboBox);
      this.BoardOfGroup.Location = new System.Drawing.Point(35, 30);
      this.BoardOfGroup.Name = "BoardOfGroup";
      this.BoardOfGroup.Size = new System.Drawing.Size(289, 100);
      this.BoardOfGroup.TabIndex = 17;
      this.BoardOfGroup.TabStop = false;
      this.BoardOfGroup.Text = "Verbindungen von: ";
      // 
      // BoardSelectComboBox
      // 
      this.BoardSelectComboBox.FormattingEnabled = true;
      this.BoardSelectComboBox.Location = new System.Drawing.Point(14, 26);
      this.BoardSelectComboBox.Name = "BoardSelectComboBox";
      this.BoardSelectComboBox.Size = new System.Drawing.Size(160, 21);
      this.BoardSelectComboBox.TabIndex = 3;
      this.BoardSelectComboBox.SelectedValueChanged += new System.EventHandler(this.cmbVon_SelectedValueChanged);
      this.BoardSelectComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxSearch_Change);
      // 
      // BoardSearchButton
      // 
      this.BoardSearchButton.Location = new System.Drawing.Point(35, 146);
      this.BoardSearchButton.Name = "BoardSearchButton";
      this.BoardSearchButton.Size = new System.Drawing.Size(444, 23);
      this.BoardSearchButton.TabIndex = 2;
      this.BoardSearchButton.Text = "Abfahrtstafel Anzeigen";
      this.BoardSearchButton.UseVisualStyleBackColor = true;
      this.BoardSearchButton.Click += new System.EventHandler(this.btnShowBoard_Click);
      // 
      // BoardTimeGroup
      // 
      this.BoardTimeGroup.Controls.Add(this.timePickerBoard);
      this.BoardTimeGroup.Controls.Add(this.datePickerBoard);
      this.BoardTimeGroup.Location = new System.Drawing.Point(332, 30);
      this.BoardTimeGroup.Name = "BoardTimeGroup";
      this.BoardTimeGroup.Size = new System.Drawing.Size(147, 100);
      this.BoardTimeGroup.TabIndex = 16;
      this.BoardTimeGroup.TabStop = false;
      this.BoardTimeGroup.Text = "Zeiteinschränkungen";
      // 
      // timePickerBoard
      // 
      this.timePickerBoard.Format = System.Windows.Forms.DateTimePickerFormat.Time;
      this.timePickerBoard.Location = new System.Drawing.Point(25, 63);
      this.timePickerBoard.Name = "timePickerBoard";
      this.timePickerBoard.ShowUpDown = true;
      this.timePickerBoard.Size = new System.Drawing.Size(106, 20);
      this.timePickerBoard.TabIndex = 11;
      // 
      // datePickerBoard
      // 
      this.datePickerBoard.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.datePickerBoard.Location = new System.Drawing.Point(25, 26);
      this.datePickerBoard.Name = "datePickerBoard";
      this.datePickerBoard.Size = new System.Drawing.Size(106, 20);
      this.datePickerBoard.TabIndex = 12;
      // 
      // BoardDataGrid
      // 
      this.BoardDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
      this.BoardDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.BoardDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FahrzeugName,
            this.Number,
            this.To});
      this.BoardDataGrid.Location = new System.Drawing.Point(35, 190);
      this.BoardDataGrid.Name = "BoardDataGrid";
      this.BoardDataGrid.Size = new System.Drawing.Size(444, 295);
      this.BoardDataGrid.TabIndex = 3;
      // 
      // FahrzeugName
      // 
      this.FahrzeugName.HeaderText = "Name";
      this.FahrzeugName.Name = "FahrzeugName";
      // 
      // Number
      // 
      this.Number.HeaderText = "Number";
      this.Number.Name = "Number";
      // 
      // To
      // 
      this.To.HeaderText = "To";
      this.To.Name = "To";
      // 
      // OVPApp
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(828, 555);
      this.Controls.Add(this.tab);
      this.Name = "OVPApp";
      this.Text = "OVPApp";
      this.tab.ResumeLayout(false);
      this.ConnectionsTab.ResumeLayout(false);
      this.ConnectionTimeGroup.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.ConnectionsDataGrid)).EndInit();
      this.VonStationGroup.ResumeLayout(false);
      this.BisStationGroup.ResumeLayout(false);
      this.BoardTab.ResumeLayout(false);
      this.BoardOfGroup.ResumeLayout(false);
      this.BoardTimeGroup.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.BoardDataGrid)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tab;
    private System.Windows.Forms.TabPage ConnectionsTab;
    private System.Windows.Forms.TabPage BoardTab;
    private System.Windows.Forms.Button ConnectionSearchButton;
    private System.Windows.Forms.DataGridView ConnectionsDataGrid;
    private System.Windows.Forms.DataGridViewTextBoxColumn Train;
    private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
    private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
    private System.Windows.Forms.DataGridView BoardDataGrid;
    private System.Windows.Forms.Button BoardSearchButton;
    private System.Windows.Forms.DataGridViewTextBoxColumn FahrzeugName;
    private System.Windows.Forms.DataGridViewTextBoxColumn Number;
    private System.Windows.Forms.DataGridViewTextBoxColumn To;
    private System.Windows.Forms.ComboBox BisStationComboBox;
    private System.Windows.Forms.ComboBox VonStationComboBox;
    private System.Windows.Forms.DateTimePicker timePickerConnections;
    private System.Windows.Forms.DateTimePicker datePickerConnections;
    private System.Windows.Forms.GroupBox VonStationGroup;
    private System.Windows.Forms.GroupBox BisStationGroup;
    private System.Windows.Forms.GroupBox ConnectionTimeGroup;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button btnCLVon;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button btnCLBis;
    private System.Windows.Forms.GroupBox BoardOfGroup;
    private System.Windows.Forms.GroupBox BoardTimeGroup;
    private System.Windows.Forms.DateTimePicker timePickerBoard;
    private System.Windows.Forms.DateTimePicker datePickerBoard;
    private System.Windows.Forms.ComboBox BoardSelectComboBox;
  }
}

