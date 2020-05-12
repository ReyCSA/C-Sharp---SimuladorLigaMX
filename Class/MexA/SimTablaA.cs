using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador.Class.MexA
{
    class SimTablaA
    {
        #region Variables Logos
        private string Lale = "C:/APP Liga/Simulador/Simulador/img/MexA/ale.png"; private string Ltam = "C:/APP Liga/Simulador/Simulador/img/MexA/tam.png";
        private string Latl = "C:/APP Liga/Simulador/Simulador/img/MexA/atl.png"; private string Luae = "C:/APP Liga/Simulador/Simulador/img/MexA/uae.png";
        private string Lcaf = "C:/APP Liga/Simulador/Simulador/img/MexA/caf.png"; private string Ludg = "C:/APP Liga/Simulador/Simulador/img/MexA/udg.png";
        private string Lcim = "C:/APP Liga/Simulador/Simulador/img/MexA/cim.png"; private string Lven = "C:/APP Liga/Simulador/Simulador/img/MexA/ven.png";
        private string Lzac = "C:/APP Liga/Simulador/Simulador/img/MexA/zac.png";
        private string Lcel = "C:/APP Liga/Simulador/Simulador/img/MexA/cel.png";
        private string Lcor = "C:/APP Liga/Simulador/Simulador/img/MexA/cor.png";
        private string Ldor = "C:/APP Liga/Simulador/Simulador/img/MexA/dor.png";
        private string Llor = "C:/APP Liga/Simulador/Simulador/img/MexA/lor.png";
        private string Lmin = "C:/APP Liga/Simulador/Simulador/img/MexA/min.png";
        #endregion

        datosA Odatos = new datosA();
        datosA Odato = new datosA();        

        public SimTablaA()
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
                for (int j = 1; j <= 13; j++)
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
            for (int i = 0; i <= 13; i++)
            {
                TablaG.Rows[i].Cells[0].Value = i + 1;

                if ((i % 2) == 0)
                    TablaG.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(225,226,227);

                if (TablaG.Rows[i].Cells[2].Value.ToString() == "Alebrijes")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Lale);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "Atlante")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Latl);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "Cafetaleros")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Lcaf);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "Cimarrones")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Lcim);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "Zacatepec")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Lzac);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "Celaya")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Lcel);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "Correcaminos")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Lcor);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "Dorados")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Ldor);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "Loros Colima")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Llor);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "Mineros")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Lmin);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "Tampico Madero")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Ltam);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "Potros UAEM")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Luae);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "Leones Negros")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Ludg);
                else if (TablaG.Rows[i].Cells[2].Value.ToString() == "Venados")
                    TablaG.Rows[i].Cells[1].Value = Image.FromFile(Lven);
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

            #region Suma de Goles a Favor
            for (int i = 0; i <= 13; i++)
            {
                int toG = 0, toE = 0, toP = 0, toGF = 0, toGC = 0;
                for (int j = 1; j <= 13; j++)
                {
                    if (TG.Rows[i].Cells[0].Value.ToString() == "Alebrijes" && TE.Rows[i].Cells[0].Value.ToString() == "Alebrijes" && TO.Rows[i].Cells[0].Value.ToString() == "Alebrijes" &&
                        TGF.Rows[i].Cells[0].Value.ToString() == "Alebrijes" && TGC.Rows[i].Cells[0].Value.ToString() == "Alebrijes")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Alebrijes");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Alebrijes");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Alebrijes");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Alebrijes");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Alebrijes");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Atlante" && TE.Rows[i].Cells[0].Value.ToString() == "Atlante" && TO.Rows[i].Cells[0].Value.ToString() == "Atlante" &&
                        TGF.Rows[i].Cells[0].Value.ToString() == "Atlante" && TGC.Rows[i].Cells[0].Value.ToString() == "Atlante")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Atlante");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Atlante");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Atlante");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Atlante");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Atlante");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Cafetaleros" && TE.Rows[i].Cells[0].Value.ToString() == "Cafetaleros" && TO.Rows[i].Cells[0].Value.ToString() == "Cafetaleros" &&
                        TGF.Rows[i].Cells[0].Value.ToString() == "Cafetaleros" && TGC.Rows[i].Cells[0].Value.ToString() == "Cafetaleros")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Cafetaleros");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Cafetaleros");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Cafetaleros");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Cafetaleros");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Cafetaleros");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Cimarrones" && TE.Rows[i].Cells[0].Value.ToString() == "Cimarrones" && TO.Rows[i].Cells[0].Value.ToString() == "Cimarrones" &&
                        TGF.Rows[i].Cells[0].Value.ToString() == "Cimarrones" && TGC.Rows[i].Cells[0].Value.ToString() == "Cimarrones")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Cimarrones");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Cimarrones");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Cimarrones");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Cimarrones");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Cimarrones");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Zacatepec" && TE.Rows[i].Cells[0].Value.ToString() == "Zacatepec" && TO.Rows[i].Cells[0].Value.ToString() == "Zacatepec" &&
                        TGF.Rows[i].Cells[0].Value.ToString() == "Zacatepec" && TGC.Rows[i].Cells[0].Value.ToString() == "Zacatepec")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Zacatepec");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Zacatepec");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Zacatepec");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Zacatepec");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Zacatepec");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Celaya" && TE.Rows[i].Cells[0].Value.ToString() == "Celaya" && TO.Rows[i].Cells[0].Value.ToString() == "Celaya" &&
                        TGF.Rows[i].Cells[0].Value.ToString() == "Celaya" && TGC.Rows[i].Cells[0].Value.ToString() == "Celaya")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Celaya");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Celaya");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Celaya");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Celaya");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Celaya");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Correcaminos" && TE.Rows[i].Cells[0].Value.ToString() == "Correcaminos" && TO.Rows[i].Cells[0].Value.ToString() == "Correcaminos" &&
                        TGF.Rows[i].Cells[0].Value.ToString() == "Correcaminos" && TGC.Rows[i].Cells[0].Value.ToString() == "Correcaminos")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Correcaminos");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Correcaminos");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Correcaminos");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Correcaminos");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Correcaminos");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Dorados" && TE.Rows[i].Cells[0].Value.ToString() == "Dorados" && TO.Rows[i].Cells[0].Value.ToString() == "Dorados" &&
                        TGF.Rows[i].Cells[0].Value.ToString() == "Dorados" && TGC.Rows[i].Cells[0].Value.ToString() == "Dorados")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Dorados");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Dorados");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Dorados");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Dorados");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Dorados");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Loros Colima" && TE.Rows[i].Cells[0].Value.ToString() == "Loros Colima" && TO.Rows[i].Cells[0].Value.ToString() == "Loros Colima" &&
                        TGF.Rows[i].Cells[0].Value.ToString() == "Loros Colima" && TGC.Rows[i].Cells[0].Value.ToString() == "Loros Colima")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Loros Colima");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Loros Colima");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Loros Colima");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Loros Colima");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Loros Colima");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Mineros" && TE.Rows[i].Cells[0].Value.ToString() == "Mineros" && TO.Rows[i].Cells[0].Value.ToString() == "Mineros" &&
                        TGF.Rows[i].Cells[0].Value.ToString() == "Mineros" && TGC.Rows[i].Cells[0].Value.ToString() == "Mineros")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Mineros");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Mineros");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Mineros");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Mineros");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Mineros");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Tampico Madero" && TE.Rows[i].Cells[0].Value.ToString() == "Tampico Madero" && TO.Rows[i].Cells[0].Value.ToString() == "Tampico Madero" &&
                        TGF.Rows[i].Cells[0].Value.ToString() == "Tampico Madero" && TGC.Rows[i].Cells[0].Value.ToString() == "Tampico Madero")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Tampico Madero");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Tampico Madero");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Tampico Madero");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Tampico Madero");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Tampico Madero");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Potros UAEM" && TE.Rows[i].Cells[0].Value.ToString() == "Potros UAEM" && TO.Rows[i].Cells[0].Value.ToString() == "Potros UAEM" &&
                        TGF.Rows[i].Cells[0].Value.ToString() == "Potros UAEM" && TGC.Rows[i].Cells[0].Value.ToString() == "Potros UAEM")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Potros UAEM");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Potros UAEM");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Potros UAEM");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Potros UAEM");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Potros UAEM");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Leones Negros" && TE.Rows[i].Cells[0].Value.ToString() == "Leones Negros" && TO.Rows[i].Cells[0].Value.ToString() == "Leones Negros" &&
                        TGF.Rows[i].Cells[0].Value.ToString() == "Leones Negros" && TGC.Rows[i].Cells[0].Value.ToString() == "Leones Negros")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Leones Negros");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Leones Negros");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Leones Negros");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Leones Negros");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Leones Negros");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Venados" && TE.Rows[i].Cells[0].Value.ToString() == "Venados" && TO.Rows[i].Cells[0].Value.ToString() == "Venados" &&
                        TGF.Rows[i].Cells[0].Value.ToString() == "Venados" && TGC.Rows[i].Cells[0].Value.ToString() == "Venados")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "G", toG, "Venados");
                        Odato.aEdPar("tmpGeneral", "E", toE, "Venados");
                        Odato.aEdPar("tmpGeneral", "P", toP, "Venados");
                        Odato.aEdPar("tmpGeneral", "GF", toGF, "Venados");
                        Odato.aEdPar("tmpGeneral", "GC", toGC, "Venados");
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

            #region Suma de Partidos
            for (int i = 0; i <= 13; i++)
            {
                int total = 0;
                for (int j = 2; j < 5; j++)
                {
                    if (TP.Rows[i].Cells[0].Value.ToString() == "Alebrijes")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Alebrijes");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Atlante")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Atlante");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Cafetaleros")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Cafetaleros");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Cimarrones")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Cimarrones");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Zacatepec")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Zacatepec");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Celaya")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Celaya");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Correcaminos")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Correcaminos");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Dorados")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Dorados");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Loros Colima")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Loros Colima");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Mineros")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Mineros");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Tampico Madero")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Tampico Madero");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Potros UAEM")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Potros UAEM");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Leones Negros")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Leones Negros");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Venados")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("tmpGeneral", "PJ", total, "Venados");
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
            for (int i = 0; i <= 13; i++)
            {
                int total = 0;
                if (TP.Rows[i].Cells[0].Value.ToString() == "Alebrijes")
                {
                    total += Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Alebrijes");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Atlante")
                {
                    total += Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Atlante");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Cafetaleros")
                {
                    total += Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Cafetaleros");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Cimarrones")
                {
                    total += Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Cimarrones");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Zacatepec")
                {
                    total += Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Zacatepec");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Celaya")
                {
                    total += Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Celaya");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Correcaminos")
                {
                    total += Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Correcaminos");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Dorados")
                {
                    total += Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Dorados");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Loros Colima")
                {
                    total += Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Loros Colima");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Mineros")
                {
                    total += Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Mineros");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Tampico Madero")
                {
                    total += Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Tampico Madero");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Potros UAEM")
                {
                    total += Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Potros UAEM");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Leones Negros")
                {
                    total += Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Leones Negros");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Venados")
                {
                    total += Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("tmpGeneral", "DG", total, "Venados");
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
            for (int i = 0; i <= 13; i++)
            {
                int total = 0;
                if (TP.Rows[i].Cells[0].Value.ToString() == "Alebrijes")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Alebrijes");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Atlante")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Atlante");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Cafetaleros")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Cafetaleros");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Cimarrones")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Cimarrones");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Zacatepec")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Zacatepec");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Celaya")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Celaya");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Correcaminos")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Correcaminos");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Dorados")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Dorados");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Loros Colima")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Loros Colima");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Mineros")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Mineros");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Tampico Madero")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Tampico Madero");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Potros UAEM")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Potros UAEM");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Leones Negros")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Leones Negros");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Venados")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("tmpGeneral", "Pts", total, "Venados");
                }
            }
            #endregion
        }

    }
}
