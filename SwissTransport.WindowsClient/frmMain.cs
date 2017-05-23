using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransport.WindowsClient
{ 
    public partial class frmMain : Form, ITransportView
    {
        public frmMain()
        {
            InitializeComponent();
            DTPickerDate.MinDate = System.DateTime.Today;
            DTPickerTime.MinDate = System.DateTime.Now;
        }
        
        /// <summary>
        /// Adds a new Row to lVConnections, for further documentation see ITransportView
        /// </summary>
        public void AddNewConnection(string from, string to, string Departure, string Arrival, string toPlatform, 
            string fromPlatform, string Duration)
        {
            if (isStationboard())
                lblConnections.Text = "Abfahrtsplan für Station: " + cmbFrom.Text;
            else
            {
                lblConnections.Text = "Verbindungen von " + from + " nach: " + to + " ab: "
                    + DTPickerDate.Text + " " + DTPickerTime.Text;
            }

            ListViewItem Item = new ListViewItem(from);
            Item.SubItems.Add(fromPlatform);
            Item.SubItems.Add(Departure);
            Item.SubItems.Add(to);
            Item.SubItems.Add(Duration);
            Item.SubItems.Add(Arrival);
            Item.SubItems.Add(toPlatform);

            lVConnections.Items.Add(Item);
        }

        public string GetFromStation()
        {
            return cmbFrom.Text;
        }

        public string GetToStation()
        {
            return cmbTo.Text;
        }

        public void SetFromStation(string Value)
        {
            throw new NotImplementedException();
        }

        public void SetOnShowConnections(EventHandler Event)
        {
            btnShowConnections.Click += Event;
        }

        public void SetOnGetSuggestions(EventHandler FromEvent, EventHandler ToEvent)
        {
            cmbFrom.DropDown += FromEvent;
            cmbTo.DropDown += ToEvent;
        }

        /// <summary>
        /// Clears the Items of the combobox for the stations and fills in the 
        /// new suggestions
        /// </summary>
        /// <param name="value">the strings which will be added to the combobox</param>
        /// <param name="StationKind">Which combobox will be filled</param>
        public void SetPossibleStations(List<string> value, StationKinds StationKind)
        {
            if (StationKind == StationKinds.From)
            {
                cmbFrom.Items.Clear();
                cmbFrom.Items.AddRange(value.ToArray());
            }
            else
            {
                cmbTo.Items.Clear();
                cmbTo.Items.AddRange(value.ToArray());
            }
        }

        public void SetToStation(string value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Executed before the GetConnectionsHandler method
        /// </summary>
        private void btnShowConnections_Click(object sender, EventArgs e)
        {
            if (cmbTo.Text == "" || cmbFrom.Text == "")
            {
                MessageBox.Show("Sie müssen eine Start- und eine Endstation auswählen!\r\n" +
                    "\r\n (Für einen Abfahrtsplan einer Station wählen sie 'Alle Richtungen' als Ziel");
                cmbFrom.Focus();
                ///TODO: Event abbrechen?
                return;
            }

            lVConnections.Items.Clear();
            if (isStationboard())
                PrepareForStationBoard();
            else
                PrepareForConnections();
        }

        /// <summary>
        /// Executed before the StationQuery method 
        /// </summary>
        private void cmbFrom_DropDown(object sender, EventArgs e)
        {
            cmbFrom.Items.Clear();
        }

        /// <summary>
        /// Executed before the StationQuery method 
        /// </summary>
        private void cmbTo_DropDown(object sender, EventArgs e)
        {
            cmbTo.Items.Clear();
        }

        /// <summary>
        /// Changes the Columns of lVConnection to Show
        /// the Configuration for the Stationboard
        /// </summary>
        public void PrepareForStationBoard()
        {
            clmnName.Width = 160;
            clmnDirection.Width = 160;
            clmnHArrival.Width = 0;
            clmnHDuration.Width = 0;
            clmnHToPlatform.Width = 0;
            clmnHFromPlatform.Width = 0;
        }

        /// <summary>
        /// Changes the Columns of lVConnections to Show
        /// the Configuration for normal Connections (A to B)
        /// </summary>
        public void PrepareForConnections()
        {
            clmnName.Width = 0;
            clmnDirection.Width = 0;
            clmnHArrival.Width = 150;
            clmnHDuration.Width = 130;
            clmnHToPlatform.Width = 100;
            clmnHFromPlatform.Width = 100;
        }

        public string GetDate()
        {
            return DTPickerDate.Text;
        }

        public string GetTime()
        {
            return DTPickerTime.Text;
        }

        private void mItemClear_Click(object sender, EventArgs e)
        {
            lVConnections.Items.Clear();
            cmbFrom.Items.Clear();
            cmbTo.Items.Clear();
            cmbFrom.Text = "";
            cmbTo.Text = "";
            DTPickerDate.Value = System.DateTime.Today;
            DTPickerTime.Value = System.DateTime.Now;
        }

        private void cmbTo_TextUpdate(object sender, EventArgs e)
        {
            if (isStationboard())
            {
                DTPickerTime.Enabled = false;
                DTPickerDate.Enabled = false;
            }
            else
            {
                DTPickerTime.Enabled = true;
                DTPickerDate.Enabled = true;
            }
        }

        private bool isStationboard()
        {
            return cmbTo.Text == "Alle Richtungen";
        }
    }
}
