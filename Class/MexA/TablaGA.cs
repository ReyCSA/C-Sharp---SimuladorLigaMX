using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador.Class.MexA
{
    class TablaGA
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

        public TablaGA()
        {
            
        }

        public void LoadImg(DataGridView TablaG)
        {
            Odatos.general("General");
            TablaG.DataSource = Odatos.ds.Tables["General"];
            TablaG.Refresh();

            #region Logo y Posiciones
            for (int i = 0; i <= 13; i++)
            {
                TablaG.Rows[i].Cells[0].Value = i + 1;

                if ((i % 2) == 0)
                    TablaG.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(225, 226, 227);

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

        public void SumPartidos(DataGridView TP)
        {
            Odatos.consultar2("General");
            TP.DataSource = Odatos.ds.Tables["General"];
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
                        Odato.aEdPar("general", "PJ", total, "Alebrijes");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Atlante")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "Atlante");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Cafetaleros")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "Cafetaleros");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Cimarrones")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "Cimarrones");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Zacatepec")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "Zacatepec");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Celaya")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "Celaya");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Correcaminos")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "Correcaminos");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Dorados")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "Dorados");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Loros Colima")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "Loros Colima");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Mineros")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "Mineros");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Tampico Madero")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "Tampico Madero");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Potros UAEM")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "Potros UAEM");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Leones Negros")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "Leones Negros");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Venados")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "Venados");
                    }
                }
            }
            #endregion
        }

        public void Suma(DataGridView TG, DataGridView TE, DataGridView TO, DataGridView TGF, DataGridView TGC)
        {
            Odatos.consultar2("Gana");
            TG.DataSource = Odatos.ds.Tables["Gana"];
            TG.Refresh();
            Odatos.consultar2("Empate");
            TE.DataSource = Odatos.ds.Tables["Empate"];
            TE.Refresh();
            Odatos.consultar2("Pierde");
            TO.DataSource = Odatos.ds.Tables["Pierde"];
            TO.Refresh();
            Odatos.consultar2("GF");
            TGF.DataSource = Odatos.ds.Tables["GF"];
            TGF.Refresh();
            Odatos.consultar2("GC");
            TGC.DataSource = Odatos.ds.Tables["GC"];
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
                        Odato.aEdPar("general", "G", toG, "Alebrijes");
                        Odato.aEdPar("general", "E", toE, "Alebrijes");
                        Odato.aEdPar("general", "P", toP, "Alebrijes");
                        Odato.aEdPar("general", "GF", toGF, "Alebrijes");
                        Odato.aEdPar("general", "GC", toGC, "Alebrijes");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Atlante" && TE.Rows[i].Cells[0].Value.ToString() == "Atlante" && TO.Rows[i].Cells[0].Value.ToString() == "Atlante" &&
                        TGF.Rows[i].Cells[0].Value.ToString() == "Atlante" && TGC.Rows[i].Cells[0].Value.ToString() == "Atlante")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "Atlante");
                        Odato.aEdPar("general", "E", toE, "Atlante");
                        Odato.aEdPar("general", "P", toP, "Atlante");
                        Odato.aEdPar("general", "GF", toGF, "Atlante");
                        Odato.aEdPar("general", "GC", toGC, "Atlante");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Cafetaleros" && TE.Rows[i].Cells[0].Value.ToString() == "Cafetaleros" && TO.Rows[i].Cells[0].Value.ToString() == "Cafetaleros" &&
                        TGF.Rows[i].Cells[0].Value.ToString() == "Cafetaleros" && TGC.Rows[i].Cells[0].Value.ToString() == "Cafetaleros")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "Cafetaleros");
                        Odato.aEdPar("general", "E", toE, "Cafetaleros");
                        Odato.aEdPar("general", "P", toP, "Cafetaleros");
                        Odato.aEdPar("general", "GF", toGF, "Cafetaleros");
                        Odato.aEdPar("general", "GC", toGC, "Cafetaleros");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Cimarrones" && TE.Rows[i].Cells[0].Value.ToString() == "Cimarrones" && TO.Rows[i].Cells[0].Value.ToString() == "Cimarrones" &&
                        TGF.Rows[i].Cells[0].Value.ToString() == "Cimarrones" && TGC.Rows[i].Cells[0].Value.ToString() == "Cimarrones")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "Cimarrones");
                        Odato.aEdPar("general", "E", toE, "Cimarrones");
                        Odato.aEdPar("general", "P", toP, "Cimarrones");
                        Odato.aEdPar("general", "GF", toGF, "Cimarrones");
                        Odato.aEdPar("general", "GC", toGC, "Cimarrones");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Zacatepec" && TE.Rows[i].Cells[0].Value.ToString() == "Zacatepec" && TO.Rows[i].Cells[0].Value.ToString() == "Zacatepec" &&
                        TGF.Rows[i].Cells[0].Value.ToString() == "Zacatepec" && TGC.Rows[i].Cells[0].Value.ToString() == "Zacatepec")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "Zacatepec");
                        Odato.aEdPar("general", "E", toE, "Zacatepec");
                        Odato.aEdPar("general", "P", toP, "Zacatepec");
                        Odato.aEdPar("general", "GF", toGF, "Zacatepec");
                        Odato.aEdPar("general", "GC", toGC, "Zacatepec");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Celaya" && TE.Rows[i].Cells[0].Value.ToString() == "Celaya" && TO.Rows[i].Cells[0].Value.ToString() == "Celaya" &&
                        TGF.Rows[i].Cells[0].Value.ToString() == "Celaya" && TGC.Rows[i].Cells[0].Value.ToString() == "Celaya")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "Celaya");
                        Odato.aEdPar("general", "E", toE, "Celaya");
                        Odato.aEdPar("general", "P", toP, "Celaya");
                        Odato.aEdPar("general", "GF", toGF, "Celaya");
                        Odato.aEdPar("general", "GC", toGC, "Celaya");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Correcaminos" && TE.Rows[i].Cells[0].Value.ToString() == "Correcaminos" && TO.Rows[i].Cells[0].Value.ToString() == "Correcaminos" &&
                        TGF.Rows[i].Cells[0].Value.ToString() == "Correcaminos" && TGC.Rows[i].Cells[0].Value.ToString() == "Correcaminos")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "Correcaminos");
                        Odato.aEdPar("general", "E", toE, "Correcaminos");
                        Odato.aEdPar("general", "P", toP, "Correcaminos");
                        Odato.aEdPar("general", "GF", toGF, "Correcaminos");
                        Odato.aEdPar("general", "GC", toGC, "Correcaminos");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Dorados" && TE.Rows[i].Cells[0].Value.ToString() == "Dorados" && TO.Rows[i].Cells[0].Value.ToString() == "Dorados" &&
                        TGF.Rows[i].Cells[0].Value.ToString() == "Dorados" && TGC.Rows[i].Cells[0].Value.ToString() == "Dorados")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "Dorados");
                        Odato.aEdPar("general", "E", toE, "Dorados");
                        Odato.aEdPar("general", "P", toP, "Dorados");
                        Odato.aEdPar("general", "GF", toGF, "Dorados");
                        Odato.aEdPar("general", "GC", toGC, "Dorados");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Loros Colima" && TE.Rows[i].Cells[0].Value.ToString() == "Loros Colima" && TO.Rows[i].Cells[0].Value.ToString() == "Loros Colima" &&
                        TGF.Rows[i].Cells[0].Value.ToString() == "Loros Colima" && TGC.Rows[i].Cells[0].Value.ToString() == "Loros Colima")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "Loros Colima");
                        Odato.aEdPar("general", "E", toE, "Loros Colima");
                        Odato.aEdPar("general", "P", toP, "Loros Colima");
                        Odato.aEdPar("general", "GF", toGF, "Loros Colima");
                        Odato.aEdPar("general", "GC", toGC, "Loros Colima");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Mineros" && TE.Rows[i].Cells[0].Value.ToString() == "Mineros" && TO.Rows[i].Cells[0].Value.ToString() == "Mineros" &&
                        TGF.Rows[i].Cells[0].Value.ToString() == "Mineros" && TGC.Rows[i].Cells[0].Value.ToString() == "Mineros")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "Mineros");
                        Odato.aEdPar("general", "E", toE, "Mineros");
                        Odato.aEdPar("general", "P", toP, "Mineros");
                        Odato.aEdPar("general", "GF", toGF, "Mineros");
                        Odato.aEdPar("general", "GC", toGC, "Mineros");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Tampico Madero" && TE.Rows[i].Cells[0].Value.ToString() == "Tampico Madero" && TO.Rows[i].Cells[0].Value.ToString() == "Tampico Madero" &&
                        TGF.Rows[i].Cells[0].Value.ToString() == "Tampico Madero" && TGC.Rows[i].Cells[0].Value.ToString() == "Tampico Madero")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "Tampico Madero");
                        Odato.aEdPar("general", "E", toE, "Tampico Madero");
                        Odato.aEdPar("general", "P", toP, "Tampico Madero");
                        Odato.aEdPar("general", "GF", toGF, "Tampico Madero");
                        Odato.aEdPar("general", "GC", toGC, "Tampico Madero");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Potros UAEM" && TE.Rows[i].Cells[0].Value.ToString() == "Potros UAEM" && TO.Rows[i].Cells[0].Value.ToString() == "Potros UAEM" &&
                        TGF.Rows[i].Cells[0].Value.ToString() == "Potros UAEM" && TGC.Rows[i].Cells[0].Value.ToString() == "Potros UAEM")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "Potros UAEM");
                        Odato.aEdPar("general", "E", toE, "Potros UAEM");
                        Odato.aEdPar("general", "P", toP, "Potros UAEM");
                        Odato.aEdPar("general", "GF", toGF, "Potros UAEM");
                        Odato.aEdPar("general", "GC", toGC, "Potros UAEM");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Leones Negros" && TE.Rows[i].Cells[0].Value.ToString() == "Leones Negros" && TO.Rows[i].Cells[0].Value.ToString() == "Leones Negros" &&
                        TGF.Rows[i].Cells[0].Value.ToString() == "Leones Negros" && TGC.Rows[i].Cells[0].Value.ToString() == "Leones Negros")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "Leones Negros");
                        Odato.aEdPar("general", "E", toE, "Leones Negros");
                        Odato.aEdPar("general", "P", toP, "Leones Negros");
                        Odato.aEdPar("general", "GF", toGF, "Leones Negros");
                        Odato.aEdPar("general", "GC", toGC, "Leones Negros");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Venados" && TE.Rows[i].Cells[0].Value.ToString() == "Venados" && TO.Rows[i].Cells[0].Value.ToString() == "Venados" &&
                        TGF.Rows[i].Cells[0].Value.ToString() == "Venados" && TGC.Rows[i].Cells[0].Value.ToString() == "Venados")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "Venados");
                        Odato.aEdPar("general", "E", toE, "Venados");
                        Odato.aEdPar("general", "P", toP, "Venados");
                        Odato.aEdPar("general", "GF", toGF, "Venados");
                        Odato.aEdPar("general", "GC", toGC, "Venados");
                    }
                }
            }
            #endregion
        }

        public void SumDG(DataGridView TP)
        {
            Odatos.consultar2("general");
            TP.DataSource = Odatos.ds.Tables["general"];
            TP.Refresh();

            #region Diferencia de Goles
            for (int i = 0; i <= 13; i++)
            {
                int total = 0;
                if (TP.Rows[i].Cells[0].Value.ToString() == "Alebrijes")
                {
                    total += Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Alebrijes");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Atlante")
                {
                    total += Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Atlante");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Cafetaleros")
                {
                    total += Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Cafetaleros");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Cimarrones")
                {
                    total += Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Cimarrones");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Zacatepec")
                {
                    total += Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Zacatepec");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Celaya")
                {
                    total += Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Celaya");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Correcaminos")
                {
                    total += Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Correcaminos");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Dorados")
                {
                    total += Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Dorados");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Loros Colima")
                {
                    total += Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Loros Colima");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Mineros")
                {
                    total += Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Mineros");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Tampico Madero")
                {
                    total += Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Tampico Madero");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Potros UAEM")
                {
                    total += Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Potros UAEM");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Leones Negros")
                {
                    total += Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Leones Negros");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Venados")
                {
                    total += Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Venados");
                }
            }
            #endregion
        }

        public void SumPTS(DataGridView TP)
        {
            Odatos.consultar2("general");
            TP.DataSource = Odatos.ds.Tables["general"];
            TP.Refresh();

            #region Suma de Puntos
            for (int i = 0; i <= 13; i++)
            {
                int total = 0;
                if (TP.Rows[i].Cells[0].Value.ToString() == "Alebrijes")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Alebrijes");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Atlante")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Atlante");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Cafetaleros")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Cafetaleros");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Cimarrones")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Cimarrones");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Zacatepec")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Zacatepec");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Celaya")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Celaya");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Correcaminos")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Correcaminos");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Dorados")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Dorados");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Loros Colima")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Loros Colima");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Mineros")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Mineros");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Tampico Madero")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Tampico Madero");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Potros UAEM")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Potros UAEM");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Leones Negros")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Leones Negros");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Venados")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Venados");
                }
            }
            #endregion
        }


    }
}
