using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador.Class.Mex
{
    class SimTabla
    {
        private string Lame = "C:/APP Liga/Simulador/Simulador/img/Mex/ame.png"; private string Lpue = "C:/APP Liga/Simulador/Simulador/img/Mex/pue.png";
        private string Latl = "C:/APP Liga/Simulador/Simulador/img/Mex/atl.png"; private string Lpum = "C:/APP Liga/Simulador/Simulador/img/Mex/pum.png";
        private string Lcaz = "C:/APP Liga/Simulador/Simulador/img/Mex/caz.png"; private string Lqro = "C:/APP Liga/Simulador/Simulador/img/Mex/qro.png";
        private string Lgua = "C:/APP Liga/Simulador/Simulador/img/Mex/gua.png"; private string Lsan = "C:/APP Liga/Simulador/Simulador/img/Mex/san.png";
        private string Lleo = "C:/APP Liga/Simulador/Simulador/img/Mex/leo.png"; private string Lsal = "C:/APP Liga/Simulador/Simulador/img/Mex/sal.png";
        private string Ljua = "C:/APP Liga/Simulador/Simulador/img/Mex/jua.png"; private string Ltig = "C:/APP Liga/Simulador/Simulador/img/Mex/tig.png";
        private string Lmon = "C:/APP Liga/Simulador/Simulador/img/Mex/mon.png"; private string Ltij = "C:/APP Liga/Simulador/Simulador/img/Mex/tij.png";
        private string Lmty = "C:/APP Liga/Simulador/Simulador/img/Mex/mty.png"; private string Ltol = "C:/APP Liga/Simulador/Simulador/img/Mex/tol.png";
        private string Lnec = "C:/APP Liga/Simulador/Simulador/img/Mex/nec.png"; private string Lvrz = "C:/APP Liga/Simulador/Simulador/img/Mex/vrz.png";
        private string Lpac = "C:/APP Liga/Simulador/Simulador/img/Mex/pac.png";

        datos Odatos = new datos();
        datos Odato = new datos();        

        public SimTabla()
        {
            
        }

        public void TablaJugada(DataGridView T, Label Torneo, Label Jornada)
        {
            Odatos.consultar2("TablaJ");
            T.DataSource = Odatos.ds.Tables["TablaJ"];
            T.Refresh();

            int total = 0;

            if (T.Rows[0].Cells[0].Value.ToString() == "Apertura")
            {
                for (int j = 1; j <= 19; j++)
                {
                    total += Convert.ToInt32(T.Rows[0].Cells[j].Value is DBNull ? 0 : T.Rows[0].Cells[j].Value);
                    Torneo.Text = "Simulación de Apertura ";
                    Jornada.Text = "Jornada " + (total + 1);
                }
            }
        }

        public void LoadImg(DataGridView TablaG)
        {
            Odatos.general("tmpGeneral");
            TablaG.DataSource = Odatos.ds.Tables["tmpGeneral"];
            TablaG.Refresh();

            #region Logo y Posiciones
            for (int i = 0; i <= 18; i++)
            {
                TablaG.Rows[i].Cells[0].Value = i + 1;

                if ((i % 2) == 0)
                    TablaG.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(225,226,227);

                if (TablaG.Rows[i].Cells[2].Value.ToString() == "América")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Lame);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "Atlas")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Latl);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "A. San Luis")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Lsal);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "Cruz Azul")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Lcaz);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "Guadalajara")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Lgua);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "León")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Lleo);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "Juárez")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Ljua);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "Morelia")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Lmon);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "Monterrey")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Lmty);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "Necaxa")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Lnec);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "Pachuca")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Lpac);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "Puebla")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Lpue);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "Querétaro")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Lqro);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "Santos")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Lsan);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "Tigres")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Ltig);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "Tijuana")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Ltij);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "Toluca")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Ltol);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "UNAM")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Lpum);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "Veracruz")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Lvrz);
            }     
           #endregion
        }

        public void Suma(DataGridView TG, DataGridView TE, DataGridView TO, DataGridView TGF, DataGridView TGC)
        {
            Odatos.consultar2("tmpGana");
            TG.DataSource = Odatos.ds.Tables["tmpGana"];
            TG.Refresh();
            Odatos.consultar2("tmpEmpate");
            TE.DataSource = Odatos.ds.Tables["tmpEmpate"];
            TE.Refresh();
            Odatos.consultar2("tmpPierde");
            TO.DataSource = Odatos.ds.Tables["tmpPierde"];
            TO.Refresh();
            Odatos.consultar2("tmpGF");
            TGF.DataSource = Odatos.ds.Tables["tmpGF"];
            TGF.Refresh();
            Odatos.consultar2("tmpGC");
            TGC.DataSource = Odatos.ds.Tables["tmpGC"];
            TGC.Refresh();

            #region Suma de Ganados
            for (int i = 0; i <= 18; i++)
            {
                int toG = 0, toE = 0, toP = 0, toGF = 0, toGC = 0;
                for (int j = 1; j <= 18; j++)
                {
                    if (TG.Rows[i].Cells[0].Value.ToString() == "América" && TE.Rows[i].Cells[0].Value.ToString() == "América" &&
                        TO.Rows[i].Cells[0].Value.ToString() == "América" && TGF.Rows[i].Cells[0].Value.ToString() == "América" && TGC.Rows[i].Cells[0].Value.ToString() == "América")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "América");
                        Odato.aEdPar("tmpGeneral", "E", toE, "América");
                        Odato.aEdPar("tmpGeneral", "P", toP, "América");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "América");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "América");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "A. San Luis" && TE.Rows[i].Cells[0].Value.ToString() == "A. San Luis" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "A. San Luis" && TGF.Rows[i].Cells[0].Value.ToString() == "A. San Luis" && TGC.Rows[i].Cells[0].Value.ToString() == "A. San Luis")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "A. San Luis");
                        Odato.aEdPar("tmpGeneral", "E", toE, "A. San Luis");
                        Odato.aEdPar("tmpGeneral", "P", toP, "A. San Luis");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "A. San Luis");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "A. San Luis");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Atlas" && TE.Rows[i].Cells[0].Value.ToString() == "Atlas" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Atlas" && TGF.Rows[i].Cells[0].Value.ToString() == "Atlas" && TGC.Rows[i].Cells[0].Value.ToString() == "Atlas")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Atlas");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Atlas");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Atlas");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Atlas");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Atlas");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Cruz Azul" && TE.Rows[i].Cells[0].Value.ToString() == "Cruz Azul" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Cruz Azul" && TGF.Rows[i].Cells[0].Value.ToString() == "Cruz Azul" && TGC.Rows[i].Cells[0].Value.ToString() == "Cruz Azul")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Cruz Azul");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Cruz Azul");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Cruz Azul");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Cruz Azul");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Cruz Azul");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Guadalajara" && TE.Rows[i].Cells[0].Value.ToString() == "Guadalajara" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Guadalajara" && TGF.Rows[i].Cells[0].Value.ToString() == "Guadalajara" && TGC.Rows[i].Cells[0].Value.ToString() == "Guadalajara")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Guadalajara");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Guadalajara");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Guadalajara");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Guadalajara");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Guadalajara");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "León" && TE.Rows[i].Cells[0].Value.ToString() == "León" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "León" && TGF.Rows[i].Cells[0].Value.ToString() == "León" && TGC.Rows[i].Cells[0].Value.ToString() == "León")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "León");
                        Odato.aEdPar("tmpGeneral", "E", toE, "León");
                        Odato.aEdPar("tmpGeneral", "P", toP, "León");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "León");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "León");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Juárez" && TE.Rows[i].Cells[0].Value.ToString() == "Juárez" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Juárez" && TGF.Rows[i].Cells[0].Value.ToString() == "Juárez" && TGC.Rows[i].Cells[0].Value.ToString() == "Juárez")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Juárez");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Juárez");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Juárez");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Juárez");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Juárez");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Morelia" && TE.Rows[i].Cells[0].Value.ToString() == "Morelia" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Morelia" && TGF.Rows[i].Cells[0].Value.ToString() == "Morelia" && TGC.Rows[i].Cells[0].Value.ToString() == "Morelia")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Morelia");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Morelia");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Morelia");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Morelia");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Morelia");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Monterrey" && TE.Rows[i].Cells[0].Value.ToString() == "Monterrey" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Monterrey" && TGF.Rows[i].Cells[0].Value.ToString() == "Monterrey" && TGC.Rows[i].Cells[0].Value.ToString() == "Monterrey")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Monterrey");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Monterrey");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Monterrey");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Monterrey");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Monterrey");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Necaxa" && TE.Rows[i].Cells[0].Value.ToString() == "Necaxa" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Necaxa" && TGF.Rows[i].Cells[0].Value.ToString() == "Necaxa" && TGC.Rows[i].Cells[0].Value.ToString() == "Necaxa")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Necaxa");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Necaxa");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Necaxa");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Necaxa");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Necaxa");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Pachuca" && TE.Rows[i].Cells[0].Value.ToString() == "Pachuca" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Pachuca" && TGF.Rows[i].Cells[0].Value.ToString() == "Pachuca" && TGC.Rows[i].Cells[0].Value.ToString() == "Pachuca")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Pachuca");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Pachuca");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Pachuca");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Pachuca");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Pachuca");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Puebla" && TE.Rows[i].Cells[0].Value.ToString() == "Puebla" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Puebla" && TGF.Rows[i].Cells[0].Value.ToString() == "Puebla" && TGC.Rows[i].Cells[0].Value.ToString() == "Puebla")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Puebla");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Puebla");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Puebla");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Puebla");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Puebla");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Querétaro" && TE.Rows[i].Cells[0].Value.ToString() == "Querétaro" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Querétaro" && TGF.Rows[i].Cells[0].Value.ToString() == "Querétaro" && TGC.Rows[i].Cells[0].Value.ToString() == "Querétaro")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Querétaro");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Querétaro");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Querétaro");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Querétaro");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Querétaro");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Santos" && TE.Rows[i].Cells[0].Value.ToString() == "Santos" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Santos" && TGF.Rows[i].Cells[0].Value.ToString() == "Santos" && TGC.Rows[i].Cells[0].Value.ToString() == "Santos")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Santos");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Santos");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Santos");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Santos");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Santos");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Tigres" && TE.Rows[i].Cells[0].Value.ToString() == "Tigres" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Tigres" && TGF.Rows[i].Cells[0].Value.ToString() == "Tigres" && TGC.Rows[i].Cells[0].Value.ToString() == "Tigres")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Tigres");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Tigres");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Tigres");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Tigres");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Tigres");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Tijuana" && TE.Rows[i].Cells[0].Value.ToString() == "Tijuana" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Tijuana" && TGF.Rows[i].Cells[0].Value.ToString() == "Tijuana" && TGC.Rows[i].Cells[0].Value.ToString() == "Tijuana")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Tijuana");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Tijuana");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Tijuana");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Tijuana");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Tijuana");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Toluca" && TE.Rows[i].Cells[0].Value.ToString() == "Toluca" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Toluca" && TGF.Rows[i].Cells[0].Value.ToString() == "Toluca" && TGC.Rows[i].Cells[0].Value.ToString() == "Toluca")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Toluca");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Toluca");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Toluca");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Toluca");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Toluca");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "UNAM" && TE.Rows[i].Cells[0].Value.ToString() == "UNAM" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "UNAM" && TGF.Rows[i].Cells[0].Value.ToString() == "UNAM" && TGC.Rows[i].Cells[0].Value.ToString() == "UNAM")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "UNAM");
                        Odato.aEdPar("tmpGeneral", "E", toE, "UNAM");
                        Odato.aEdPar("tmpGeneral", "P", toP, "UNAM");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "UNAM");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "UNAM");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Veracruz" && TE.Rows[i].Cells[0].Value.ToString() == "Veracruz" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Veracruz" && TGF.Rows[i].Cells[0].Value.ToString() == "Veracruz" && TGC.Rows[i].Cells[0].Value.ToString() == "Veracruz")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Veracruz");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Veracruz");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Veracruz");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Veracruz");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Veracruz");
                    }
                }
            }
            #endregion
        }
        
        public void SumPartidos(DataGridView TP)
        {
            Odatos.consultar2("tmpGeneral");
            TP.DataSource = Odatos.ds.Tables["tmpGeneral"];
            TP.Refresh();

            #region Suma de Goles a Favor
            for (int i = 0; i <= 18; i++)
            {
                int total = 0;
                for (int j = 2; j < 5; j++)
                {
                    if (TP.Rows[i].Cells[0].Value.ToString() == "América")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "América");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "A. San Luis")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "A. San Luis");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Atlas")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Atlas");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Cruz Azul")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Cruz Azul");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Guadalajara")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Guadalajara");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "León")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "León");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Juárez")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Juárez");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Morelia")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Morelia");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Monterrey")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Monterrey");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Necaxa")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Necaxa");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Pachuca")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Pachuca");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Puebla")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Puebla");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Querétaro")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Querétaro");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Santos")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Santos");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Tigres")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Tigres");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Tijuana")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Tijuana");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Toluca")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Toluca");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "UNAM")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "UNAM");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Veracruz")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Veracruz");
                    }
                }
            }
            #endregion
        }
        
        public void SumDG(DataGridView TP)
        {
            Odatos.consultar2("tmpGeneral");
            TP.DataSource = Odatos.ds.Tables["tmpGeneral"];
            TP.Refresh();

            #region Diferencia de Goles
            for (int i = 0; i <= 18; i++)
            {
                int total = 0;
                if (TP.Rows[i].Cells[0].Value.ToString() == "América")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "América");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "A. San Luis")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "A. San Luis");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Atlas")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Atlas");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Cruz Azul")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Cruz Azul");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Guadalajara")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Guadalajara");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "León")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "León");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Juárez")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Juárez");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Morelia")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Morelia");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Monterrey")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Monterrey");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Necaxa")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Necaxa");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Pachuca")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Pachuca");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Puebla")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Puebla");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Querétaro")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Querétaro");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Santos")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Santos");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Tigres")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Tigres");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Tijuana")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Tijuana");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Toluca")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Toluca");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "UNAM")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "UNAM");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Veracruz")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Veracruz");
                }
            }
            #endregion
        }

        public void SumPTS(DataGridView TP)
        {
            Odatos.consultar2("tmpGeneral");
            TP.DataSource = Odatos.ds.Tables["tmpGeneral"];
            TP.Refresh();

            #region Suma de Puntos
            for (int i = 0; i <= 18; i++)
            {
                int total = 0;
                if (TP.Rows[i].Cells[0].Value.ToString() == "América")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "América");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "A. San Luis")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "A. San Luis");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Atlas")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Atlas");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Cruz Azul")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Cruz Azul");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Guadalajara")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Guadalajara");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "León")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "León");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Juárez")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Juárez");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Morelia")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Morelia");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Monterrey")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Monterrey");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Necaxa")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Necaxa");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Pachuca")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Pachuca");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Puebla")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Puebla");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Querétaro")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Querétaro");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Santos")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Santos");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Tigres")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Tigres");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Tijuana")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Tijuana");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Toluca")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Toluca");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "UNAM")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "UNAM");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Veracruz")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Veracruz");
                }
            }
            #endregion
        }

    }
}
