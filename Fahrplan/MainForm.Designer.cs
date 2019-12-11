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
            this.TableLayoutPanelHead = new System.Windows.Forms.TableLayoutPanel();
            this.BtnVerbindung = new System.Windows.Forms.Button();
            this.BtnStrecke = new System.Windows.Forms.Button();
            this.BtnFahrplan = new System.Windows.Forms.Button();
            this.PnlStrecke = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlFahrplan = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlVerbindungen = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TableLayoutPanelHead.SuspendLayout();
            this.PnlStrecke.SuspendLayout();
            this.PnlFahrplan.SuspendLayout();
            this.PnlVerbindungen.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanelHead
            // 
            this.TableLayoutPanelHead.ColumnCount = 3;
            this.TableLayoutPanelHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TableLayoutPanelHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TableLayoutPanelHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TableLayoutPanelHead.Controls.Add(this.BtnVerbindung, 2, 0);
            this.TableLayoutPanelHead.Controls.Add(this.BtnStrecke, 0, 0);
            this.TableLayoutPanelHead.Controls.Add(this.BtnFahrplan, 1, 0);
            this.TableLayoutPanelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableLayoutPanelHead.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelHead.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanelHead.Name = "TableLayoutPanelHead";
            this.TableLayoutPanelHead.RowCount = 1;
            this.TableLayoutPanelHead.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelHead.Size = new System.Drawing.Size(1103, 95);
            this.TableLayoutPanelHead.TabIndex = 0;
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
            this.BtnVerbindung.Location = new System.Drawing.Point(734, 0);
            this.BtnVerbindung.Margin = new System.Windows.Forms.Padding(0);
            this.BtnVerbindung.Name = "BtnVerbindung";
            this.BtnVerbindung.Size = new System.Drawing.Size(369, 95);
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
            this.BtnStrecke.Size = new System.Drawing.Size(367, 95);
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
            this.BtnFahrplan.Location = new System.Drawing.Point(367, 0);
            this.BtnFahrplan.Margin = new System.Windows.Forms.Padding(0);
            this.BtnFahrplan.Name = "BtnFahrplan";
            this.BtnFahrplan.Size = new System.Drawing.Size(367, 95);
            this.BtnFahrplan.TabIndex = 2;
            this.BtnFahrplan.Text = "Fahrplan";
            this.BtnFahrplan.UseVisualStyleBackColor = false;
            this.BtnFahrplan.Click += new System.EventHandler(this.BtnFahrplan_Click);
            // 
            // PnlStrecke
            // 
            this.PnlStrecke.BackColor = System.Drawing.Color.Honeydew;
            this.PnlStrecke.Controls.Add(this.label1);
            this.PnlStrecke.Location = new System.Drawing.Point(0, 95);
            this.PnlStrecke.Margin = new System.Windows.Forms.Padding(0);
            this.PnlStrecke.Name = "PnlStrecke";
            this.PnlStrecke.Size = new System.Drawing.Size(363, 355);
            this.PnlStrecke.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Strecke";
            // 
            // PnlFahrplan
            // 
            this.PnlFahrplan.BackColor = System.Drawing.Color.Honeydew;
            this.PnlFahrplan.Controls.Add(this.label2);
            this.PnlFahrplan.Location = new System.Drawing.Point(363, 95);
            this.PnlFahrplan.Margin = new System.Windows.Forms.Padding(0);
            this.PnlFahrplan.Name = "PnlFahrplan";
            this.PnlFahrplan.Size = new System.Drawing.Size(363, 355);
            this.PnlFahrplan.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fahrplan";
            // 
            // PnlVerbindungen
            // 
            this.PnlVerbindungen.BackColor = System.Drawing.Color.Honeydew;
            this.PnlVerbindungen.Controls.Add(this.label3);
            this.PnlVerbindungen.Location = new System.Drawing.Point(726, 95);
            this.PnlVerbindungen.Margin = new System.Windows.Forms.Padding(0);
            this.PnlVerbindungen.Name = "PnlVerbindungen";
            this.PnlVerbindungen.Size = new System.Drawing.Size(363, 355);
            this.PnlVerbindungen.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Verbindungen";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 708);
            this.Controls.Add(this.PnlFahrplan);
            this.Controls.Add(this.PnlVerbindungen);
            this.Controls.Add(this.PnlStrecke);
            this.Controls.Add(this.TableLayoutPanelHead);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TableLayoutPanelHead.ResumeLayout(false);
            this.PnlStrecke.ResumeLayout(false);
            this.PnlStrecke.PerformLayout();
            this.PnlFahrplan.ResumeLayout(false);
            this.PnlFahrplan.PerformLayout();
            this.PnlVerbindungen.ResumeLayout(false);
            this.PnlVerbindungen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelHead;
        private System.Windows.Forms.Button BtnVerbindung;
        private System.Windows.Forms.Button BtnStrecke;
        private System.Windows.Forms.Button BtnFahrplan;
        private System.Windows.Forms.Panel PnlStrecke;
        private System.Windows.Forms.Panel PnlFahrplan;
        private System.Windows.Forms.Panel PnlVerbindungen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

