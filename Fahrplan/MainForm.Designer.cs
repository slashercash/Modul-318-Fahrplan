namespace Fahrplan
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tlpHeadButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnVerbindung = new System.Windows.Forms.Button();
            this.btnStrecke = new System.Windows.Forms.Button();
            this.btnFahrplan = new System.Windows.Forms.Button();
            this.pnlStrecke = new System.Windows.Forms.Panel();
            this.btnChangeDirection = new System.Windows.Forms.Button();
            this.tlpZeit = new System.Windows.Forms.TableLayoutPanel();
            this.btnAnkunftsZeit = new System.Windows.Forms.Button();
            this.lbZeit = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAbfahrtsZeit = new System.Windows.Forms.Button();
            this.btnFahrplanAnzeigen = new System.Windows.Forms.Button();
            this.tlpNach = new System.Windows.Forms.TableLayoutPanel();
            this.tbxNach = new System.Windows.Forms.TextBox();
            this.btnNachStandortAnzeigen = new System.Windows.Forms.Button();
            this.btnNachDurchsuchen = new System.Windows.Forms.Button();
            this.lbNach = new System.Windows.Forms.Label();
            this.tlpVon = new System.Windows.Forms.TableLayoutPanel();
            this.btnVonDurchsuchen = new System.Windows.Forms.Button();
            this.tbxVon = new System.Windows.Forms.TextBox();
            this.btnVonStandortAnzeigen = new System.Windows.Forms.Button();
            this.lbVon = new System.Windows.Forms.Label();
            this.pnlFahrplan = new System.Windows.Forms.Panel();
            this.btnStreckeEingeben = new System.Windows.Forms.Button();
            this.tlpTimeTable = new System.Windows.Forms.TableLayoutPanel();
            this.lb6A = new System.Windows.Forms.Label();
            this.lb6D = new System.Windows.Forms.Label();
            this.lb6C = new System.Windows.Forms.Label();
            this.lb6B = new System.Windows.Forms.Label();
            this.lb1A = new System.Windows.Forms.Label();
            this.lb1B = new System.Windows.Forms.Label();
            this.lb1C = new System.Windows.Forms.Label();
            this.lb1D = new System.Windows.Forms.Label();
            this.lb2A = new System.Windows.Forms.Label();
            this.lb2B = new System.Windows.Forms.Label();
            this.lb2C = new System.Windows.Forms.Label();
            this.lb2D = new System.Windows.Forms.Label();
            this.lb3A = new System.Windows.Forms.Label();
            this.lb3B = new System.Windows.Forms.Label();
            this.lb3C = new System.Windows.Forms.Label();
            this.lb3D = new System.Windows.Forms.Label();
            this.lb4D = new System.Windows.Forms.Label();
            this.lb4C = new System.Windows.Forms.Label();
            this.lb4B = new System.Windows.Forms.Label();
            this.lb4A = new System.Windows.Forms.Label();
            this.lb5D = new System.Windows.Forms.Label();
            this.lb5C = new System.Windows.Forms.Label();
            this.lb5B = new System.Windows.Forms.Label();
            this.lb5A = new System.Windows.Forms.Label();
            this.tlpTimeTableHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lbDauer = new System.Windows.Forms.Label();
            this.lbAnkunft = new System.Windows.Forms.Label();
            this.lbAbfahrt = new System.Windows.Forms.Label();
            this.lbGleisKante = new System.Windows.Forms.Label();
            this.lbVonNach = new System.Windows.Forms.Label();
            this.pnlVerbindungen = new System.Windows.Forms.Panel();
            this.tlpConnectionsTable = new System.Windows.Forms.TableLayoutPanel();
            this.tlpConnectionsHeader = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVerbindungenAnzeigen = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAbDurchsuchen = new System.Windows.Forms.Button();
            this.btnAbStandortAnzeigen = new System.Windows.Forms.Button();
            this.tbxAb = new System.Windows.Forms.TextBox();
            this.lbVerbindungenAb = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlNoInternet = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnErneutVersuchen = new System.Windows.Forms.Button();
            this.tlpNoInternet = new System.Windows.Forms.TableLayoutPanel();
            this.pnlNoInternetIcon = new System.Windows.Forms.Panel();
            this.tlpHeadButtons.SuspendLayout();
            this.pnlStrecke.SuspendLayout();
            this.tlpZeit.SuspendLayout();
            this.tlpNach.SuspendLayout();
            this.tlpVon.SuspendLayout();
            this.pnlFahrplan.SuspendLayout();
            this.tlpTimeTable.SuspendLayout();
            this.tlpTimeTableHeader.SuspendLayout();
            this.pnlVerbindungen.SuspendLayout();
            this.tlpConnectionsHeader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlNoInternet.SuspendLayout();
            this.tlpNoInternet.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpHeadButtons
            // 
            this.tlpHeadButtons.ColumnCount = 3;
            this.tlpHeadButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpHeadButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpHeadButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpHeadButtons.Controls.Add(this.btnVerbindung, 2, 0);
            this.tlpHeadButtons.Controls.Add(this.btnStrecke, 0, 0);
            this.tlpHeadButtons.Controls.Add(this.btnFahrplan, 1, 0);
            this.tlpHeadButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpHeadButtons.Location = new System.Drawing.Point(0, 0);
            this.tlpHeadButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpHeadButtons.Name = "tlpHeadButtons";
            this.tlpHeadButtons.RowCount = 1;
            this.tlpHeadButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeadButtons.Size = new System.Drawing.Size(784, 62);
            this.tlpHeadButtons.TabIndex = 0;
            // 
            // btnVerbindung
            // 
            this.btnVerbindung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerbindung.BackColor = System.Drawing.Color.LightGreen;
            this.btnVerbindung.FlatAppearance.BorderSize = 0;
            this.btnVerbindung.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVerbindung.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVerbindung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerbindung.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerbindung.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnVerbindung.Location = new System.Drawing.Point(522, 0);
            this.btnVerbindung.Margin = new System.Windows.Forms.Padding(0);
            this.btnVerbindung.Name = "btnVerbindung";
            this.btnVerbindung.Size = new System.Drawing.Size(262, 62);
            this.btnVerbindung.TabIndex = 2;
            this.btnVerbindung.Text = "Verbindungen";
            this.btnVerbindung.UseVisualStyleBackColor = false;
            this.btnVerbindung.Click += new System.EventHandler(this.BtnVerbindung_Click);
            // 
            // btnStrecke
            // 
            this.btnStrecke.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStrecke.BackColor = System.Drawing.Color.LightGreen;
            this.btnStrecke.FlatAppearance.BorderSize = 0;
            this.btnStrecke.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStrecke.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStrecke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStrecke.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStrecke.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnStrecke.Location = new System.Drawing.Point(0, 0);
            this.btnStrecke.Margin = new System.Windows.Forms.Padding(0);
            this.btnStrecke.Name = "btnStrecke";
            this.btnStrecke.Size = new System.Drawing.Size(261, 62);
            this.btnStrecke.TabIndex = 0;
            this.btnStrecke.Text = "Strecke";
            this.btnStrecke.UseVisualStyleBackColor = false;
            this.btnStrecke.Click += new System.EventHandler(this.BtnStrecke_Click);
            // 
            // btnFahrplan
            // 
            this.btnFahrplan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFahrplan.BackColor = System.Drawing.Color.LightGreen;
            this.btnFahrplan.FlatAppearance.BorderSize = 0;
            this.btnFahrplan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFahrplan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFahrplan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFahrplan.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFahrplan.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnFahrplan.Location = new System.Drawing.Point(261, 0);
            this.btnFahrplan.Margin = new System.Windows.Forms.Padding(0);
            this.btnFahrplan.Name = "btnFahrplan";
            this.btnFahrplan.Size = new System.Drawing.Size(261, 62);
            this.btnFahrplan.TabIndex = 1;
            this.btnFahrplan.Text = "Fahrplan";
            this.btnFahrplan.UseVisualStyleBackColor = false;
            this.btnFahrplan.Click += new System.EventHandler(this.BtnFahrplan_Click);
            // 
            // pnlStrecke
            // 
            this.pnlStrecke.BackColor = System.Drawing.Color.Honeydew;
            this.pnlStrecke.Controls.Add(this.btnChangeDirection);
            this.pnlStrecke.Controls.Add(this.tlpZeit);
            this.pnlStrecke.Controls.Add(this.btnFahrplanAnzeigen);
            this.pnlStrecke.Controls.Add(this.tlpNach);
            this.pnlStrecke.Controls.Add(this.tlpVon);
            this.pnlStrecke.Location = new System.Drawing.Point(0, 62);
            this.pnlStrecke.Margin = new System.Windows.Forms.Padding(0);
            this.pnlStrecke.Name = "pnlStrecke";
            this.pnlStrecke.Size = new System.Drawing.Size(544, 356);
            this.pnlStrecke.TabIndex = 1;
            // 
            // btnChangeDirection
            // 
            this.btnChangeDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeDirection.BackColor = System.Drawing.Color.LightGreen;
            this.btnChangeDirection.BackgroundImage = global::Fahrplan.Properties.Resources.ChangeDirection;
            this.btnChangeDirection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChangeDirection.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnChangeDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeDirection.Location = new System.Drawing.Point(454, 71);
            this.btnChangeDirection.Margin = new System.Windows.Forms.Padding(0);
            this.btnChangeDirection.Name = "btnChangeDirection";
            this.btnChangeDirection.Size = new System.Drawing.Size(33, 32);
            this.btnChangeDirection.TabIndex = 0;
            this.btnChangeDirection.TabStop = false;
            this.toolTip.SetToolTip(this.btnChangeDirection, "andere Richtung");
            this.btnChangeDirection.UseVisualStyleBackColor = false;
            this.btnChangeDirection.Click += new System.EventHandler(this.BtnChangeDirection_Click);
            // 
            // tlpZeit
            // 
            this.tlpZeit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpZeit.ColumnCount = 5;
            this.tlpZeit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tlpZeit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpZeit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpZeit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpZeit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpZeit.Controls.Add(this.btnAnkunftsZeit, 4, 0);
            this.tlpZeit.Controls.Add(this.lbZeit, 0, 0);
            this.tlpZeit.Controls.Add(this.datePicker, 1, 0);
            this.tlpZeit.Controls.Add(this.timePicker, 2, 0);
            this.tlpZeit.Controls.Add(this.btnAbfahrtsZeit, 3, 0);
            this.tlpZeit.Location = new System.Drawing.Point(33, 183);
            this.tlpZeit.Margin = new System.Windows.Forms.Padding(3, 32, 3, 3);
            this.tlpZeit.Name = "tlpZeit";
            this.tlpZeit.RowCount = 1;
            this.tlpZeit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpZeit.Size = new System.Drawing.Size(471, 34);
            this.tlpZeit.TabIndex = 6;
            // 
            // btnAnkunftsZeit
            // 
            this.btnAnkunftsZeit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnkunftsZeit.BackColor = System.Drawing.Color.LightGreen;
            this.btnAnkunftsZeit.BackgroundImage = global::Fahrplan.Properties.Resources.An;
            this.btnAnkunftsZeit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnkunftsZeit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnkunftsZeit.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnAnkunftsZeit.FlatAppearance.BorderSize = 2;
            this.btnAnkunftsZeit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnkunftsZeit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnkunftsZeit.Location = new System.Drawing.Point(434, 0);
            this.btnAnkunftsZeit.Margin = new System.Windows.Forms.Padding(0);
            this.btnAnkunftsZeit.Name = "btnAnkunftsZeit";
            this.btnAnkunftsZeit.Size = new System.Drawing.Size(37, 34);
            this.btnAnkunftsZeit.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnAnkunftsZeit, "Selekierte Zeit ist Ankunftszeit");
            this.btnAnkunftsZeit.UseVisualStyleBackColor = false;
            this.btnAnkunftsZeit.Click += new System.EventHandler(this.BtnAnkunftsZeit_Click);
            // 
            // lbZeit
            // 
            this.lbZeit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbZeit.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbZeit.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbZeit.Location = new System.Drawing.Point(0, 0);
            this.lbZeit.Margin = new System.Windows.Forms.Padding(0);
            this.lbZeit.Name = "lbZeit";
            this.lbZeit.Size = new System.Drawing.Size(67, 34);
            this.lbZeit.TabIndex = 6;
            this.lbZeit.Text = "Zeit";
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datePicker.Font = new System.Drawing.Font("Calibri", 16F);
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(67, 0);
            this.datePicker.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(230, 34);
            this.datePicker.TabIndex = 2;
            this.datePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // timePicker
            // 
            this.timePicker.CalendarFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timePicker.Font = new System.Drawing.Font("Calibri", 16F);
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(303, 0);
            this.timePicker.Margin = new System.Windows.Forms.Padding(3, 0, 6, 0);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(91, 34);
            this.timePicker.TabIndex = 1;
            this.timePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // btnAbfahrtsZeit
            // 
            this.btnAbfahrtsZeit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAbfahrtsZeit.BackColor = System.Drawing.Color.LightGreen;
            this.btnAbfahrtsZeit.BackgroundImage = global::Fahrplan.Properties.Resources.Ab;
            this.btnAbfahrtsZeit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbfahrtsZeit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAbfahrtsZeit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAbfahrtsZeit.FlatAppearance.BorderSize = 2;
            this.btnAbfahrtsZeit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbfahrtsZeit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbfahrtsZeit.Location = new System.Drawing.Point(400, 0);
            this.btnAbfahrtsZeit.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbfahrtsZeit.Name = "btnAbfahrtsZeit";
            this.btnAbfahrtsZeit.Size = new System.Drawing.Size(34, 34);
            this.btnAbfahrtsZeit.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnAbfahrtsZeit, "Selekierte Zeit ist Abfahrtszeit");
            this.btnAbfahrtsZeit.UseVisualStyleBackColor = false;
            this.btnAbfahrtsZeit.Click += new System.EventHandler(this.BtnAbfahrtsZeit_Click);
            // 
            // btnFahrplanAnzeigen
            // 
            this.btnFahrplanAnzeigen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFahrplanAnzeigen.BackColor = System.Drawing.Color.LightGreen;
            this.btnFahrplanAnzeigen.FlatAppearance.BorderSize = 0;
            this.btnFahrplanAnzeigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFahrplanAnzeigen.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFahrplanAnzeigen.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnFahrplanAnzeigen.Location = new System.Drawing.Point(33, 257);
            this.btnFahrplanAnzeigen.Margin = new System.Windows.Forms.Padding(40, 32, 40, 0);
            this.btnFahrplanAnzeigen.Name = "btnFahrplanAnzeigen";
            this.btnFahrplanAnzeigen.Size = new System.Drawing.Size(471, 58);
            this.btnFahrplanAnzeigen.TabIndex = 3;
            this.btnFahrplanAnzeigen.Text = "Fahrplan anzeigen";
            this.btnFahrplanAnzeigen.UseVisualStyleBackColor = false;
            this.btnFahrplanAnzeigen.Click += new System.EventHandler(this.BtnFahrplanAnzeigen_Click);
            // 
            // tlpNach
            // 
            this.tlpNach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpNach.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpNach.ColumnCount = 4;
            this.tlpNach.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tlpNach.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNach.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpNach.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpNach.Controls.Add(this.tbxNach, 1, 0);
            this.tlpNach.Controls.Add(this.btnNachStandortAnzeigen, 3, 0);
            this.tlpNach.Controls.Add(this.btnNachDurchsuchen, 2, 0);
            this.tlpNach.Controls.Add(this.lbNach, 0, 0);
            this.tlpNach.Location = new System.Drawing.Point(33, 108);
            this.tlpNach.Margin = new System.Windows.Forms.Padding(33, 5, 40, 0);
            this.tlpNach.Name = "tlpNach";
            this.tlpNach.RowCount = 1;
            this.tlpNach.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpNach.Size = new System.Drawing.Size(471, 34);
            this.tlpNach.TabIndex = 2;
            // 
            // tbxNach
            // 
            this.tbxNach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxNach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxNach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxNach.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNach.Location = new System.Drawing.Point(67, 0);
            this.tbxNach.Margin = new System.Windows.Forms.Padding(0);
            this.tbxNach.Name = "tbxNach";
            this.tbxNach.Size = new System.Drawing.Size(338, 34);
            this.tbxNach.TabIndex = 1;
            this.tbxNach.TextChanged += new System.EventHandler(this.TbxNach_TextChanged);
            this.tbxNach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxVonNachAb_KeyDown);
            // 
            // btnNachStandortAnzeigen
            // 
            this.btnNachStandortAnzeigen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNachStandortAnzeigen.BackColor = System.Drawing.Color.LightGray;
            this.btnNachStandortAnzeigen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNachStandortAnzeigen.BackgroundImage")));
            this.btnNachStandortAnzeigen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNachStandortAnzeigen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNachStandortAnzeigen.Enabled = false;
            this.btnNachStandortAnzeigen.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnNachStandortAnzeigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNachStandortAnzeigen.Location = new System.Drawing.Point(438, 0);
            this.btnNachStandortAnzeigen.Margin = new System.Windows.Forms.Padding(0);
            this.btnNachStandortAnzeigen.Name = "btnNachStandortAnzeigen";
            this.btnNachStandortAnzeigen.Size = new System.Drawing.Size(33, 34);
            this.btnNachStandortAnzeigen.TabIndex = 2;
            this.btnNachStandortAnzeigen.TabStop = false;
            this.toolTip.SetToolTip(this.btnNachStandortAnzeigen, "Standort im Browser anzeigen");
            this.btnNachStandortAnzeigen.UseVisualStyleBackColor = false;
            this.btnNachStandortAnzeigen.Click += new System.EventHandler(this.BtnNachStandortAnzeigen_Click);
            // 
            // btnNachDurchsuchen
            // 
            this.btnNachDurchsuchen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNachDurchsuchen.BackColor = System.Drawing.Color.LightGray;
            this.btnNachDurchsuchen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNachDurchsuchen.BackgroundImage")));
            this.btnNachDurchsuchen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNachDurchsuchen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNachDurchsuchen.Enabled = false;
            this.btnNachDurchsuchen.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnNachDurchsuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNachDurchsuchen.Location = new System.Drawing.Point(405, 0);
            this.btnNachDurchsuchen.Margin = new System.Windows.Forms.Padding(0);
            this.btnNachDurchsuchen.Name = "btnNachDurchsuchen";
            this.btnNachDurchsuchen.Size = new System.Drawing.Size(33, 34);
            this.btnNachDurchsuchen.TabIndex = 1;
            this.btnNachDurchsuchen.TabStop = false;
            this.toolTip.SetToolTip(this.btnNachDurchsuchen, "nach Stationen suchen [Enter]");
            this.btnNachDurchsuchen.UseVisualStyleBackColor = false;
            this.btnNachDurchsuchen.Click += new System.EventHandler(this.BtnNachDurchsuchen_Click);
            // 
            // lbNach
            // 
            this.lbNach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNach.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNach.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbNach.Location = new System.Drawing.Point(0, 0);
            this.lbNach.Margin = new System.Windows.Forms.Padding(0);
            this.lbNach.Name = "lbNach";
            this.lbNach.Size = new System.Drawing.Size(67, 34);
            this.lbNach.TabIndex = 1;
            this.lbNach.Text = "Nach";
            // 
            // tlpVon
            // 
            this.tlpVon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpVon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpVon.ColumnCount = 4;
            this.tlpVon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tlpVon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpVon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpVon.Controls.Add(this.btnVonDurchsuchen, 2, 0);
            this.tlpVon.Controls.Add(this.tbxVon, 1, 0);
            this.tlpVon.Controls.Add(this.btnVonStandortAnzeigen, 3, 0);
            this.tlpVon.Controls.Add(this.lbVon, 0, 0);
            this.tlpVon.Location = new System.Drawing.Point(33, 32);
            this.tlpVon.Margin = new System.Windows.Forms.Padding(33, 32, 40, 0);
            this.tlpVon.Name = "tlpVon";
            this.tlpVon.RowCount = 1;
            this.tlpVon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpVon.Size = new System.Drawing.Size(471, 34);
            this.tlpVon.TabIndex = 1;
            // 
            // btnVonDurchsuchen
            // 
            this.btnVonDurchsuchen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVonDurchsuchen.BackColor = System.Drawing.Color.LightGray;
            this.btnVonDurchsuchen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVonDurchsuchen.BackgroundImage")));
            this.btnVonDurchsuchen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVonDurchsuchen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVonDurchsuchen.Enabled = false;
            this.btnVonDurchsuchen.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnVonDurchsuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVonDurchsuchen.Location = new System.Drawing.Point(405, 0);
            this.btnVonDurchsuchen.Margin = new System.Windows.Forms.Padding(0);
            this.btnVonDurchsuchen.Name = "btnVonDurchsuchen";
            this.btnVonDurchsuchen.Size = new System.Drawing.Size(33, 34);
            this.btnVonDurchsuchen.TabIndex = 2;
            this.btnVonDurchsuchen.TabStop = false;
            this.toolTip.SetToolTip(this.btnVonDurchsuchen, "nach Stationen suchen [Enter]");
            this.btnVonDurchsuchen.UseVisualStyleBackColor = false;
            this.btnVonDurchsuchen.Click += new System.EventHandler(this.BtnVonDurchsuchen_Click);
            // 
            // tbxVon
            // 
            this.tbxVon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxVon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxVon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxVon.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxVon.Location = new System.Drawing.Point(67, 0);
            this.tbxVon.Margin = new System.Windows.Forms.Padding(0);
            this.tbxVon.Name = "tbxVon";
            this.tbxVon.Size = new System.Drawing.Size(338, 34);
            this.tbxVon.TabIndex = 0;
            this.tbxVon.TextChanged += new System.EventHandler(this.TbxVon_TextChanged);
            this.tbxVon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxVonNachAb_KeyDown);
            // 
            // btnVonStandortAnzeigen
            // 
            this.btnVonStandortAnzeigen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVonStandortAnzeigen.BackColor = System.Drawing.Color.LightGray;
            this.btnVonStandortAnzeigen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVonStandortAnzeigen.BackgroundImage")));
            this.btnVonStandortAnzeigen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVonStandortAnzeigen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVonStandortAnzeigen.Enabled = false;
            this.btnVonStandortAnzeigen.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnVonStandortAnzeigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVonStandortAnzeigen.Location = new System.Drawing.Point(438, 0);
            this.btnVonStandortAnzeigen.Margin = new System.Windows.Forms.Padding(0);
            this.btnVonStandortAnzeigen.Name = "btnVonStandortAnzeigen";
            this.btnVonStandortAnzeigen.Size = new System.Drawing.Size(33, 34);
            this.btnVonStandortAnzeigen.TabIndex = 1;
            this.btnVonStandortAnzeigen.TabStop = false;
            this.toolTip.SetToolTip(this.btnVonStandortAnzeigen, "Standort im Browser anzeigen");
            this.btnVonStandortAnzeigen.UseVisualStyleBackColor = false;
            this.btnVonStandortAnzeigen.Click += new System.EventHandler(this.BtnVonStandortAnzeigen_Click);
            // 
            // lbVon
            // 
            this.lbVon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbVon.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVon.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbVon.Location = new System.Drawing.Point(0, 0);
            this.lbVon.Margin = new System.Windows.Forms.Padding(0);
            this.lbVon.Name = "lbVon";
            this.lbVon.Size = new System.Drawing.Size(67, 34);
            this.lbVon.TabIndex = 1;
            this.lbVon.Text = "Von";
            // 
            // pnlFahrplan
            // 
            this.pnlFahrplan.BackColor = System.Drawing.Color.Honeydew;
            this.pnlFahrplan.Controls.Add(this.btnStreckeEingeben);
            this.pnlFahrplan.Controls.Add(this.tlpTimeTable);
            this.pnlFahrplan.Controls.Add(this.tlpTimeTableHeader);
            this.pnlFahrplan.Controls.Add(this.lbVonNach);
            this.pnlFahrplan.Location = new System.Drawing.Point(0, 418);
            this.pnlFahrplan.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFahrplan.Name = "pnlFahrplan";
            this.pnlFahrplan.Size = new System.Drawing.Size(544, 382);
            this.pnlFahrplan.TabIndex = 3;
            // 
            // btnStreckeEingeben
            // 
            this.btnStreckeEingeben.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStreckeEingeben.BackColor = System.Drawing.Color.LightGreen;
            this.btnStreckeEingeben.FlatAppearance.BorderSize = 0;
            this.btnStreckeEingeben.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStreckeEingeben.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStreckeEingeben.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnStreckeEingeben.Location = new System.Drawing.Point(40, 145);
            this.btnStreckeEingeben.Margin = new System.Windows.Forms.Padding(40, 39, 40, 0);
            this.btnStreckeEingeben.Name = "btnStreckeEingeben";
            this.btnStreckeEingeben.Size = new System.Drawing.Size(462, 58);
            this.btnStreckeEingeben.TabIndex = 1;
            this.btnStreckeEingeben.Text = "Strecke eingeben";
            this.btnStreckeEingeben.UseVisualStyleBackColor = false;
            this.btnStreckeEingeben.Click += new System.EventHandler(this.BtnStrecke_Click);
            // 
            // tlpTimeTable
            // 
            this.tlpTimeTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTimeTable.ColumnCount = 4;
            this.tlpTimeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tlpTimeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTimeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tlpTimeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tlpTimeTable.Controls.Add(this.lb6A, 0, 5);
            this.tlpTimeTable.Controls.Add(this.lb6D, 0, 5);
            this.tlpTimeTable.Controls.Add(this.lb6C, 0, 5);
            this.tlpTimeTable.Controls.Add(this.lb6B, 0, 5);
            this.tlpTimeTable.Controls.Add(this.lb1A, 0, 0);
            this.tlpTimeTable.Controls.Add(this.lb1B, 1, 0);
            this.tlpTimeTable.Controls.Add(this.lb1C, 2, 0);
            this.tlpTimeTable.Controls.Add(this.lb1D, 3, 0);
            this.tlpTimeTable.Controls.Add(this.lb2A, 0, 1);
            this.tlpTimeTable.Controls.Add(this.lb2B, 1, 1);
            this.tlpTimeTable.Controls.Add(this.lb2C, 2, 1);
            this.tlpTimeTable.Controls.Add(this.lb2D, 3, 1);
            this.tlpTimeTable.Controls.Add(this.lb3A, 0, 2);
            this.tlpTimeTable.Controls.Add(this.lb3B, 1, 2);
            this.tlpTimeTable.Controls.Add(this.lb3C, 2, 2);
            this.tlpTimeTable.Controls.Add(this.lb3D, 3, 2);
            this.tlpTimeTable.Controls.Add(this.lb4D, 3, 3);
            this.tlpTimeTable.Controls.Add(this.lb4C, 2, 3);
            this.tlpTimeTable.Controls.Add(this.lb4B, 1, 3);
            this.tlpTimeTable.Controls.Add(this.lb4A, 0, 3);
            this.tlpTimeTable.Controls.Add(this.lb5D, 3, 4);
            this.tlpTimeTable.Controls.Add(this.lb5C, 2, 4);
            this.tlpTimeTable.Controls.Add(this.lb5B, 1, 4);
            this.tlpTimeTable.Controls.Add(this.lb5A, 0, 4);
            this.tlpTimeTable.Location = new System.Drawing.Point(40, 143);
            this.tlpTimeTable.Margin = new System.Windows.Forms.Padding(40, 5, 40, 0);
            this.tlpTimeTable.Name = "tlpTimeTable";
            this.tlpTimeTable.RowCount = 6;
            this.tlpTimeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpTimeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpTimeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpTimeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpTimeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpTimeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpTimeTable.Size = new System.Drawing.Size(462, 181);
            this.tlpTimeTable.TabIndex = 5;
            this.tlpTimeTable.Visible = false;
            // 
            // lb6A
            // 
            this.lb6A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb6A.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb6A.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb6A.Location = new System.Drawing.Point(3, 153);
            this.lb6A.Margin = new System.Windows.Forms.Padding(3);
            this.lb6A.Name = "lb6A";
            this.lb6A.Size = new System.Drawing.Size(95, 25);
            this.lb6A.TabIndex = 29;
            this.lb6A.Text = "x";
            this.lb6A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb6D
            // 
            this.lb6D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb6D.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb6D.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb6D.Location = new System.Drawing.Point(297, 153);
            this.lb6D.Margin = new System.Windows.Forms.Padding(3);
            this.lb6D.Name = "lb6D";
            this.lb6D.Size = new System.Drawing.Size(162, 25);
            this.lb6D.TabIndex = 28;
            this.lb6D.Text = "x";
            this.lb6D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb6C
            // 
            this.lb6C.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb6C.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb6C.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb6C.Location = new System.Drawing.Point(196, 153);
            this.lb6C.Margin = new System.Windows.Forms.Padding(3);
            this.lb6C.Name = "lb6C";
            this.lb6C.Size = new System.Drawing.Size(95, 25);
            this.lb6C.TabIndex = 27;
            this.lb6C.Text = "x";
            this.lb6C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb6B
            // 
            this.lb6B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb6B.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb6B.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb6B.Location = new System.Drawing.Point(104, 153);
            this.lb6B.Margin = new System.Windows.Forms.Padding(3);
            this.lb6B.Name = "lb6B";
            this.lb6B.Size = new System.Drawing.Size(86, 25);
            this.lb6B.TabIndex = 26;
            this.lb6B.Text = "x";
            this.lb6B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb1A
            // 
            this.lb1A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb1A.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1A.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb1A.Location = new System.Drawing.Point(3, 3);
            this.lb1A.Margin = new System.Windows.Forms.Padding(3);
            this.lb1A.Name = "lb1A";
            this.lb1A.Size = new System.Drawing.Size(95, 24);
            this.lb1A.TabIndex = 6;
            this.lb1A.Text = "x";
            this.lb1A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb1B
            // 
            this.lb1B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb1B.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1B.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb1B.Location = new System.Drawing.Point(104, 3);
            this.lb1B.Margin = new System.Windows.Forms.Padding(3);
            this.lb1B.Name = "lb1B";
            this.lb1B.Size = new System.Drawing.Size(86, 24);
            this.lb1B.TabIndex = 0;
            this.lb1B.Text = "x";
            this.lb1B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb1C
            // 
            this.lb1C.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb1C.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1C.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb1C.Location = new System.Drawing.Point(196, 3);
            this.lb1C.Margin = new System.Windows.Forms.Padding(3);
            this.lb1C.Name = "lb1C";
            this.lb1C.Size = new System.Drawing.Size(95, 24);
            this.lb1C.TabIndex = 11;
            this.lb1C.Text = "x";
            this.lb1C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb1D
            // 
            this.lb1D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb1D.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1D.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb1D.Location = new System.Drawing.Point(297, 3);
            this.lb1D.Margin = new System.Windows.Forms.Padding(3);
            this.lb1D.Name = "lb1D";
            this.lb1D.Size = new System.Drawing.Size(162, 24);
            this.lb1D.TabIndex = 12;
            this.lb1D.Text = "x";
            this.lb1D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb2A
            // 
            this.lb2A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb2A.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2A.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb2A.Location = new System.Drawing.Point(3, 33);
            this.lb2A.Margin = new System.Windows.Forms.Padding(3);
            this.lb2A.Name = "lb2A";
            this.lb2A.Size = new System.Drawing.Size(95, 24);
            this.lb2A.TabIndex = 13;
            this.lb2A.Text = "x";
            this.lb2A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb2B
            // 
            this.lb2B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb2B.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2B.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb2B.Location = new System.Drawing.Point(104, 33);
            this.lb2B.Margin = new System.Windows.Forms.Padding(3);
            this.lb2B.Name = "lb2B";
            this.lb2B.Size = new System.Drawing.Size(86, 24);
            this.lb2B.TabIndex = 9;
            this.lb2B.Text = "x";
            this.lb2B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb2C
            // 
            this.lb2C.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb2C.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2C.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb2C.Location = new System.Drawing.Point(196, 33);
            this.lb2C.Margin = new System.Windows.Forms.Padding(3);
            this.lb2C.Name = "lb2C";
            this.lb2C.Size = new System.Drawing.Size(95, 24);
            this.lb2C.TabIndex = 8;
            this.lb2C.Text = "x";
            this.lb2C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb2D
            // 
            this.lb2D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb2D.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2D.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb2D.Location = new System.Drawing.Point(297, 33);
            this.lb2D.Margin = new System.Windows.Forms.Padding(3);
            this.lb2D.Name = "lb2D";
            this.lb2D.Size = new System.Drawing.Size(162, 24);
            this.lb2D.TabIndex = 10;
            this.lb2D.Text = "x";
            this.lb2D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb3A
            // 
            this.lb3A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb3A.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3A.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb3A.Location = new System.Drawing.Point(3, 63);
            this.lb3A.Margin = new System.Windows.Forms.Padding(3);
            this.lb3A.Name = "lb3A";
            this.lb3A.Size = new System.Drawing.Size(95, 24);
            this.lb3A.TabIndex = 16;
            this.lb3A.Text = "x";
            this.lb3A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb3B
            // 
            this.lb3B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb3B.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3B.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb3B.Location = new System.Drawing.Point(104, 63);
            this.lb3B.Margin = new System.Windows.Forms.Padding(3);
            this.lb3B.Name = "lb3B";
            this.lb3B.Size = new System.Drawing.Size(86, 24);
            this.lb3B.TabIndex = 15;
            this.lb3B.Text = "x";
            this.lb3B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb3C
            // 
            this.lb3C.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb3C.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3C.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb3C.Location = new System.Drawing.Point(196, 63);
            this.lb3C.Margin = new System.Windows.Forms.Padding(3);
            this.lb3C.Name = "lb3C";
            this.lb3C.Size = new System.Drawing.Size(95, 24);
            this.lb3C.TabIndex = 14;
            this.lb3C.Text = "x";
            this.lb3C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb3D
            // 
            this.lb3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb3D.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3D.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb3D.Location = new System.Drawing.Point(297, 63);
            this.lb3D.Margin = new System.Windows.Forms.Padding(3);
            this.lb3D.Name = "lb3D";
            this.lb3D.Size = new System.Drawing.Size(162, 24);
            this.lb3D.TabIndex = 17;
            this.lb3D.Text = "x";
            this.lb3D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb4D
            // 
            this.lb4D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb4D.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4D.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb4D.Location = new System.Drawing.Point(297, 93);
            this.lb4D.Margin = new System.Windows.Forms.Padding(3);
            this.lb4D.Name = "lb4D";
            this.lb4D.Size = new System.Drawing.Size(162, 24);
            this.lb4D.TabIndex = 19;
            this.lb4D.Text = "x";
            this.lb4D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb4C
            // 
            this.lb4C.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb4C.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4C.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb4C.Location = new System.Drawing.Point(196, 93);
            this.lb4C.Margin = new System.Windows.Forms.Padding(3);
            this.lb4C.Name = "lb4C";
            this.lb4C.Size = new System.Drawing.Size(95, 24);
            this.lb4C.TabIndex = 18;
            this.lb4C.Text = "x";
            this.lb4C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb4B
            // 
            this.lb4B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb4B.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4B.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb4B.Location = new System.Drawing.Point(104, 93);
            this.lb4B.Margin = new System.Windows.Forms.Padding(3);
            this.lb4B.Name = "lb4B";
            this.lb4B.Size = new System.Drawing.Size(86, 24);
            this.lb4B.TabIndex = 20;
            this.lb4B.Text = "x";
            this.lb4B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb4A
            // 
            this.lb4A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb4A.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4A.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb4A.Location = new System.Drawing.Point(3, 93);
            this.lb4A.Margin = new System.Windows.Forms.Padding(3);
            this.lb4A.Name = "lb4A";
            this.lb4A.Size = new System.Drawing.Size(95, 24);
            this.lb4A.TabIndex = 21;
            this.lb4A.Text = "x";
            this.lb4A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb5D
            // 
            this.lb5D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb5D.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5D.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb5D.Location = new System.Drawing.Point(297, 123);
            this.lb5D.Margin = new System.Windows.Forms.Padding(3);
            this.lb5D.Name = "lb5D";
            this.lb5D.Size = new System.Drawing.Size(162, 24);
            this.lb5D.TabIndex = 24;
            this.lb5D.Text = "x";
            this.lb5D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb5C
            // 
            this.lb5C.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb5C.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5C.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb5C.Location = new System.Drawing.Point(196, 123);
            this.lb5C.Margin = new System.Windows.Forms.Padding(3);
            this.lb5C.Name = "lb5C";
            this.lb5C.Size = new System.Drawing.Size(95, 24);
            this.lb5C.TabIndex = 22;
            this.lb5C.Text = "x";
            this.lb5C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb5B
            // 
            this.lb5B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb5B.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5B.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb5B.Location = new System.Drawing.Point(104, 123);
            this.lb5B.Margin = new System.Windows.Forms.Padding(3);
            this.lb5B.Name = "lb5B";
            this.lb5B.Size = new System.Drawing.Size(86, 24);
            this.lb5B.TabIndex = 23;
            this.lb5B.Text = "x";
            this.lb5B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb5A
            // 
            this.lb5A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb5A.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5A.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb5A.Location = new System.Drawing.Point(3, 123);
            this.lb5A.Margin = new System.Windows.Forms.Padding(3);
            this.lb5A.Name = "lb5A";
            this.lb5A.Size = new System.Drawing.Size(95, 24);
            this.lb5A.TabIndex = 25;
            this.lb5A.Text = "x";
            this.lb5A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpTimeTableHeader
            // 
            this.tlpTimeTableHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTimeTableHeader.ColumnCount = 4;
            this.tlpTimeTableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tlpTimeTableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTimeTableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tlpTimeTableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tlpTimeTableHeader.Controls.Add(this.lbDauer, 3, 0);
            this.tlpTimeTableHeader.Controls.Add(this.lbAnkunft, 2, 0);
            this.tlpTimeTableHeader.Controls.Add(this.lbAbfahrt, 0, 0);
            this.tlpTimeTableHeader.Controls.Add(this.lbGleisKante, 1, 0);
            this.tlpTimeTableHeader.Location = new System.Drawing.Point(40, 101);
            this.tlpTimeTableHeader.Margin = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.tlpTimeTableHeader.Name = "tlpTimeTableHeader";
            this.tlpTimeTableHeader.RowCount = 1;
            this.tlpTimeTableHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTimeTableHeader.Size = new System.Drawing.Size(462, 37);
            this.tlpTimeTableHeader.TabIndex = 4;
            this.tlpTimeTableHeader.Visible = false;
            // 
            // lbDauer
            // 
            this.lbDauer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDauer.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDauer.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbDauer.Location = new System.Drawing.Point(297, 3);
            this.lbDauer.Margin = new System.Windows.Forms.Padding(3);
            this.lbDauer.Name = "lbDauer";
            this.lbDauer.Size = new System.Drawing.Size(162, 31);
            this.lbDauer.TabIndex = 8;
            this.lbDauer.Text = "Dauer";
            this.lbDauer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbAnkunft
            // 
            this.lbAnkunft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAnkunft.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnkunft.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbAnkunft.Location = new System.Drawing.Point(196, 3);
            this.lbAnkunft.Margin = new System.Windows.Forms.Padding(3);
            this.lbAnkunft.Name = "lbAnkunft";
            this.lbAnkunft.Size = new System.Drawing.Size(95, 31);
            this.lbAnkunft.TabIndex = 7;
            this.lbAnkunft.Text = "Ankunft";
            this.lbAnkunft.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbAbfahrt
            // 
            this.lbAbfahrt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAbfahrt.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAbfahrt.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbAbfahrt.Location = new System.Drawing.Point(3, 3);
            this.lbAbfahrt.Margin = new System.Windows.Forms.Padding(3);
            this.lbAbfahrt.Name = "lbAbfahrt";
            this.lbAbfahrt.Size = new System.Drawing.Size(95, 31);
            this.lbAbfahrt.TabIndex = 0;
            this.lbAbfahrt.Text = "Abfahrt";
            this.lbAbfahrt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbGleisKante
            // 
            this.lbGleisKante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbGleisKante.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGleisKante.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbGleisKante.Location = new System.Drawing.Point(104, 3);
            this.lbGleisKante.Margin = new System.Windows.Forms.Padding(3);
            this.lbGleisKante.Name = "lbGleisKante";
            this.lbGleisKante.Size = new System.Drawing.Size(86, 31);
            this.lbGleisKante.TabIndex = 1;
            this.lbGleisKante.Text = "Gleis - Kante";
            this.lbGleisKante.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbVonNach
            // 
            this.lbVonNach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVonNach.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVonNach.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbVonNach.Location = new System.Drawing.Point(40, 40);
            this.lbVonNach.Margin = new System.Windows.Forms.Padding(40, 40, 40, 0);
            this.lbVonNach.Name = "lbVonNach";
            this.lbVonNach.Size = new System.Drawing.Size(464, 61);
            this.lbVonNach.TabIndex = 3;
            this.lbVonNach.Text = "Geben Sie die gewünschte Strecke ein!";
            this.lbVonNach.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlVerbindungen
            // 
            this.pnlVerbindungen.BackColor = System.Drawing.Color.Honeydew;
            this.pnlVerbindungen.Controls.Add(this.tlpConnectionsTable);
            this.pnlVerbindungen.Controls.Add(this.tlpConnectionsHeader);
            this.pnlVerbindungen.Controls.Add(this.btnVerbindungenAnzeigen);
            this.pnlVerbindungen.Controls.Add(this.tableLayoutPanel1);
            this.pnlVerbindungen.Location = new System.Drawing.Point(544, 62);
            this.pnlVerbindungen.Margin = new System.Windows.Forms.Padding(0);
            this.pnlVerbindungen.Name = "pnlVerbindungen";
            this.pnlVerbindungen.Size = new System.Drawing.Size(502, 356);
            this.pnlVerbindungen.TabIndex = 0;
            // 
            // tlpConnectionsTable
            // 
            this.tlpConnectionsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpConnectionsTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpConnectionsTable.ColumnCount = 4;
            this.tlpConnectionsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpConnectionsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpConnectionsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpConnectionsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpConnectionsTable.Location = new System.Drawing.Point(33, 236);
            this.tlpConnectionsTable.Margin = new System.Windows.Forms.Padding(40, 5, 35, 0);
            this.tlpConnectionsTable.Name = "tlpConnectionsTable";
            this.tlpConnectionsTable.RowCount = 2;
            this.tlpConnectionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpConnectionsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpConnectionsTable.Size = new System.Drawing.Size(458, 104);
            this.tlpConnectionsTable.TabIndex = 3;
            // 
            // tlpConnectionsHeader
            // 
            this.tlpConnectionsHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpConnectionsHeader.ColumnCount = 4;
            this.tlpConnectionsHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpConnectionsHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpConnectionsHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpConnectionsHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpConnectionsHeader.Controls.Add(this.label3, 0, 0);
            this.tlpConnectionsHeader.Controls.Add(this.label4, 1, 0);
            this.tlpConnectionsHeader.Location = new System.Drawing.Point(33, 185);
            this.tlpConnectionsHeader.Margin = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.tlpConnectionsHeader.Name = "tlpConnectionsHeader";
            this.tlpConnectionsHeader.RowCount = 1;
            this.tlpConnectionsHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpConnectionsHeader.Size = new System.Drawing.Size(458, 37);
            this.tlpConnectionsHeader.TabIndex = 2;
            this.tlpConnectionsHeader.Visible = false;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nr";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(103, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Zielort";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnVerbindungenAnzeigen
            // 
            this.btnVerbindungenAnzeigen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerbindungenAnzeigen.BackColor = System.Drawing.Color.LightGreen;
            this.btnVerbindungenAnzeigen.FlatAppearance.BorderSize = 0;
            this.btnVerbindungenAnzeigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerbindungenAnzeigen.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerbindungenAnzeigen.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnVerbindungenAnzeigen.Location = new System.Drawing.Point(33, 98);
            this.btnVerbindungenAnzeigen.Margin = new System.Windows.Forms.Padding(40, 32, 40, 0);
            this.btnVerbindungenAnzeigen.Name = "btnVerbindungenAnzeigen";
            this.btnVerbindungenAnzeigen.Size = new System.Drawing.Size(429, 58);
            this.btnVerbindungenAnzeigen.TabIndex = 1;
            this.btnVerbindungenAnzeigen.Text = "Verbindungen anzeigen";
            this.btnVerbindungenAnzeigen.UseVisualStyleBackColor = false;
            this.btnVerbindungenAnzeigen.Click += new System.EventHandler(this.BtnVerbindungenAnzeigen_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnAbDurchsuchen, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAbStandortAnzeigen, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbxAb, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbVerbindungenAb, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(33, 32);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(33, 32, 40, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 34);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAbDurchsuchen
            // 
            this.btnAbDurchsuchen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAbDurchsuchen.BackColor = System.Drawing.Color.LightGray;
            this.btnAbDurchsuchen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbDurchsuchen.BackgroundImage")));
            this.btnAbDurchsuchen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbDurchsuchen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAbDurchsuchen.Enabled = false;
            this.btnAbDurchsuchen.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAbDurchsuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbDurchsuchen.Location = new System.Drawing.Point(363, 0);
            this.btnAbDurchsuchen.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbDurchsuchen.Name = "btnAbDurchsuchen";
            this.btnAbDurchsuchen.Size = new System.Drawing.Size(33, 34);
            this.btnAbDurchsuchen.TabIndex = 6;
            this.btnAbDurchsuchen.TabStop = false;
            this.toolTip.SetToolTip(this.btnAbDurchsuchen, "nach Stationen suchen [Enter]");
            this.btnAbDurchsuchen.UseVisualStyleBackColor = false;
            this.btnAbDurchsuchen.Click += new System.EventHandler(this.BtnAbDurchsuchen_Click);
            // 
            // btnAbStandortAnzeigen
            // 
            this.btnAbStandortAnzeigen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAbStandortAnzeigen.BackColor = System.Drawing.Color.LightGray;
            this.btnAbStandortAnzeigen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbStandortAnzeigen.BackgroundImage")));
            this.btnAbStandortAnzeigen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbStandortAnzeigen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAbStandortAnzeigen.Enabled = false;
            this.btnAbStandortAnzeigen.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAbStandortAnzeigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbStandortAnzeigen.Location = new System.Drawing.Point(396, 0);
            this.btnAbStandortAnzeigen.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbStandortAnzeigen.Name = "btnAbStandortAnzeigen";
            this.btnAbStandortAnzeigen.Size = new System.Drawing.Size(33, 34);
            this.btnAbStandortAnzeigen.TabIndex = 8;
            this.btnAbStandortAnzeigen.TabStop = false;
            this.toolTip.SetToolTip(this.btnAbStandortAnzeigen, "Standort im Browser anzeigen");
            this.btnAbStandortAnzeigen.UseVisualStyleBackColor = false;
            this.btnAbStandortAnzeigen.Click += new System.EventHandler(this.BtnAbStandortAnzeigen_Click);
            // 
            // tbxAb
            // 
            this.tbxAb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxAb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxAb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxAb.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAb.Location = new System.Drawing.Point(67, 0);
            this.tbxAb.Margin = new System.Windows.Forms.Padding(0);
            this.tbxAb.Name = "tbxAb";
            this.tbxAb.Size = new System.Drawing.Size(296, 34);
            this.tbxAb.TabIndex = 0;
            this.tbxAb.TextChanged += new System.EventHandler(this.TbxAb_TextChanged);
            this.tbxAb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxVonNachAb_KeyDown);
            // 
            // lbVerbindungenAb
            // 
            this.lbVerbindungenAb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbVerbindungenAb.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVerbindungenAb.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbVerbindungenAb.Location = new System.Drawing.Point(0, 0);
            this.lbVerbindungenAb.Margin = new System.Windows.Forms.Padding(0);
            this.lbVerbindungenAb.Name = "lbVerbindungenAb";
            this.lbVerbindungenAb.Size = new System.Drawing.Size(67, 34);
            this.lbVerbindungenAb.TabIndex = 0;
            this.lbVerbindungenAb.Text = "Ab";
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            // 
            // pnlNoInternet
            // 
            this.pnlNoInternet.BackColor = System.Drawing.Color.Honeydew;
            this.pnlNoInternet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlNoInternet.Controls.Add(this.label1);
            this.pnlNoInternet.Controls.Add(this.btnErneutVersuchen);
            this.pnlNoInternet.Controls.Add(this.tlpNoInternet);
            this.pnlNoInternet.Location = new System.Drawing.Point(544, 418);
            this.pnlNoInternet.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNoInternet.Name = "pnlNoInternet";
            this.pnlNoInternet.Size = new System.Drawing.Size(502, 382);
            this.pnlNoInternet.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(4, 242);
            this.label1.Margin = new System.Windows.Forms.Padding(40, 40, 40, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sie haben keine Verbindung zum Internet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnErneutVersuchen
            // 
            this.btnErneutVersuchen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnErneutVersuchen.BackColor = System.Drawing.Color.LightGreen;
            this.btnErneutVersuchen.FlatAppearance.BorderSize = 0;
            this.btnErneutVersuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErneutVersuchen.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErneutVersuchen.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnErneutVersuchen.Location = new System.Drawing.Point(38, 299);
            this.btnErneutVersuchen.Margin = new System.Windows.Forms.Padding(40, 32, 40, 0);
            this.btnErneutVersuchen.Name = "btnErneutVersuchen";
            this.btnErneutVersuchen.Size = new System.Drawing.Size(424, 58);
            this.btnErneutVersuchen.TabIndex = 4;
            this.btnErneutVersuchen.Text = "erneut versuchen";
            this.btnErneutVersuchen.UseVisualStyleBackColor = false;
            this.btnErneutVersuchen.Click += new System.EventHandler(this.BtnErneutVersuchen_Click);
            // 
            // tlpNoInternet
            // 
            this.tlpNoInternet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpNoInternet.ColumnCount = 3;
            this.tlpNoInternet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNoInternet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpNoInternet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNoInternet.Controls.Add(this.pnlNoInternetIcon, 1, 0);
            this.tlpNoInternet.Location = new System.Drawing.Point(3, 40);
            this.tlpNoInternet.Name = "tlpNoInternet";
            this.tlpNoInternet.RowCount = 1;
            this.tlpNoInternet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNoInternet.Size = new System.Drawing.Size(496, 196);
            this.tlpNoInternet.TabIndex = 0;
            // 
            // pnlNoInternetIcon
            // 
            this.pnlNoInternetIcon.BackgroundImage = global::Fahrplan.Properties.Resources.NoConnection;
            this.pnlNoInternetIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlNoInternetIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNoInternetIcon.Location = new System.Drawing.Point(101, 3);
            this.pnlNoInternetIcon.Name = "pnlNoInternetIcon";
            this.pnlNoInternetIcon.Size = new System.Drawing.Size(294, 190);
            this.pnlNoInternetIcon.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 521);
            this.Controls.Add(this.pnlNoInternet);
            this.Controls.Add(this.pnlFahrplan);
            this.Controls.Add(this.pnlVerbindungen);
            this.Controls.Add(this.pnlStrecke);
            this.Controls.Add(this.tlpHeadButtons);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(560, 560);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OEV Fahrplan";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tlpHeadButtons.ResumeLayout(false);
            this.pnlStrecke.ResumeLayout(false);
            this.tlpZeit.ResumeLayout(false);
            this.tlpNach.ResumeLayout(false);
            this.tlpNach.PerformLayout();
            this.tlpVon.ResumeLayout(false);
            this.tlpVon.PerformLayout();
            this.pnlFahrplan.ResumeLayout(false);
            this.tlpTimeTable.ResumeLayout(false);
            this.tlpTimeTableHeader.ResumeLayout(false);
            this.pnlVerbindungen.ResumeLayout(false);
            this.tlpConnectionsHeader.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlNoInternet.ResumeLayout(false);
            this.tlpNoInternet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpHeadButtons;
        private System.Windows.Forms.Button btnVerbindung;
        private System.Windows.Forms.Button btnStrecke;
        private System.Windows.Forms.Button btnFahrplan;
        private System.Windows.Forms.Panel pnlStrecke;
        private System.Windows.Forms.Panel pnlFahrplan;
        private System.Windows.Forms.Panel pnlVerbindungen;
        private System.Windows.Forms.Button btnVonStandortAnzeigen;
        private System.Windows.Forms.Button btnVonDurchsuchen;
        private System.Windows.Forms.TextBox tbxVon;
        private System.Windows.Forms.Label lbVon;
        private System.Windows.Forms.TableLayoutPanel tlpVon;
        private System.Windows.Forms.TableLayoutPanel tlpNach;
        private System.Windows.Forms.TextBox tbxNach;
        private System.Windows.Forms.Button btnNachStandortAnzeigen;
        private System.Windows.Forms.Button btnNachDurchsuchen;
        private System.Windows.Forms.Label lbNach;
        private System.Windows.Forms.Button btnFahrplanAnzeigen;
        private System.Windows.Forms.Label lbVonNach;
        private System.Windows.Forms.TableLayoutPanel tlpTimeTableHeader;
        private System.Windows.Forms.Label lbDauer;
        private System.Windows.Forms.Label lbAnkunft;
        private System.Windows.Forms.Label lbAbfahrt;
        private System.Windows.Forms.Label lbGleisKante;
        private System.Windows.Forms.TableLayoutPanel tlpTimeTable;
        private System.Windows.Forms.Label lb1A;
        private System.Windows.Forms.Label lb6A;
        private System.Windows.Forms.Label lb6D;
        private System.Windows.Forms.Label lb6C;
        private System.Windows.Forms.Label lb6B;
        private System.Windows.Forms.Label lb1B;
        private System.Windows.Forms.Label lb1C;
        private System.Windows.Forms.Label lb1D;
        private System.Windows.Forms.Label lb2A;
        private System.Windows.Forms.Label lb2B;
        private System.Windows.Forms.Label lb2C;
        private System.Windows.Forms.Label lb2D;
        private System.Windows.Forms.Label lb3A;
        private System.Windows.Forms.Label lb3B;
        private System.Windows.Forms.Label lb3C;
        private System.Windows.Forms.Label lb3D;
        private System.Windows.Forms.Label lb4D;
        private System.Windows.Forms.Label lb4C;
        private System.Windows.Forms.Label lb4B;
        private System.Windows.Forms.Label lb4A;
        private System.Windows.Forms.Label lb5D;
        private System.Windows.Forms.Label lb5C;
        private System.Windows.Forms.Label lb5B;
        private System.Windows.Forms.Label lb5A;
        private System.Windows.Forms.Button btnStreckeEingeben;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.TableLayoutPanel tlpZeit;
        private System.Windows.Forms.Button btnAnkunftsZeit;
        private System.Windows.Forms.Label lbZeit;
        private System.Windows.Forms.Button btnAbfahrtsZeit;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnChangeDirection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbxAb;
        private System.Windows.Forms.Label lbVerbindungenAb;
        private System.Windows.Forms.Button btnVerbindungenAnzeigen;
        private System.Windows.Forms.Button btnAbDurchsuchen;
        private System.Windows.Forms.Button btnAbStandortAnzeigen;
        private System.Windows.Forms.TableLayoutPanel tlpConnectionsTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tlpConnectionsHeader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlNoInternet;
        private System.Windows.Forms.TableLayoutPanel tlpNoInternet;
        private System.Windows.Forms.Panel pnlNoInternetIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnErneutVersuchen;
    }
}

