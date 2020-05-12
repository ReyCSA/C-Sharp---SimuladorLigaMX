namespace Simulador.Simulador.MexA
{
    partial class SimTablaMXA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimTablaMXA));
            this.TG = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logo = new System.Windows.Forms.DataGridViewImageColumn();
            this.pbLiga = new System.Windows.Forms.PictureBox();
            this.lblJornada = new System.Windows.Forms.Label();
            this.lblTorneo = new System.Windows.Forms.Label();
            this.TablaJ = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLiga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaJ)).BeginInit();
            this.SuspendLayout();
            // 
            // TG
            // 
            this.TG.AllowUserToAddRows = false;
            this.TG.AllowUserToDeleteRows = false;
            this.TG.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.TG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TG.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.TG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Logo});
            this.TG.Location = new System.Drawing.Point(12, 68);
            this.TG.Name = "TG";
            this.TG.ReadOnly = true;
            this.TG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TG.Size = new System.Drawing.Size(1159, 334);
            this.TG.TabIndex = 244;
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
            // pbLiga
            // 
            this.pbLiga.Location = new System.Drawing.Point(12, 12);
            this.pbLiga.Name = "pbLiga";
            this.pbLiga.Size = new System.Drawing.Size(52, 50);
            this.pbLiga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLiga.TabIndex = 245;
            this.pbLiga.TabStop = false;
            // 
            // lblJornada
            // 
            this.lblJornada.AutoSize = true;
            this.lblJornada.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJornada.Location = new System.Drawing.Point(373, 29);
            this.lblJornada.Name = "lblJornada";
            this.lblJornada.Size = new System.Drawing.Size(97, 26);
            this.lblJornada.TabIndex = 247;
            this.lblJornada.Text = "Jornada";
            // 
            // lblTorneo
            // 
            this.lblTorneo.AutoSize = true;
            this.lblTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTorneo.Location = new System.Drawing.Point(109, 29);
            this.lblTorneo.Name = "lblTorneo";
            this.lblTorneo.Size = new System.Drawing.Size(85, 26);
            this.lblTorneo.TabIndex = 246;
            this.lblTorneo.Text = "Torneo";
            // 
            // TablaJ
            // 
            this.TablaJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaJ.Location = new System.Drawing.Point(70, 12);
            this.TablaJ.Name = "TablaJ";
            this.TablaJ.Size = new System.Drawing.Size(10, 10);
            this.TablaJ.TabIndex = 269;
            this.TablaJ.Visible = false;
            // 
            // SimTablaMXA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1183, 413);
            this.Controls.Add(this.TablaJ);
            this.Controls.Add(this.lblJornada);
            this.Controls.Add(this.lblTorneo);
            this.Controls.Add(this.TG);
            this.Controls.Add(this.pbLiga);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SimTablaMXA";
            this.Text = "SimTablaMX";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SimTablaMX_FormClosing);
            this.Load += new System.EventHandler(this.SimTablaMX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLiga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaJ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TG;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewImageColumn Logo;
        private System.Windows.Forms.PictureBox pbLiga;
        private System.Windows.Forms.Label lblJornada;
        private System.Windows.Forms.Label lblTorneo;
        private System.Windows.Forms.DataGridView TablaJ;

    }
}