namespace Simulador.Simulador.Mex
{
    partial class TablaMX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablaMX));
            this.panel = new System.Windows.Forms.Panel();
            this.TG = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logo = new System.Windows.Forms.DataGridViewImageColumn();
            this.cmbTorneo = new System.Windows.Forms.ComboBox();
            this.cmbJornada = new System.Windows.Forms.ComboBox();
            this.Pjornada = new System.Windows.Forms.Label();
            this.lblJornada = new System.Windows.Forms.Label();
            this.lblTorneo = new System.Windows.Forms.Label();
            this.pbLiga = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TablaJ = new System.Windows.Forms.DataGridView();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLiga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaJ)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.TG);
            this.panel.Location = new System.Drawing.Point(12, 85);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1160, 446);
            this.panel.TabIndex = 1;
            // 
            // TG
            // 
            this.TG.AllowUserToAddRows = false;
            this.TG.AllowUserToDeleteRows = false;
            this.TG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Logo});
            this.TG.Location = new System.Drawing.Point(1, 2);
            this.TG.Name = "TG";
            this.TG.ReadOnly = true;
            this.TG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TG.Size = new System.Drawing.Size(1159, 444);
            this.TG.TabIndex = 2;
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.No.FillWeight = 25F;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.No.Width = 46;
            // 
            // Logo
            // 
            this.Logo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Logo.FillWeight = 45F;
            this.Logo.HeaderText = "";
            this.Logo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Logo.Name = "Logo";
            this.Logo.ReadOnly = true;
            this.Logo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cmbTorneo
            // 
            this.cmbTorneo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTorneo.FormattingEnabled = true;
            this.cmbTorneo.Location = new System.Drawing.Point(114, 34);
            this.cmbTorneo.Name = "cmbTorneo";
            this.cmbTorneo.Size = new System.Drawing.Size(123, 33);
            this.cmbTorneo.TabIndex = 233;
            this.cmbTorneo.SelectedIndexChanged += new System.EventHandler(this.cmbTorneo_SelectedIndexChanged);
            // 
            // cmbJornada
            // 
            this.cmbJornada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbJornada.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJornada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbJornada.FormattingEnabled = true;
            this.cmbJornada.Location = new System.Drawing.Point(258, 34);
            this.cmbJornada.Name = "cmbJornada";
            this.cmbJornada.Size = new System.Drawing.Size(142, 33);
            this.cmbJornada.TabIndex = 232;
            this.cmbJornada.Text = "Jornada";
            this.cmbJornada.SelectedIndexChanged += new System.EventHandler(this.cmbJornada_SelectedIndexChanged);
            // 
            // Pjornada
            // 
            this.Pjornada.AutoSize = true;
            this.Pjornada.Location = new System.Drawing.Point(725, 20);
            this.Pjornada.Name = "Pjornada";
            this.Pjornada.Size = new System.Drawing.Size(49, 13);
            this.Pjornada.TabIndex = 239;
            this.Pjornada.Text = "Pjornada";
            this.Pjornada.Visible = false;
            // 
            // lblJornada
            // 
            this.lblJornada.AutoSize = true;
            this.lblJornada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJornada.Location = new System.Drawing.Point(665, 20);
            this.lblJornada.Name = "lblJornada";
            this.lblJornada.Size = new System.Drawing.Size(45, 13);
            this.lblJornada.TabIndex = 238;
            this.lblJornada.Text = "Jornada";
            this.lblJornada.Visible = false;
            // 
            // lblTorneo
            // 
            this.lblTorneo.AutoSize = true;
            this.lblTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTorneo.Location = new System.Drawing.Point(607, 20);
            this.lblTorneo.Name = "lblTorneo";
            this.lblTorneo.Size = new System.Drawing.Size(41, 13);
            this.lblTorneo.TabIndex = 237;
            this.lblTorneo.Text = "Torneo";
            this.lblTorneo.Visible = false;
            // 
            // pbLiga
            // 
            this.pbLiga.Location = new System.Drawing.Point(37, 20);
            this.pbLiga.Name = "pbLiga";
            this.pbLiga.Size = new System.Drawing.Size(52, 50);
            this.pbLiga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLiga.TabIndex = 243;
            this.pbLiga.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 266;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(420, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 267;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TablaJ
            // 
            this.TablaJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaJ.Location = new System.Drawing.Point(12, 8);
            this.TablaJ.Name = "TablaJ";
            this.TablaJ.Size = new System.Drawing.Size(10, 10);
            this.TablaJ.TabIndex = 268;
            this.TablaJ.Visible = false;
            // 
            // TablaMX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1185, 534);
            this.Controls.Add(this.TablaJ);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbLiga);
            this.Controls.Add(this.Pjornada);
            this.Controls.Add(this.lblJornada);
            this.Controls.Add(this.lblTorneo);
            this.Controls.Add(this.cmbTorneo);
            this.Controls.Add(this.cmbJornada);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TablaMX";
            this.Text = "Tabla General LigaMX";
            this.Load += new System.EventHandler(this.Tabla_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLiga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaJ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView TG;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewImageColumn Logo;
        private System.Windows.Forms.ComboBox cmbTorneo;
        private System.Windows.Forms.ComboBox cmbJornada;
        private System.Windows.Forms.Label Pjornada;
        private System.Windows.Forms.Label lblJornada;
        private System.Windows.Forms.Label lblTorneo;
        private System.Windows.Forms.PictureBox pbLiga;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView TablaJ;
    }
}