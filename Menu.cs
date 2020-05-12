using Simulador.Simulador.Mex;
using Simulador.Simulador.MexA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            web.Navigate("https://www.resultados-ya.com/");
            webB.ScriptErrorsSuppressed = true;
        }

        #region Abrir Páginas Web
        private void Home_Click(object sender, EventArgs e)
        {
            webB.Visible = false; web.Visible = true;
            web.Navigate("https://www.google.com.mx/");
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            if (web.Visible == true)
                web.Refresh();
            else if (webB.Visible == true)
                webB.Refresh();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            web.GoBack();
        }

        private void ListaProgol_Click(object sender, EventArgs e)
        {
            web.Visible = false; webB.Visible = true;
            webB.Navigate("http://www.pronosticos.gob.mx/Paginas/Miprogol/listas-mi-progol/");
        }

        private void resultados_Click(object sender, EventArgs e)
        {
            web.Visible = false; webB.Visible = true;
            webB.Navigate("https://www.resultados-ya.com/");
        }

        private void estadisticas_Click(object sender, EventArgs e)
        {
            webB.Visible = false; web.Visible = true;
            web.Navigate("https://www.mediotiempo.com/futbol/liga-mx/");
        }

        private void descensoMX_Click(object sender, EventArgs e)
        {
            webB.Visible = false; web.Visible = true;
            web.Navigate("https://ligamx.net/cancha/cociente/");
        }

        private void Fijos_Click(object sender, EventArgs e)
        {
            web.Visible = false; webB.Visible = true;
            webB.Navigate("https://6fijosprogol.blogspot.com/");
        }       

        private void descensoAscMX_Click(object sender, EventArgs e)
        {
            webB.Visible = false; web.Visible = true;
            web.Navigate("http://www.ascensomx.net/cancha/tablas/tablaCociente/sp/99ed97615eebbd");
        }

        #endregion

        #region Abrir Formas
        private void simuladorMX_Click(object sender, EventArgs e)
        {
            SimMX LigaMX = new SimMX();
            LigaMX.Show();
        }

        private void tablaGeneralMX_Click(object sender, EventArgs e)
        {
            TablaMX LigaMX = new TablaMX();
            LigaMX.Show();
        }
        #endregion

        private void simuladorAscMX_Click(object sender, EventArgs e)
        {
            SimMXA LigaMX = new SimMXA();
            LigaMX.Show();
        }

        private void tablaAscMX_Click(object sender, EventArgs e)
        {
            TablaMXA LigaMX = new TablaMXA();
            LigaMX.Show();
        }

    }
}
