﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.html;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using Simulador.Class.MexA;


namespace Simulador.Simulador.MexA
{
    public partial class SimMXA : Form
    {

        datosA Odatos = new datosA();
        cnxA OReload = new cnxA();
        imgsA Oimg = new imgsA();
        PartidosA Opartido = new PartidosA();
        TablaGA Otabla = new TablaGA();
        SimTablaA OSimtabla = new SimTablaA();

        public SimMXA()
        {
            InitializeComponent();
        }

        #region No editar
        #region Validar Cajas
        private void txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Regex.IsMatch(e.KeyChar.ToString(), @"[p]"))
                e.Handled = false;
            else if (Regex.IsMatch(e.KeyChar.ToString(), @"[P]"))
                e.Handled = false;
            else
                e.Handled = true;
        }
        #endregion
        
        #region Habilitar "Calcular"
        private void txb_TextChanged(object sender, EventArgs e)
        {
            if (txbL1.Text != "" && txbL4.Text != "" && txbL7.Text != "" && txbV1.Text != "" && txbV4.Text != "" && txbV7.Text != "" &&
                txbL2.Text != "" && txbL5.Text != "" &&
                txbL3.Text != "" && txbL6.Text != "") btnCalcular.Enabled = true;
            else btnCalcular.Enabled = false;
        }
        #endregion        

        #region Simular
        public void Indicador()
        {
            #region Indicador
            if (txbL1.Enabled == true && txbV1.Enabled == true)
            {
                if (Convert.ToInt32(txbL1.Text) > Convert.ToInt32(txbV1.Text)) R1.Text = "L";
                else if (Convert.ToInt32(txbL1.Text) == Convert.ToInt32(txbV1.Text)) R1.Text = "E";
                else if (Convert.ToInt32(txbL1.Text) < Convert.ToInt32(txbV1.Text)) R1.Text = "V";
            }
            if (txbL2.Enabled == true && txbV2.Enabled == true)
            {
                if (Convert.ToInt32(txbL2.Text) > Convert.ToInt32(txbV2.Text)) R2.Text = "L";
                else if (Convert.ToInt32(txbL2.Text) == Convert.ToInt32(txbV2.Text)) R2.Text = "E";
                else if (Convert.ToInt32(txbL2.Text) < Convert.ToInt32(txbV2.Text)) R2.Text = "V";
            }
            if (txbL3.Enabled == true && txbV3.Enabled == true)
            {
                if (Convert.ToInt32(txbL3.Text) > Convert.ToInt32(txbV3.Text)) R3.Text = "L";
                else if (Convert.ToInt32(txbL3.Text) == Convert.ToInt32(txbV3.Text)) R3.Text = "E";
                else if (Convert.ToInt32(txbL3.Text) < Convert.ToInt32(txbV3.Text)) R3.Text = "V";
            }
            if (txbL4.Enabled == true && txbV4.Enabled == true)
            {
                if (Convert.ToInt32(txbL4.Text) > Convert.ToInt32(txbV4.Text)) R4.Text = "L";
                else if (Convert.ToInt32(txbL4.Text) == Convert.ToInt32(txbV4.Text)) R4.Text = "E";
                else if (Convert.ToInt32(txbL4.Text) < Convert.ToInt32(txbV4.Text)) R4.Text = "V";
            }
            if (txbL5.Enabled == true && txbV5.Enabled == true)
            {
                if (Convert.ToInt32(txbL5.Text) > Convert.ToInt32(txbV5.Text)) R5.Text = "L";
                else if (Convert.ToInt32(txbL5.Text) == Convert.ToInt32(txbV5.Text)) R5.Text = "E";
                else if (Convert.ToInt32(txbL5.Text) < Convert.ToInt32(txbV5.Text)) R5.Text = "V";
            }
            if (txbL6.Enabled == true && txbV6.Enabled == true)
            {
                if (Convert.ToInt32(txbL6.Text) > Convert.ToInt32(txbV6.Text)) R6.Text = "L";
                else if (Convert.ToInt32(txbL6.Text) == Convert.ToInt32(txbV6.Text)) R6.Text = "E";
                else if (Convert.ToInt32(txbL6.Text) < Convert.ToInt32(txbV6.Text)) R6.Text = "V";
            }
            if (txbL7.Enabled == true && txbV7.Enabled == true)
            {
                if (Convert.ToInt32(txbL7.Text) > Convert.ToInt32(txbV7.Text)) R7.Text = "L";
                else if (Convert.ToInt32(txbL7.Text) == Convert.ToInt32(txbV7.Text)) R7.Text = "E";
                else if (Convert.ToInt32(txbL7.Text) < Convert.ToInt32(txbV7.Text)) R7.Text = "V";
            }
            #endregion
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            #region Aleatorio
            Random alea = new Random();
            if (txbL1.Enabled == true && txbV1.Enabled == true) { txbL1.Text = Convert.ToString(alea.Next(0, 4)); txbV1.Text = Convert.ToString(alea.Next(0, 4)); }
            if (txbL2.Enabled == true && txbV2.Enabled == true) { txbL2.Text = Convert.ToString(alea.Next(0, 4)); txbV2.Text = Convert.ToString(alea.Next(0, 4)); }
            if (txbL3.Enabled == true && txbV3.Enabled == true) { txbL3.Text = Convert.ToString(alea.Next(0, 4)); txbV3.Text = Convert.ToString(alea.Next(0, 4)); }
            if (txbL4.Enabled == true && txbV4.Enabled == true) { txbL4.Text = Convert.ToString(alea.Next(0, 4)); txbV4.Text = Convert.ToString(alea.Next(0, 4)); }
            if (txbL5.Enabled == true && txbV5.Enabled == true) { txbL5.Text = Convert.ToString(alea.Next(0, 4)); txbV5.Text = Convert.ToString(alea.Next(0, 4)); }
            if (txbL6.Enabled == true && txbV6.Enabled == true) { txbL6.Text = Convert.ToString(alea.Next(0, 4)); txbV6.Text = Convert.ToString(alea.Next(0, 4)); }
            if (txbL7.Enabled == true && txbV7.Enabled == true) { txbL7.Text = Convert.ToString(alea.Next(0, 4)); txbV7.Text = Convert.ToString(alea.Next(0, 4)); }            
            #endregion

            btnCalcular.Enabled = true; Indicador();
        }
        #endregion

        #region Limpiar
        public void Limpiar()
        {
            txbL1.Clear(); txbV1.Clear(); txbL2.Clear(); txbV2.Clear(); txbL3.Clear(); txbV3.Clear();
            txbL4.Clear(); txbV4.Clear(); txbL5.Clear(); txbV5.Clear(); txbL6.Clear(); txbV6.Clear();
            txbL7.Clear(); txbV7.Clear(); 
            btnCalcular.Enabled = false;
            R1.Text = ""; R6.Text = ""; R2.Text = ""; R7.Text = ""; R3.Text = ""; R4.Text = ""; R5.Text = "";
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        #endregion 

        #region ComboBox
        public void ResetImage()
        {
            this.pbL1.Image = null; this.pbV1.Image = null; lblF1.Text = "Dia. dd/MM"; lblH1.Text = "HH:mm hrs";
            this.pbL2.Image = null; this.pbV2.Image = null; lblF2.Text = "Dia. dd/MM"; lblH2.Text = "HH:mm hrs";
            this.pbL3.Image = null; this.pbV3.Image = null; lblF3.Text = "Dia. dd/MM"; lblH3.Text = "HH:mm hrs";
            this.pbL4.Image = null; this.pbV4.Image = null; lblF4.Text = "Dia. dd/MM"; lblH4.Text = "HH:mm hrs";
            this.pbL5.Image = null; this.pbV5.Image = null; lblF5.Text = "Dia. dd/MM"; lblH5.Text = "HH:mm hrs";
            this.pbL6.Image = null; this.pbV6.Image = null; lblF6.Text = "Dia. dd/MM"; lblH6.Text = "HH:mm hrs";
            this.pbL7.Image = null; this.pbV7.Image = null; lblF7.Text = "Dia. dd/MM"; lblH7.Text = "HH:mm hrs";
            btnSimular.Enabled = false;
            btnLimpiar.Enabled = false;
            btnCalcular.Enabled = false;
        }

        private void cmbJornada_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblJornada.Text = cmbJornada.SelectedItem.ToString();
            ResetImage();
        }

        private void cmbTorneo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTorneo.Text = cmbTorneo.SelectedItem.ToString();
            ResetImage();
        }
        #endregion
        #endregion

        #region Habilita Label
        public void Enable()
        {
            ale.Enabled = true; atl.Enabled = true; caf.Enabled = true; cim.Enabled = true; zac.Enabled = true; cel.Enabled = true;
            cor.Enabled = true; dor.Enabled = true; lor.Enabled = true; min.Enabled = true; tam.Enabled = true; uae.Enabled = true;
            udg.Enabled = true; ven.Enabled = true;
        }
        #endregion

        #region  Iniciar Ventana
        private void SimMX_Load(object sender, EventArgs e)
        {
            string Lliga = "C:/APP Liga/Simulador/Simulador/img/Mex/LigaMX.png"; pbLiga.Image = System.Drawing.Image.FromFile(Lliga);

            btnSimular.Enabled = false; btnLimpiar.Enabled = false; btnCalcular.Enabled = false;

            this.cmbTorneo.Items.Add("Apertura"); this.cmbTorneo.Items.Add("Clausura");
            for (int i = 1; i <= 13; i++) this.cmbJornada.Items.Add("Jornada " + i);

            Opartido.TablaSim(TablaJ, cmbTorneo, cmbJornada);
        }
        #endregion

        #region Habilitar Simular y Limpiar
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0; count += 1;
                if (count == 1) { btnSimular.Enabled = true; btnLimpiar.Enabled = true; count = 0; }

                Oimg.Condicion(lblTorneo, lblJornada, Pjornada);
                Oimg.logos(Pjornada.Text, pbL1, pbL2, pbL3, pbL4, pbL5, pbL6, pbL7, pbV1, pbV2, pbV3, pbV4, pbV5, pbV6, pbV7, lblF1, lblF2, lblF3, lblF4, lblF5, lblF6, lblF7, lblH1, lblH2, lblH3, lblH4, lblH5, lblH6, lblH7);
                Opartido.Pendiente(TPen, Pjornada.Text, ale, atl, caf, cim, zac, cel, cor, dor, lor, min, tam, uae, udg, ven);
                Opartido.AsociarText(Pjornada.Text, ale, atl, caf, cim, zac, cel, cor, dor, lor, min, tam, uae, udg, ven, txbL1, txbL2, txbL3, txbL4, txbL5, txbL6, txbL7, txbV1, txbV2, txbV3, txbV4, txbV5, txbV6, txbV7, Cale, Cmin, Catl, Ctam, Ccaf, Cuae, Ccim, Cudg, Czac, Cven, Ccel, Ccor, Cdor, Clor);

                #region Habilitar Botones
                if (txbL1.Enabled == true && txbV1.Enabled == true && txbL2.Enabled == true && txbV2.Enabled == true && txbL3.Enabled == true && txbV3.Enabled == true && txbL4.Enabled == true && txbV4.Enabled == true && txbL5.Enabled == true && txbV5.Enabled == true && txbL6.Enabled == true && txbV6.Enabled == true && txbL7.Enabled == true && txbV7.Enabled == true)
                    btnConsultar.Enabled = false;
                else if (txbL1.Enabled == true && txbV1.Enabled == true || txbL2.Enabled == true && txbV2.Enabled == true || txbL3.Enabled == true && txbV3.Enabled == true || txbL4.Enabled == true && txbV4.Enabled == true || txbL5.Enabled == true && txbV5.Enabled == true || txbL6.Enabled == true && txbV6.Enabled == true || txbL7.Enabled == true && txbV7.Enabled == true)
                    btnConsultar.Enabled = true;
                else btnConsultar.Enabled = true;
                #endregion

                Limpiar();
            }
            catch
            {
                MessageBox.Show("Selecione: Torneo y Jornada");
            }
        }
        #endregion                   

        #region Boton agregar Pendiente
        private void btnPendiente_Click(object sender, EventArgs e)
        {
            try
            {
                Opartido.AsociarText(Pjornada.Text, ale, atl, caf, cim, zac, cel, cor, dor, lor, min, tam, uae, udg, ven, txbL1, txbL2, txbL3, txbL4, txbL5, txbL6, txbL7, txbV1, txbV2, txbV3, txbV4, txbV5, txbV6, txbV7, Cale, Cmin, Catl, Ctam, Ccaf, Cuae, Ccim, Cudg, Czac, Cven, Ccel, Ccor, Cdor, Clor);
                Opartido.ActPen(Pjornada, ale, atl, caf, cim, zac, cel, cor, dor, lor, min, tam, uae, udg, ven);
                Opartido.AsociarText(Pjornada.Text, ale, atl, caf, cim, zac, cel, cor, dor, lor, min, tam, uae, udg, ven, txbL1, txbL2, txbL3, txbL4, txbL5, txbL6, txbL7, txbV1, txbV2, txbV3, txbV4, txbV5, txbV6, txbV7, Cale, Cmin, Catl, Ctam, Ccaf, Cuae, Ccim, Cudg, Czac, Cven, Ccel, Ccor, Cdor, Clor);
                Limpiar();
                btnSimular.Enabled = false; btnLimpiar.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Hay campos vacios!");
            }
        }
        #endregion        

        #region Boton Guardar Resultados
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                Odatos.actTJ("TablaJ", Pjornada.Text, lblTorneo.Text);

                Opartido.AsociarText(Pjornada.Text, ale, atl, caf, cim, zac, cel, cor, dor, lor, min, tam, uae, udg, ven, txbL1, txbL2, txbL3, txbL4, txbL5, txbL6, txbL7, txbV1, txbV2, txbV3, txbV4, txbV5, txbV6, txbV7, Cale, Cmin, Catl, Ctam, Ccaf, Cuae, Ccim, Cudg, Czac, Cven, Ccel, Ccor, Cdor, Clor);
                Opartido.ActGF(Pjornada, ale, atl, caf, cim, zac, cel, cor, dor, lor, min, tam, uae, udg, ven, Cale, Cmin, Catl, Ctam, Ccaf, Cuae, Ccim, Cudg, Czac, Cven, Ccel, Ccor, Cdor, Clor);
                Opartido.AsociarText(Pjornada.Text, ale, atl, caf, cim, zac, cel, cor, dor, lor, min, tam, uae, udg, ven, txbL1, txbL2, txbL3, txbL4, txbL5, txbL6, txbL7, txbV1, txbV2, txbV3, txbV4, txbV5, txbV6, txbV7, Cale, Cmin, Catl, Ctam, Ccaf, Cuae, Ccim, Cudg, Czac, Cven, Ccel, Ccor, Cdor, Clor);
                Limpiar();

                Otabla.Suma(TG, TE, TO, TGF, TGC);
                Otabla.SumDG(TDG);
                Otabla.SumPTS(TPTS);
                Otabla.SumPartidos(TP);
                
                Cursor.Current = Cursors.Default;
               
                btnSimular.Enabled = false; btnLimpiar.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Hay campos vacios!");
            }
        }
        #endregion

        #region Boton Consultar Resultados
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                Opartido.AsociarText(Pjornada.Text, ale, atl, caf, cim, zac, cel, cor, dor, lor, min, tam, uae, udg, ven, txbL1, txbL2, txbL3, txbL4, txbL5, txbL6, txbL7, txbV1, txbV2, txbV3, txbV4, txbV5, txbV6, txbV7, Cale, Cmin, Catl, Ctam, Ccaf, Cuae, Ccim, Cudg, Czac, Cven, Ccel, Ccor, Cdor, Clor);
                Opartido.HabGF(TGF, Pjornada.Text, ale, atl, caf, cim, zac, cel, cor, dor, lor, min, tam, uae, udg, ven);
                Opartido.HabPen(TP, Pjornada.Text, ale, atl, caf, cim, zac, cel, cor, dor, lor, min, tam, uae, udg, ven);
                Opartido.AsociarLabel(Pjornada.Text, ale, atl, caf, cim, zac, cel, cor, dor, lor, min, tam, uae, udg, ven, txbL1, txbL2, txbL3, txbL4, txbL5, txbL6, txbL7, txbV1, txbV2, txbV3, txbV4, txbV5, txbV6, txbV7);

                Indicador();

                btnCalcular.Enabled = false;
                btnSimular.Enabled = false;
                
            }
            catch { /*MessageBox.Show("Hay campos vacios!");*/ }
        }
        #endregion

        #region Boton Calcular la Tabla
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Enable();
            Indicador();
            Opartido.AsociarText(Pjornada.Text, ale, atl, caf, cim, zac, cel, cor, dor, lor, min, tam, uae, udg, ven, txbL1, txbL2, txbL3, txbL4, txbL5, txbL6, txbL7, txbV1, txbV2, txbV3, txbV4, txbV5, txbV6, txbV7, Cale, Cmin, Catl, Ctam, Ccaf, Cuae, Ccim, Cudg, Czac, Cven, Ccel, Ccor, Cdor, Clor);
            Opartido.ActTmpGF(Pjornada, ale, atl, caf, cim, zac, cel, cor, dor, lor, min, tam, uae, udg, ven, Cale, Cmin, Catl, Ctam, Ccaf, Cuae, Ccim, Cudg, Czac, Cven, Ccel, Ccor, Cdor, Clor);
             
            OSimtabla.Suma(TG, TE, TO, TGF, TGC);
            OSimtabla.SumDG(TDG);
            OSimtabla.SumPTS(TPTS);
            OSimtabla.SumPartidos(TP);

            Cursor.Current = Cursors.Default;

            SimTablaMXA SimLigaMXA = new SimTablaMXA();
            SimLigaMXA.Show();
        }
        #endregion

        #region Reiniciar Tabla Temporal
        private void SimMX_FormClosing(object sender, FormClosingEventArgs e)
        {
            OReload.LimpiarBD("tmpGeneral", "general");
        }
        #endregion
    }
}
