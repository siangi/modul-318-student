namespace SwissTransport.WindowsClient
{
    partial class frmMain
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
            this.MenuMain = new System.Windows.Forms.MenuStrip();
            this.auswahlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemClear = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.btnShowConnections = new System.Windows.Forms.Button();
            this.DTPickerTime = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.DTPickerDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lVConnections = new System.Windows.Forms.ListView();
            this.clmnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnHFromPlatform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnHDeparture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnDirection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnHDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnHArrival = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnHToPlatform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlConnectionsAndBoard = new System.Windows.Forms.Panel();
            this.lblConnections = new System.Windows.Forms.Label();
            this.MenuMain.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.pnlConnectionsAndBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuMain
            // 
            this.MenuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auswahlToolStripMenuItem});
            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(698, 28);
            this.MenuMain.TabIndex = 0;
            this.MenuMain.TabStop = true;
            this.MenuMain.Text = "MenuMain";
            // 
            // auswahlToolStripMenuItem
            // 
            this.auswahlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemClear});
            this.auswahlToolStripMenuItem.Name = "auswahlToolStripMenuItem";
            this.auswahlToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.auswahlToolStripMenuItem.Text = "Auswahl";
            // 
            // mItemClear
            // 
            this.mItemClear.Name = "mItemClear";
            this.mItemClear.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.W)));
            this.mItemClear.Size = new System.Drawing.Size(273, 26);
            this.mItemClear.Text = "Auswahl leeren";
            this.mItemClear.Click += new System.EventHandler(this.mItemClear_Click);
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlOptions.Controls.Add(this.btnShowConnections);
            this.pnlOptions.Controls.Add(this.DTPickerTime);
            this.pnlOptions.Controls.Add(this.lblTime);
            this.pnlOptions.Controls.Add(this.DTPickerDate);
            this.pnlOptions.Controls.Add(this.lblDate);
            this.pnlOptions.Controls.Add(this.cmbTo);
            this.pnlOptions.Controls.Add(this.cmbFrom);
            this.pnlOptions.Controls.Add(this.lblTo);
            this.pnlOptions.Controls.Add(this.lblFrom);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOptions.Location = new System.Drawing.Point(0, 28);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(698, 152);
            this.pnlOptions.TabIndex = 0;
            // 
            // btnShowConnections
            // 
            this.btnShowConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowConnections.Location = new System.Drawing.Point(602, 107);
            this.btnShowConnections.Name = "btnShowConnections";
            this.btnShowConnections.Size = new System.Drawing.Size(84, 28);
            this.btnShowConnections.TabIndex = 4;
            this.btnShowConnections.Text = "Anzeigen";
            this.btnShowConnections.UseVisualStyleBackColor = true;
            this.btnShowConnections.Click += new System.EventHandler(this.btnShowConnections_Click);
            // 
            // DTPickerTime
            // 
            this.DTPickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTPickerTime.Location = new System.Drawing.Point(260, 78);
            this.DTPickerTime.Name = "DTPickerTime";
            this.DTPickerTime.ShowUpDown = true;
            this.DTPickerTime.Size = new System.Drawing.Size(108, 22);
            this.DTPickerTime.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(201, 78);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 17);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Uhrzeit";
            // 
            // DTPickerDate
            // 
            this.DTPickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPickerDate.Location = new System.Drawing.Point(71, 78);
            this.DTPickerDate.Name = "DTPickerDate";
            this.DTPickerDate.Size = new System.Drawing.Size(108, 22);
            this.DTPickerDate.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 78);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 17);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Datum:";
            // 
            // cmbTo
            // 
            this.cmbTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Items.AddRange(new object[] {
            "Alle Richtungen"});
            this.cmbTo.Location = new System.Drawing.Point(449, 9);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(238, 24);
            this.cmbTo.TabIndex = 1;
            this.cmbTo.DropDown += new System.EventHandler(this.cmbTo_DropDown);
            this.cmbTo.SelectedIndexChanged += new System.EventHandler(this.cmbTo_TextUpdate);
            this.cmbTo.TextUpdate += new System.EventHandler(this.cmbTo_TextUpdate);
            // 
            // cmbFrom
            // 
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Location = new System.Drawing.Point(98, 9);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(238, 24);
            this.cmbFrom.TabIndex = 0;
            this.cmbFrom.DropDown += new System.EventHandler(this.cmbFrom_DropDown);
            // 
            // lblTo
            // 
            this.lblTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(364, 12);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(79, 17);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "Endstation:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(12, 12);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(84, 17);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "Startstation:";
            // 
            // lVConnections
            // 
            this.lVConnections.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lVConnections.AutoArrange = false;
            this.lVConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnName,
            this.clmnHFromPlatform,
            this.clmnHDeparture,
            this.clmnDirection,
            this.clmnHDuration,
            this.clmnHArrival,
            this.clmnHToPlatform});
            this.lVConnections.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lVConnections.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVConnections.FullRowSelect = true;
            this.lVConnections.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lVConnections.Location = new System.Drawing.Point(0, 44);
            this.lVConnections.Name = "lVConnections";
            this.lVConnections.Size = new System.Drawing.Size(698, 261);
            this.lVConnections.TabIndex = 1;
            this.lVConnections.TabStop = false;
            this.lVConnections.UseCompatibleStateImageBehavior = false;
            this.lVConnections.View = System.Windows.Forms.View.Details;
            // 
            // clmnName
            // 
            this.clmnName.Text = "Name";
            this.clmnName.Width = 0;
            // 
            // clmnHFromPlatform
            // 
            this.clmnHFromPlatform.Text = "Gleis";
            this.clmnHFromPlatform.Width = 100;
            // 
            // clmnHDeparture
            // 
            this.clmnHDeparture.Text = "Abfahrt";
            this.clmnHDeparture.Width = 109;
            // 
            // clmnDirection
            // 
            this.clmnDirection.Text = "Richtung";
            this.clmnDirection.Width = 0;
            // 
            // clmnHDuration
            // 
            this.clmnHDuration.Text = "Dauer";
            this.clmnHDuration.Width = 132;
            // 
            // clmnHArrival
            // 
            this.clmnHArrival.Text = "Ankunft";
            this.clmnHArrival.Width = 145;
            // 
            // clmnHToPlatform
            // 
            this.clmnHToPlatform.Text = "Gleis";
            this.clmnHToPlatform.Width = 100;
            // 
            // pnlConnectionsAndBoard
            // 
            this.pnlConnectionsAndBoard.Controls.Add(this.lblConnections);
            this.pnlConnectionsAndBoard.Controls.Add(this.lVConnections);
            this.pnlConnectionsAndBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConnectionsAndBoard.Location = new System.Drawing.Point(0, 180);
            this.pnlConnectionsAndBoard.Name = "pnlConnectionsAndBoard";
            this.pnlConnectionsAndBoard.Size = new System.Drawing.Size(698, 305);
            this.pnlConnectionsAndBoard.TabIndex = 4;
            // 
            // lblConnections
            // 
            this.lblConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblConnections.AutoSize = true;
            this.lblConnections.Location = new System.Drawing.Point(3, 24);
            this.lblConnections.Name = "lblConnections";
            this.lblConnections.Size = new System.Drawing.Size(97, 17);
            this.lblConnections.TabIndex = 2;
            this.lblConnections.Text = "Verbindungen";
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnShowConnections;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(698, 485);
            this.Controls.Add(this.pnlConnectionsAndBoard);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.MenuMain);
            this.MainMenuStrip = this.MenuMain;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Fahrplan Applikation";
            this.MenuMain.ResumeLayout(false);
            this.MenuMain.PerformLayout();
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            this.pnlConnectionsAndBoard.ResumeLayout(false);
            this.pnlConnectionsAndBoard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuMain;
        private System.Windows.Forms.ToolStripMenuItem auswahlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mItemClear;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker DTPickerDate;
        private System.Windows.Forms.DateTimePicker DTPickerTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnShowConnections;
        private System.Windows.Forms.ListView lVConnections;
        private System.Windows.Forms.ColumnHeader clmnHFromPlatform;
        private System.Windows.Forms.ColumnHeader clmnHDeparture;
        private System.Windows.Forms.ColumnHeader clmnHDuration;
        private System.Windows.Forms.ColumnHeader clmnHArrival;
        private System.Windows.Forms.ColumnHeader clmnHToPlatform;
        private System.Windows.Forms.Panel pnlConnectionsAndBoard;
        private System.Windows.Forms.ColumnHeader clmnName;
        private System.Windows.Forms.ColumnHeader clmnDirection;
        private System.Windows.Forms.Label lblConnections;
    }
}

