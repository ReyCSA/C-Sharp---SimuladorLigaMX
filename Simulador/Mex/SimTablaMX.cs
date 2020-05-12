using Simulador.Class.Mex;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador.Simulador.Mex
{
    public partial class SimTablaMX : Form
    {
        private string Lliga = "C:/APP Liga/Simulador/Simulador/img/Mex/LigaMX.png";
        cnx OReload = new cnx();
        SimTabla OSimtabla = new SimTabla();

        public SimTablaMX()
        {
            InitializeComponent();
        }

        private void SimTablaMX_Load(object sender, EventArgs e)
        {            
            pbLiga.Image = Image.FromFile(Lliga);
            OSimtabla.LoadImg(TG);
            OSimtabla.TablaJugada(TablaJ, lblTorneo, lblJornada);
        }

        private void SimTablaMX_FormClosing(object sender, FormClosingEventArgs e)
        {
            OReload.LimpiarBD("tmpGF", "GF");
            OReload.LimpiarBD("tmpGC", "GC");
            OReload.LimpiarBD("tmpGana", "Gana");
            OReload.LimpiarBD("tmpEmpate", "Empate");
            OReload.LimpiarBD("tmpPierde", "Pierde");
            OReload.LimpiarBD("tmpPartidos", "Partidos");
            OReload.LimpiarBD("tmpGeneral", "general");

        }
    }
}
