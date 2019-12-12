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
            this.TpnlHeadButtons = new System.Windows.Forms.TableLayoutPanel();
            this.BtnVerbindung = new System.Windows.Forms.Button();
            this.BtnStrecke = new System.Windows.Forms.Button();
            this.BtnFahrplan = new System.Windows.Forms.Button();
            this.PnlStrecke = new System.Windows.Forms.Panel();
            this.BtnVerbindungenAnzeigen = new System.Windows.Forms.Button();
            this.TpnlNach = new System.Windows.Forms.TableLayoutPanel();
            this.TbxNach = new System.Windows.Forms.TextBox();
            this.BtnNachStandortAnzeigen = new System.Windows.Forms.Button();
            this.BtnNachMeinStandort = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TpnlVon = new System.Windows.Forms.TableLayoutPanel();
            this.TbxVon = new System.Windows.Forms.TextBox();
            this.BtnVonStandortAnzeigen = new System.Windows.Forms.Button();
            this.BtnVonMeinStandort = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlFahrplan = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlVerbindungen = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TpnlHeadButtons.SuspendLayout();
            this.PnlStrecke.SuspendLayout();
            this.TpnlNach.SuspendLayout();
            this.TpnlVon.SuspendLayout();
            this.PnlFahrplan.SuspendLayout();
            this.PnlVerbindungen.SuspendLayout();
            this.SuspendLayout();
            // 
            // TpnlHeadButtons
            // 
            this.TpnlHeadButtons.ColumnCount = 3;
            this.TpnlHeadButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TpnlHeadButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TpnlHeadButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TpnlHeadButtons.Controls.Add(this.BtnVerbindung, 2, 0);
            this.TpnlHeadButtons.Controls.Add(this.BtnStrecke, 0, 0);
            this.TpnlHeadButtons.Controls.Add(this.BtnFahrplan, 1, 0);
            this.TpnlHeadButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.TpnlHeadButtons.Location = new System.Drawing.Point(0, 0);
            this.TpnlHeadButtons.Margin = new System.Windows.Forms.Padding(0);
            this.TpnlHeadButtons.Name = "TpnlHeadButtons";
            this.TpnlHeadButtons.RowCount = 1;
            this.TpnlHeadButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TpnlHeadButtons.Size = new System.Drawing.Size(826, 95);
            this.TpnlHeadButtons.TabIndex = 0;
            // 
            // BtnVerbindung
            // 
            this.BtnVerbindung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVerbindung.BackColor = System.Drawing.Color.LightGreen;
            this.BtnVerbindung.FlatAppearance.BorderSize = 0;
            this.BtnVerbindung.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnVerbindung.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnVerbindung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerbindung.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerbindung.ForeColor = System.Drawing.Color.DarkGreen;
            this.BtnVerbindung.Location = new System.Drawing.Point(550, 0);
            this.BtnVerbindung.Margin = new System.Windows.Forms.Padding(0);
            this.BtnVerbindung.Name = "BtnVerbindung";
            this.BtnVerbindung.Size = new System.Drawing.Size(276, 95);
            this.BtnVerbindung.TabIndex = 3;
            this.BtnVerbindung.Text = "Verbindungen";
            this.BtnVerbindung.UseVisualStyleBackColor = false;
            this.BtnVerbindung.Click += new System.EventHandler(this.BtnVerbindung_Click);
            // 
            // BtnStrecke
            // 
            this.BtnStrecke.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnStrecke.BackColor = System.Drawing.Color.LightGreen;
            this.BtnStrecke.FlatAppearance.BorderSize = 0;
            this.BtnStrecke.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnStrecke.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnStrecke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStrecke.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStrecke.ForeColor = System.Drawing.Color.DarkGreen;
            this.BtnStrecke.Location = new System.Drawing.Point(0, 0);
            this.BtnStrecke.Margin = new System.Windows.Forms.Padding(0);
            this.BtnStrecke.Name = "BtnStrecke";
            this.BtnStrecke.Size = new System.Drawing.Size(275, 95);
            this.BtnStrecke.TabIndex = 1;
            this.BtnStrecke.Text = "Strecke";
            this.BtnStrecke.UseVisualStyleBackColor = false;
            this.BtnStrecke.Click += new System.EventHandler(this.BtnStrecke_Click);
            // 
            // BtnFahrplan
            // 
            this.BtnFahrplan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFahrplan.BackColor = System.Drawing.Color.LightGreen;
            this.BtnFahrplan.FlatAppearance.BorderSize = 0;
            this.BtnFahrplan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnFahrplan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnFahrplan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFahrplan.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFahrplan.ForeColor = System.Drawing.Color.DarkGreen;
            this.BtnFahrplan.Location = new System.Drawing.Point(275, 0);
            this.BtnFahrplan.Margin = new System.Windows.Forms.Padding(0);
            this.BtnFahrplan.Name = "BtnFahrplan";
            this.BtnFahrplan.Size = new System.Drawing.Size(275, 95);
            this.BtnFahrplan.TabIndex = 2;
            this.BtnFahrplan.Text = "Fahrplan";
            this.BtnFahrplan.UseVisualStyleBackColor = false;
            this.BtnFahrplan.Click += new System.EventHandler(this.BtnFahrplan_Click);
            // 
            // PnlStrecke
            // 
            this.PnlStrecke.BackColor = System.Drawing.Color.Honeydew;
            this.PnlStrecke.Controls.Add(this.BtnVerbindungenAnzeigen);
            this.PnlStrecke.Controls.Add(this.TpnlNach);
            this.PnlStrecke.Controls.Add(this.TpnlVon);
            this.PnlStrecke.Controls.Add(this.label1);
            this.PnlStrecke.Location = new System.Drawing.Point(0, 95);
            this.PnlStrecke.Margin = new System.Windows.Forms.Padding(0);
            this.PnlStrecke.Name = "PnlStrecke";
            this.PnlStrecke.Size = new System.Drawing.Size(816, 388);
            this.PnlStrecke.TabIndex = 1;
            // 
            // BtnVerbindungenAnzeigen
            // 
            this.BtnVerbindungenAnzeigen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVerbindungenAnzeigen.BackColor = System.Drawing.Color.LightGreen;
            this.BtnVerbindungenAnzeigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerbindungenAnzeigen.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerbindungenAnzeigen.ForeColor = System.Drawing.Color.DarkGreen;
            this.BtnVerbindungenAnzeigen.Location = new System.Drawing.Point(60, 264);
            this.BtnVerbindungenAnzeigen.Margin = new System.Windows.Forms.Padding(60, 60, 60, 0);
            this.BtnVerbindungenAnzeigen.Name = "BtnVerbindungenAnzeigen";
            this.BtnVerbindungenAnzeigen.Size = new System.Drawing.Size(696, 90);
            this.BtnVerbindungenAnzeigen.TabIndex = 12;
            this.BtnVerbindungenAnzeigen.Text = "Verbindungen Anzeigen";
            this.BtnVerbindungenAnzeigen.UseVisualStyleBackColor = false;
            // 
            // TpnlNach
            // 
            this.TpnlNach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TpnlNach.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TpnlNach.ColumnCount = 4;
            this.TpnlNach.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TpnlNach.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TpnlNach.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TpnlNach.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TpnlNach.Controls.Add(this.TbxNach, 1, 0);
            this.TpnlNach.Controls.Add(this.BtnNachStandortAnzeigen, 3, 0);
            this.TpnlNach.Controls.Add(this.BtnNachMeinStandort, 2, 0);
            this.TpnlNach.Controls.Add(this.label5, 0, 0);
            this.TpnlNach.Location = new System.Drawing.Point(50, 152);
            this.TpnlNach.Margin = new System.Windows.Forms.Padding(50, 50, 60, 0);
            this.TpnlNach.Name = "TpnlNach";
            this.TpnlNach.RowCount = 1;
            this.TpnlNach.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.TpnlNach.Size = new System.Drawing.Size(706, 52);
            this.TpnlNach.TabIndex = 11;
            // 
            // TbxNach
            // 
            this.TbxNach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TbxNach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TbxNach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbxNach.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxNach.Location = new System.Drawing.Point(100, 0);
            this.TbxNach.Margin = new System.Windows.Forms.Padding(0);
            this.TbxNach.Name = "TbxNach";
            this.TbxNach.Size = new System.Drawing.Size(506, 47);
            this.TbxNach.TabIndex = 3;
            this.TbxNach.TextChanged += new System.EventHandler(this.TbxNach_TextChanged);
            // 
            // BtnNachStandortAnzeigen
            // 
            this.BtnNachStandortAnzeigen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnNachStandortAnzeigen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNachStandortAnzeigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNachStandortAnzeigen.Location = new System.Drawing.Point(656, 0);
            this.BtnNachStandortAnzeigen.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNachStandortAnzeigen.Name = "BtnNachStandortAnzeigen";
            this.BtnNachStandortAnzeigen.Size = new System.Drawing.Size(50, 52);
            this.BtnNachStandortAnzeigen.TabIndex = 7;
            this.BtnNachStandortAnzeigen.Text = "button2";
            this.BtnNachStandortAnzeigen.UseVisualStyleBackColor = true;
            // 
            // BtnNachMeinStandort
            // 
            this.BtnNachMeinStandort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnNachMeinStandort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNachMeinStandort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNachMeinStandort.Location = new System.Drawing.Point(606, 0);
            this.BtnNachMeinStandort.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNachMeinStandort.Name = "BtnNachMeinStandort";
            this.BtnNachMeinStandort.Size = new System.Drawing.Size(50, 52);
            this.BtnNachMeinStandort.TabIndex = 5;
            this.BtnNachMeinStandort.Text = "button4";
            this.BtnNachMeinStandort.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 52);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nach";
            // 
            // TpnlVon
            // 
            this.TpnlVon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TpnlVon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TpnlVon.ColumnCount = 4;
            this.TpnlVon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TpnlVon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TpnlVon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TpnlVon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TpnlVon.Controls.Add(this.TbxVon, 1, 0);
            this.TpnlVon.Controls.Add(this.BtnVonStandortAnzeigen, 3, 0);
            this.TpnlVon.Controls.Add(this.BtnVonMeinStandort, 2, 0);
            this.TpnlVon.Controls.Add(this.label4, 0, 0);
            this.TpnlVon.Location = new System.Drawing.Point(50, 50);
            this.TpnlVon.Margin = new System.Windows.Forms.Padding(50, 50, 60, 0);
            this.TpnlVon.Name = "TpnlVon";
            this.TpnlVon.RowCount = 1;
            this.TpnlVon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.TpnlVon.Size = new System.Drawing.Size(706, 52);
            this.TpnlVon.TabIndex = 10;
            // 
            // TbxVon
            // 
            this.TbxVon.AutoCompleteCustomSource.AddRange(new string[] {
            "David",
            "Davidiud",
            "Hans",
            "Hansruedi"});
            this.TbxVon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TbxVon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TbxVon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbxVon.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxVon.Location = new System.Drawing.Point(100, 0);
            this.TbxVon.Margin = new System.Windows.Forms.Padding(0);
            this.TbxVon.Name = "TbxVon";
            this.TbxVon.Size = new System.Drawing.Size(506, 47);
            this.TbxVon.TabIndex = 3;
            this.TbxVon.TextChanged += new System.EventHandler(this.TbxVon_TextChanged);
            // 
            // BtnVonStandortAnzeigen
            // 
            this.BtnVonStandortAnzeigen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnVonStandortAnzeigen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnVonStandortAnzeigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVonStandortAnzeigen.Location = new System.Drawing.Point(656, 0);
            this.BtnVonStandortAnzeigen.Margin = new System.Windows.Forms.Padding(0);
            this.BtnVonStandortAnzeigen.Name = "BtnVonStandortAnzeigen";
            this.BtnVonStandortAnzeigen.Size = new System.Drawing.Size(50, 52);
            this.BtnVonStandortAnzeigen.TabIndex = 7;
            this.BtnVonStandortAnzeigen.Text = "button3";
            this.BtnVonStandortAnzeigen.UseVisualStyleBackColor = true;
            // 
            // BtnVonMeinStandort
            // 
            this.BtnVonMeinStandort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnVonMeinStandort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnVonMeinStandort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVonMeinStandort.Location = new System.Drawing.Point(606, 0);
            this.BtnVonMeinStandort.Margin = new System.Windows.Forms.Padding(0);
            this.BtnVonMeinStandort.Name = "BtnVonMeinStandort";
            this.BtnVonMeinStandort.Size = new System.Drawing.Size(50, 52);
            this.BtnVonMeinStandort.TabIndex = 5;
            this.BtnVonMeinStandort.Text = "button1";
            this.BtnVonMeinStandort.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 52);
            this.label4.TabIndex = 1;
            this.label4.Text = "Von";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(752, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Strecke";
            // 
            // PnlFahrplan
            // 
            this.PnlFahrplan.BackColor = System.Drawing.Color.Honeydew;
            this.PnlFahrplan.Controls.Add(this.label2);
            this.PnlFahrplan.Location = new System.Drawing.Point(0, 483);
            this.PnlFahrplan.Margin = new System.Windows.Forms.Padding(0);
            this.PnlFahrplan.Name = "PnlFahrplan";
            this.PnlFahrplan.Size = new System.Drawing.Size(816, 478);
            this.PnlFahrplan.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(744, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fahrplan";
            // 
            // PnlVerbindungen
            // 
            this.PnlVerbindungen.BackColor = System.Drawing.Color.Honeydew;
            this.PnlVerbindungen.Controls.Add(this.label3);
            this.PnlVerbindungen.Location = new System.Drawing.Point(656, 992);
            this.PnlVerbindungen.Margin = new System.Windows.Forms.Padding(0);
            this.PnlVerbindungen.Name = "PnlVerbindungen";
            this.PnlVerbindungen.Size = new System.Drawing.Size(160, 48);
            this.PnlVerbindungen.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Verbindungen";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 1050);
            this.Controls.Add(this.PnlFahrplan);
            this.Controls.Add(this.PnlVerbindungen);
            this.Controls.Add(this.PnlStrecke);
            this.Controls.Add(this.TpnlHeadButtons);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TpnlHeadButtons.ResumeLayout(false);
            this.PnlStrecke.ResumeLayout(false);
            this.PnlStrecke.PerformLayout();
            this.TpnlNach.ResumeLayout(false);
            this.TpnlNach.PerformLayout();
            this.TpnlVon.ResumeLayout(false);
            this.TpnlVon.PerformLayout();
            this.PnlFahrplan.ResumeLayout(false);
            this.PnlFahrplan.PerformLayout();
            this.PnlVerbindungen.ResumeLayout(false);
            this.PnlVerbindungen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TpnlHeadButtons;
        private System.Windows.Forms.Button BtnVerbindung;
        private System.Windows.Forms.Button BtnStrecke;
        private System.Windows.Forms.Button BtnFahrplan;
        private System.Windows.Forms.Panel PnlStrecke;
        private System.Windows.Forms.Panel PnlFahrplan;
        private System.Windows.Forms.Panel PnlVerbindungen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnVonStandortAnzeigen;
        private System.Windows.Forms.Button BtnVonMeinStandort;
        private System.Windows.Forms.TextBox TbxVon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel TpnlVon;
        private System.Windows.Forms.TableLayoutPanel TpnlNach;
        private System.Windows.Forms.TextBox TbxNach;
        private System.Windows.Forms.Button BtnNachStandortAnzeigen;
        private System.Windows.Forms.Button BtnNachMeinStandort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnVerbindungenAnzeigen;
    }
}

