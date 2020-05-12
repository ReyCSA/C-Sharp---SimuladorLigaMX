namespace Simulador
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Ligas = new System.Windows.Forms.MenuStrip();
            this.ligaMX = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaGeneralMX = new System.Windows.Forms.ToolStripMenuItem();
            this.descensoMX = new System.Windows.Forms.ToolStripMenuItem();
            this.simuladorMX = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascensoMX = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaAscMX = new System.Windows.Forms.ToolStripMenuItem();
            this.descensoAscMX = new System.Windows.Forms.ToolStripMenuItem();
            this.simuladorAscMX = new System.Windows.Forms.ToolStripMenuItem();
            this.ligaEspañola = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaGeneralESP = new System.Windows.Forms.ToolStripMenuItem();
            this.simuladorESP = new System.Windows.Forms.ToolStripMenuItem();
            this.ligaInglesa = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaGeneralING = new System.Windows.Forms.ToolStripMenuItem();
            this.simuladorING = new System.Windows.Forms.ToolStripMenuItem();
            this.Lista = new System.Windows.Forms.MenuStrip();
            this.Atras = new System.Windows.Forms.ToolStripMenuItem();
            this.Reload = new System.Windows.Forms.ToolStripMenuItem();
            this.Home = new System.Windows.Forms.ToolStripMenuItem();
            this.ListaProgol = new System.Windows.Forms.ToolStripMenuItem();
            this.Fijos = new System.Windows.Forms.ToolStripMenuItem();
            this.restulados = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webB = new System.Windows.Forms.WebBrowser();
            this.web = new WebKit.WebKitBrowser();
            this.Ligas.SuspendLayout();
            this.Lista.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ligas
            // 
            this.Ligas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ligaMX,
            this.ascensoMX,
            this.ligaEspañola,
            this.ligaInglesa});
            this.Ligas.Location = new System.Drawing.Point(0, 29);
            this.Ligas.Name = "Ligas";
            this.Ligas.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Ligas.Size = new System.Drawing.Size(733, 24);
            this.Ligas.TabIndex = 3;
            this.Ligas.Text = "menuStrip1";
            // 
            // ligaMX
            // 
            this.ligaMX.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablaGeneralMX,
            this.descensoMX,
            this.simuladorMX,
            this.estadisticasToolStripMenuItem});
            this.ligaMX.Name = "ligaMX";
            this.ligaMX.Size = new System.Drawing.Size(62, 20);
            this.ligaMX.Text = "Liga MX";
            // 
            // tablaGeneralMX
            // 
            this.tablaGeneralMX.Name = "tablaGeneralMX";
            this.tablaGeneralMX.Size = new System.Drawing.Size(145, 22);
            this.tablaGeneralMX.Text = "Tabla General";
            this.tablaGeneralMX.Click += new System.EventHandler(this.tablaGeneralMX_Click);
            // 
            // descensoMX
            // 
            this.descensoMX.Name = "descensoMX";
            this.descensoMX.Size = new System.Drawing.Size(145, 22);
            this.descensoMX.Text = "Descenso";
            this.descensoMX.Click += new System.EventHandler(this.descensoMX_Click);
            // 
            // simuladorMX
            // 
            this.simuladorMX.Name = "simuladorMX";
            this.simuladorMX.Size = new System.Drawing.Size(145, 22);
            this.simuladorMX.Text = "Simulador";
            this.simuladorMX.Click += new System.EventHandler(this.simuladorMX_Click);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            this.estadisticasToolStripMenuItem.Click += new System.EventHandler(this.estadisticas_Click);
            // 
            // ascensoMX
            // 
            this.ascensoMX.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablaAscMX,
            this.descensoAscMX,
            this.simuladorAscMX});
            this.ascensoMX.Name = "ascensoMX";
            this.ascensoMX.Size = new System.Drawing.Size(81, 20);
            this.ascensoMX.Text = "AscensoMX";
            // 
            // tablaAscMX
            // 
            this.tablaAscMX.Name = "tablaAscMX";
            this.tablaAscMX.Size = new System.Drawing.Size(152, 22);
            this.tablaAscMX.Text = "Tabla General";
            this.tablaAscMX.Click += new System.EventHandler(this.tablaAscMX_Click);
            // 
            // descensoAscMX
            // 
            this.descensoAscMX.Name = "descensoAscMX";
            this.descensoAscMX.Size = new System.Drawing.Size(152, 22);
            this.descensoAscMX.Text = "Descenso";
            this.descensoAscMX.Click += new System.EventHandler(this.descensoAscMX_Click);
            // 
            // simuladorAscMX
            // 
            this.simuladorAscMX.Name = "simuladorAscMX";
            this.simuladorAscMX.Size = new System.Drawing.Size(152, 22);
            this.simuladorAscMX.Text = "Simulador";
            this.simuladorAscMX.Click += new System.EventHandler(this.simuladorAscMX_Click);
            // 
            // ligaEspañola
            // 
            this.ligaEspañola.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablaGeneralESP,
            this.simuladorESP});
            this.ligaEspañola.Name = "ligaEspañola";
            this.ligaEspañola.Size = new System.Drawing.Size(91, 20);
            this.ligaEspañola.Text = "Liga Española";
            // 
            // tablaGeneralESP
            // 
            this.tablaGeneralESP.Name = "tablaGeneralESP";
            this.tablaGeneralESP.Size = new System.Drawing.Size(145, 22);
            this.tablaGeneralESP.Text = "Tabla General";
            // 
            // simuladorESP
            // 
            this.simuladorESP.Name = "simuladorESP";
            this.simuladorESP.Size = new System.Drawing.Size(145, 22);
            this.simuladorESP.Text = "Simulador";
            // 
            // ligaInglesa
            // 
            this.ligaInglesa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablaGeneralING,
            this.simuladorING});
            this.ligaInglesa.Name = "ligaInglesa";
            this.ligaInglesa.Size = new System.Drawing.Size(81, 20);
            this.ligaInglesa.Text = "Liga Inglesa";
            // 
            // tablaGeneralING
            // 
            this.tablaGeneralING.Name = "tablaGeneralING";
            this.tablaGeneralING.Size = new System.Drawing.Size(145, 22);
            this.tablaGeneralING.Text = "Tabla General";
            // 
            // simuladorING
            // 
            this.simuladorING.Name = "simuladorING";
            this.simuladorING.Size = new System.Drawing.Size(145, 22);
            this.simuladorING.Text = "Simulador";
            // 
            // Lista
            // 
            this.Lista.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Atras,
            this.Reload,
            this.Home,
            this.ListaProgol,
            this.Fijos,
            this.restulados});
            this.Lista.Location = new System.Drawing.Point(0, 0);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(733, 29);
            this.Lista.TabIndex = 5;
            this.Lista.Text = "menuStrip2";
            // 
            // Atras
            // 
            this.Atras.Image = global::Simulador.Properties.Resources.back;
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(28, 25);
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Reload
            // 
            this.Reload.Image = global::Simulador.Properties.Resources.reload;
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(28, 25);
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // Home
            // 
            this.Home.AutoSize = false;
            this.Home.Font = new System.Drawing.Font("Segoe UI", 1F);
            this.Home.Image = global::Simulador.Properties.Resources.google;
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(60, 25);
            this.Home.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // ListaProgol
            // 
            this.ListaProgol.BackColor = System.Drawing.SystemColors.Control;
            this.ListaProgol.Name = "ListaProgol";
            this.ListaProgol.Size = new System.Drawing.Size(95, 25);
            this.ListaProgol.Text = "Lista MiProgol";
            this.ListaProgol.Click += new System.EventHandler(this.ListaProgol_Click);
            // 
            // Fijos
            // 
            this.Fijos.Name = "Fijos";
            this.Fijos.Size = new System.Drawing.Size(73, 25);
            this.Fijos.Text = "Los 6 Fijos";
            this.Fijos.Click += new System.EventHandler(this.Fijos_Click);
            // 
            // restulados
            // 
            this.restulados.Name = "restulados";
            this.restulados.Size = new System.Drawing.Size(118, 25);
            this.restulados.Text = "Restulados en Vivo";
            this.restulados.Click += new System.EventHandler(this.resultados_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.webB);
            this.panel1.Controls.Add(this.web);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 372);
            this.panel1.TabIndex = 6;
            // 
            // webB
            // 
            this.webB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webB.Location = new System.Drawing.Point(0, 0);
            this.webB.MinimumSize = new System.Drawing.Size(20, 20);
            this.webB.Name = "webB";
            this.webB.Size = new System.Drawing.Size(733, 372);
            this.webB.TabIndex = 1;
            this.webB.Url = new System.Uri("https://www.resultados-ya.com/", System.UriKind.Absolute);
            // 
            // web
            // 
            this.web.BackColor = System.Drawing.Color.White;
            this.web.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web.Location = new System.Drawing.Point(0, 0);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(733, 372);
            this.web.TabIndex = 0;
            this.web.Url = new System.Uri("https://www.resultados-ya.com", System.UriKind.Absolute);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 425);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Ligas);
            this.Controls.Add(this.Lista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Simulador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Ligas.ResumeLayout(false);
            this.Ligas.PerformLayout();
            this.Lista.ResumeLayout(false);
            this.Lista.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Ligas;
        private System.Windows.Forms.ToolStripMenuItem ligaMX;
        private System.Windows.Forms.ToolStripMenuItem tablaGeneralMX;
        private System.Windows.Forms.ToolStripMenuItem descensoMX;
        private System.Windows.Forms.ToolStripMenuItem simuladorMX;
        private System.Windows.Forms.ToolStripMenuItem ascensoMX;
        private System.Windows.Forms.ToolStripMenuItem tablaAscMX;
        private System.Windows.Forms.ToolStripMenuItem descensoAscMX;
        private System.Windows.Forms.ToolStripMenuItem simuladorAscMX;
        private System.Windows.Forms.ToolStripMenuItem ligaEspañola;
        private System.Windows.Forms.ToolStripMenuItem tablaGeneralESP;
        private System.Windows.Forms.ToolStripMenuItem simuladorESP;
        private System.Windows.Forms.ToolStripMenuItem ligaInglesa;
        private System.Windows.Forms.ToolStripMenuItem tablaGeneralING;
        private System.Windows.Forms.ToolStripMenuItem simuladorING;
        private System.Windows.Forms.MenuStrip Lista;
        private System.Windows.Forms.ToolStripMenuItem ListaProgol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem Atras;
        private System.Windows.Forms.ToolStripMenuItem Fijos;
        private System.Windows.Forms.ToolStripMenuItem Home;
        private System.Windows.Forms.ToolStripMenuItem Reload;
        private WebKit.WebKitBrowser web;
        private System.Windows.Forms.ToolStripMenuItem restulados;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webB;
    }
}

