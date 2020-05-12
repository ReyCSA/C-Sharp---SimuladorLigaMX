using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador.Class.Mex
{
    class TablaG
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

        public TablaG()
        {
            
        }

        public void LoadImg(DataGridView TablaG)
        {
            Odatos.general("General");
            TablaG.DataSource = Odatos.ds.Tables["General"];
            TablaG.Refresh();

            #region Logo y Posiciones
            for (int i = 0; i <= 18; i++)
            {
                TablaG.Rows[i].Cells[0].Value = i + 1;

                if ((i % 2) == 0)
                    TablaG.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(225, 226, 227);

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

            #region Suma de Ganados
            for (int i = 0; i <= 18; i++)
            {
                int toG = 0, toE = 0, toP = 0, toGF = 0, toGC = 0;
                for (int j = 1; j <= 19; j++)
                {
                    if (TG.Rows[i].Cells[0].Value.ToString() == "América" && TE.Rows[i].Cells[0].Value.ToString() == "América" &&
                        TO.Rows[i].Cells[0].Value.ToString() == "América" && TGF.Rows[i].Cells[0].Value.ToString() == "América" && TGC.Rows[i].Cells[0].Value.ToString() == "América")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "América");
                        Odato.aEdPar("general", "E", toE, "América");
                        Odato.aEdPar("general", "P", toP, "América");
                        Odato.aEdPar("general", "GF", toGF, "América");
                        Odato.aEdPar("general", "GC", toGC, "América");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "A. San Luis" && TE.Rows[i].Cells[0].Value.ToString() == "A. San Luis" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "A. San Luis" && TGF.Rows[i].Cells[0].Value.ToString() == "A. San Luis" && TGC.Rows[i].Cells[0].Value.ToString() == "A. San Luis")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "A. San Luis");
                        Odato.aEdPar("general", "E", toE, "A. San Luis");
                        Odato.aEdPar("general", "P", toP, "A. San Luis");
                        Odato.aEdPar("general", "GF", toGF, "A. San Luis");
                        Odato.aEdPar("general", "GC", toGC, "A. San Luis");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Atlas" && TE.Rows[i].Cells[0].Value.ToString() == "Atlas" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Atlas" && TGF.Rows[i].Cells[0].Value.ToString() == "Atlas" && TGC.Rows[i].Cells[0].Value.ToString() == "Atlas")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "Atlas");
                        Odato.aEdPar("general", "E", toE, "Atlas");
                        Odato.aEdPar("general", "P", toP, "Atlas");
                        Odato.aEdPar("general", "GF", toGF, "Atlas");
                        Odato.aEdPar("general", "GC", toGC, "Atlas");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Cruz Azul" && TE.Rows[i].Cells[0].Value.ToString() == "Cruz Azul" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Cruz Azul" && TGF.Rows[i].Cells[0].Value.ToString() == "Cruz Azul" && TGC.Rows[i].Cells[0].Value.ToString() == "Cruz Azul")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "Cruz Azul");
                        Odato.aEdPar("general", "E", toE, "Cruz Azul");
                        Odato.aEdPar("general", "P", toP, "Cruz Azul");
                        Odato.aEdPar("general", "GF", toGF, "Cruz Azul");
                        Odato.aEdPar("general", "GC", toGC, "Cruz Azul");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Guadalajara" && TE.Rows[i].Cells[0].Value.ToString() == "Guadalajara" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Guadalajara" && TGF.Rows[i].Cells[0].Value.ToString() == "Guadalajara" && TGC.Rows[i].Cells[0].Value.ToString() == "Guadalajara")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "Guadalajara");
                        Odato.aEdPar("general", "E", toE, "Guadalajara");
                        Odato.aEdPar("general", "P", toP, "Guadalajara");
                        Odato.aEdPar("general", "GF", toGF, "Guadalajara");
                        Odato.aEdPar("general", "GC", toGC, "Guadalajara");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "León" && TE.Rows[i].Cells[0].Value.ToString() == "León" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "León" && TGF.Rows[i].Cells[0].Value.ToString() == "León" && TGC.Rows[i].Cells[0].Value.ToString() == "León")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "León");
                        Odato.aEdPar("general", "E", toE, "León");
                        Odato.aEdPar("general", "P", toP, "León");
                        Odato.aEdPar("general", "GF", toGF, "León");
                        Odato.aEdPar("general", "GC", toGC, "León");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Juárez" && TE.Rows[i].Cells[0].Value.ToString() == "Juárez" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Juárez" && TGF.Rows[i].Cells[0].Value.ToString() == "Juárez" && TGC.Rows[i].Cells[0].Value.ToString() == "Juárez")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "Juárez");
                        Odato.aEdPar("general", "E", toE, "Juárez");
                        Odato.aEdPar("general", "P", toP, "Juárez");
                        Odato.aEdPar("general", "GF", toGF, "Juárez");
                        Odato.aEdPar("general", "GC", toGC, "Juárez");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Morelia" && TE.Rows[i].Cells[0].Value.ToString() == "Morelia" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Morelia" && TGF.Rows[i].Cells[0].Value.ToString() == "Morelia" && TGC.Rows[i].Cells[0].Value.ToString() == "Morelia")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "Morelia");
                        Odato.aEdPar("general", "E", toE, "Morelia");
                        Odato.aEdPar("general", "P", toP, "Morelia");
                        Odato.aEdPar("general", "GF", toGF, "Morelia");
                        Odato.aEdPar("general", "GC", toGC, "Morelia");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Monterrey" && TE.Rows[i].Cells[0].Value.ToString() == "Monterrey" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Monterrey" && TGF.Rows[i].Cells[0].Value.ToString() == "Monterrey" && TGC.Rows[i].Cells[0].Value.ToString() == "Monterrey")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "Monterrey");
                        Odato.aEdPar("general", "E", toE, "Monterrey");
                        Odato.aEdPar("general", "P", toP, "Monterrey");
                        Odato.aEdPar("general", "GF", toGF, "Monterrey");
                        Odato.aEdPar("general", "GC", toGC, "Monterrey");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Necaxa" && TE.Rows[i].Cells[0].Value.ToString() == "Necaxa" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Necaxa" && TGF.Rows[i].Cells[0].Value.ToString() == "Necaxa" && TGC.Rows[i].Cells[0].Value.ToString() == "Necaxa")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "Necaxa");
                        Odato.aEdPar("general", "E", toE, "Necaxa");
                        Odato.aEdPar("general", "P", toP, "Necaxa");
                        Odato.aEdPar("general", "GF", toGF, "Necaxa");
                        Odato.aEdPar("general", "GC", toGC, "Necaxa");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Pachuca" && TE.Rows[i].Cells[0].Value.ToString() == "Pachuca" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Pachuca" && TGF.Rows[i].Cells[0].Value.ToString() == "Pachuca" && TGC.Rows[i].Cells[0].Value.ToString() == "Pachuca")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "Pachuca");
                        Odato.aEdPar("general", "E", toE, "Pachuca");
                        Odato.aEdPar("general", "P", toP, "Pachuca");
                        Odato.aEdPar("general", "GF", toGF, "Pachuca");
                        Odato.aEdPar("general", "GC", toGC, "Pachuca");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Puebla" && TE.Rows[i].Cells[0].Value.ToString() == "Puebla" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Puebla" && TGF.Rows[i].Cells[0].Value.ToString() == "Puebla" && TGC.Rows[i].Cells[0].Value.ToString() == "Puebla")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "Puebla");
                        Odato.aEdPar("general", "E", toE, "Puebla");
                        Odato.aEdPar("general", "P", toP, "Puebla");
                        Odato.aEdPar("general", "GF", toGF, "Puebla");
                        Odato.aEdPar("general", "GC", toGC, "Puebla");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Querétaro" && TE.Rows[i].Cells[0].Value.ToString() == "Querétaro" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Querétaro" && TGF.Rows[i].Cells[0].Value.ToString() == "Querétaro" && TGC.Rows[i].Cells[0].Value.ToString() == "Querétaro")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "Querétaro");
                        Odato.aEdPar("general", "E", toE, "Querétaro");
                        Odato.aEdPar("general", "P", toP, "Querétaro");
                        Odato.aEdPar("general", "GF", toGF, "Querétaro");
                        Odato.aEdPar("general", "GC", toGC, "Querétaro");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Santos" && TE.Rows[i].Cells[0].Value.ToString() == "Santos" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Santos" && TGF.Rows[i].Cells[0].Value.ToString() == "Santos" && TGC.Rows[i].Cells[0].Value.ToString() == "Santos")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "Santos");
                        Odato.aEdPar("general", "E", toE, "Santos");
                        Odato.aEdPar("general", "P", toP, "Santos");
                        Odato.aEdPar("general", "GF", toGF, "Santos");
                        Odato.aEdPar("general", "GC", toGC, "Santos");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Tigres" && TE.Rows[i].Cells[0].Value.ToString() == "Tigres" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Tigres" && TGF.Rows[i].Cells[0].Value.ToString() == "Tigres" && TGC.Rows[i].Cells[0].Value.ToString() == "Tigres")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "Tigres");
                        Odato.aEdPar("general", "E", toE, "Tigres");
                        Odato.aEdPar("general", "P", toP, "Tigres");
                        Odato.aEdPar("general", "GF", toGF, "Tigres");
                        Odato.aEdPar("general", "GC", toGC, "Tigres");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Tijuana" && TE.Rows[i].Cells[0].Value.ToString() == "Tijuana" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Tijuana" && TGF.Rows[i].Cells[0].Value.ToString() == "Tijuana" && TGC.Rows[i].Cells[0].Value.ToString() == "Tijuana")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "Tijuana");
                        Odato.aEdPar("general", "E", toE, "Tijuana");
                        Odato.aEdPar("general", "P", toP, "Tijuana");
                        Odato.aEdPar("general", "GF", toGF, "Tijuana");
                        Odato.aEdPar("general", "GC", toGC, "Tijuana");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Toluca" && TE.Rows[i].Cells[0].Value.ToString() == "Toluca" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Toluca" && TGF.Rows[i].Cells[0].Value.ToString() == "Toluca" && TGC.Rows[i].Cells[0].Value.ToString() == "Toluca")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "Toluca");
                        Odato.aEdPar("general", "E", toE, "Toluca");
                        Odato.aEdPar("general", "P", toP, "Toluca");
                        Odato.aEdPar("general", "GF", toGF, "Toluca");
                        Odato.aEdPar("general", "GC", toGC, "Toluca");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "UNAM" && TE.Rows[i].Cells[0].Value.ToString() == "UNAM" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "UNAM" && TGF.Rows[i].Cells[0].Value.ToString() == "UNAM" && TGC.Rows[i].Cells[0].Value.ToString() == "UNAM")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "UNAM");
                        Odato.aEdPar("general", "E", toE, "UNAM");
                        Odato.aEdPar("general", "P", toP, "UNAM");
                        Odato.aEdPar("general", "GF", toGF, "UNAM");
                        Odato.aEdPar("general", "GC", toGC, "UNAM");
                    }
                    else if (TG.Rows[i].Cells[0].Value.ToString() == "Veracruz" && TE.Rows[i].Cells[0].Value.ToString() == "Veracruz" &&
                             TO.Rows[i].Cells[0].Value.ToString() == "Veracruz" && TGF.Rows[i].Cells[0].Value.ToString() == "Veracruz" && TGC.Rows[i].Cells[0].Value.ToString() == "Veracruz")
                    {
                        toG += Convert.ToInt32(TG.Rows[i].Cells[j].Value is DBNull ? 0 : TG.Rows[i].Cells[j].Value);
                        toE += Convert.ToInt32(TE.Rows[i].Cells[j].Value is DBNull ? 0 : TE.Rows[i].Cells[j].Value);
                        toP += Convert.ToInt32(TO.Rows[i].Cells[j].Value is DBNull ? 0 : TO.Rows[i].Cells[j].Value);
                        toGF += Convert.ToInt32(TGF.Rows[i].Cells[j].Value is DBNull ? 0 : TGF.Rows[i].Cells[j].Value);
                        toGC += Convert.ToInt32(TGC.Rows[i].Cells[j].Value is DBNull ? 0 : TGC.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "G", toG, "Veracruz");
                        Odato.aEdPar("general", "E", toE, "Veracruz");
                        Odato.aEdPar("general", "P", toP, "Veracruz");
                        Odato.aEdPar("general", "GF", toGF, "Veracruz");
                        Odato.aEdPar("general", "GC", toGC, "Veracruz");
                    }
                }
            }
            #endregion
        }

        public void SumPartidos(DataGridView TP)
        {
            Odatos.consultar2("General");
            TP.DataSource = Odatos.ds.Tables["General"];
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
                        Odato.aEdPar("general", "PJ", total, "América");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "A. San Luis")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "A. San Luis");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Atlas")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "Atlas");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Cruz Azul")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "Cruz Azul");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Guadalajara")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "Guadalajara");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "León")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "León");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Juárez")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "Juárez");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Morelia")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "Morelia");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Monterrey")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "Monterrey");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Necaxa")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "Necaxa");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Pachuca")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "Pachuca");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Puebla")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "Puebla");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Querétaro")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "Querétaro");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Santos")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "Santos");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Tigres")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "Tigres");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Tijuana")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "Tijuana");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Toluca")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "Toluca");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "UNAM")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "UNAM");
                    }
                    else if (TP.Rows[i].Cells[0].Value.ToString() == "Veracruz")
                    {
                        total += Convert.ToInt32(TP.Rows[i].Cells[j].Value);
                        Odato.aEdPar("general", "PJ", total, "Veracruz");
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
            for (int i = 0; i <= 18; i++)
            {
                int total = 0;
                if (TP.Rows[i].Cells[0].Value.ToString() == "América")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "América");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "A. San Luis")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "A. San Luis");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Atlas")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Atlas");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Cruz Azul")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Cruz Azul");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Guadalajara")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Guadalajara");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "León")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "León");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Juárez")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Juárez");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Morelia")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Morelia");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Monterrey")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Monterrey");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Necaxa")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Necaxa");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Pachuca")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Pachuca");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Puebla")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Puebla");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Querétaro")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Querétaro");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Santos")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Santos");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Tigres")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Tigres");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Tijuana")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Tijuana");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Toluca")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Toluca");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "UNAM")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "UNAM");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Veracruz")
                {
                    total = Convert.ToInt32(TP.Rows[i].Cells[5].Value) - Convert.ToInt32(TP.Rows[i].Cells[6].Value);
                    Odato.aEdPar("general", "DG", total, "Veracruz");
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
            for (int i = 0; i <= 18; i++)
            {
                int total = 0;
                if (TP.Rows[i].Cells[0].Value.ToString() == "América")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "América");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "A. San Luis")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "A. San Luis");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Atlas")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Atlas");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Cruz Azul")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Cruz Azul");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Guadalajara")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Guadalajara");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "León")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "León");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Juárez")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Juárez");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Morelia")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Morelia");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Monterrey")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Monterrey");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Necaxa")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Necaxa");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Pachuca")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Pachuca");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Puebla")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Puebla");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Querétaro")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Querétaro");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Santos")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Santos");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Tigres")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Tigres");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Tijuana")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Tijuana");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Toluca")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Toluca");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "UNAM")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "UNAM");
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Veracruz")
                {
                    total = (Convert.ToInt32(TP.Rows[i].Cells[2].Value) * 3) + (Convert.ToInt32(TP.Rows[i].Cells[3].Value) * 1);
                    Odato.aEdPar("general", "Pts", total, "Veracruz");
                }
            }
            #endregion
        }


    }
}
