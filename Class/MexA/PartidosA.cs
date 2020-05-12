using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador.Class.MexA
{
    class PartidosA
    {
        datosA Odatos = new datosA();

        public PartidosA()
        {
            
        }

        #region No Editar
        //Consulta la tabla si existe
        public void TablaJugada(DataGridView T, ComboBox Torneo, ComboBox Jornada)
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
                    Torneo.SelectedIndex = 0;
                    Jornada.SelectedIndex = total - 1;
                }
            }
        }

        public void TablaSim(DataGridView T, ComboBox Torneo, ComboBox Jornada)
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
                    Torneo.SelectedIndex = 0;
                    Jornada.SelectedIndex = total;
                }
            }
        }

        public void Pendiente(DataGridView TPen, string condicion, Label ale, Label atl, Label caf, Label cim, Label zac, Label cel, Label cor, Label dor, Label lor, Label min, Label tam, Label uae, Label udg, Label ven)
        {
            Odatos.consultar("select Club, " + condicion + " from Partidos;", "Partidos"); 
            TPen.DataSource = Odatos.ds.Tables["Partidos"]; 
            TPen.Refresh();

            #region Se habilita los textbox si el equipo aun no juega
            for (int i = 0; i <= 13; i++)
            {
                if (TPen.Rows[i].Cells[0].Value.ToString() == "Alebrijes")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") ale.Enabled = true;
                    else ale.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "Atlante")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") atl.Enabled = true;
                    else atl.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "Cafetaleros")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") caf.Enabled = true;
                    else caf.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "Cimarrones")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") cim.Enabled = true;
                    else cim.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "Zacatepec")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") zac.Enabled = true;
                    else zac.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "Celaya")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") cel.Enabled = true;
                    else cel.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "Correcaminos")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") cor.Enabled = true;
                    else cor.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "Dorados")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") dor.Enabled = true;
                    else dor.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "Loros Colima")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") lor.Enabled = true;
                    else lor.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "Mineros")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") min.Enabled = true;
                    else min.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "Tampico Madero")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") tam.Enabled = true;
                    else tam.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "Potros UAEM")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") uae.Enabled = true;
                    else uae.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "Leones Negros")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") udg.Enabled = true;
                    else udg.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "Venados")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") ven.Enabled = true;
                    else ven.Enabled = false;
                }
            }
            #endregion
        }

        //ACTualiza Pendientes y GF
        public void ActPen(Label Pjornada, Label ale, Label atl, Label caf, Label cim, Label zac, Label cel, Label cor, Label dor, Label lor, Label min, Label tam, Label uae, Label udg, Label ven)
        {
            #region Actualizar Pendientes
            if (ale.Text == "P" || ale.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Alebrijes");
                ale.Enabled = false;
            }
            if (atl.Text == "P" || atl.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Atlante");
                atl.Enabled = false;
            }
            if (caf.Text == "P" || caf.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Cafetaleros");
                caf.Enabled = false;
            }
            if (cim.Text == "P" || cim.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Cimarrones");
                cim.Enabled = false;
            }
            if (zac.Text == "P" || zac.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Zacatepec");
                zac.Enabled = false;
            }
            if (cel.Text == "P" || cel.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Celaya");
                cel.Enabled = false;
            }
            if (cor.Text == "P" || cor.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Correcaminos");
                cor.Enabled = false;
            }
            if (dor.Text == "P" || dor.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Dorados");
                dor.Enabled = false;
            }
            if (lor.Text == "P" || lor.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Loros Colima");
                lor.Enabled = false;
            }
            if (min.Text == "P" || min.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Mineros");
                min.Enabled = false;
            }
            if (tam.Text == "P" || tam.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Tampico Madero");
                tam.Enabled = false;
            }
            if (uae.Text == "P" || uae.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Potros UAEM");
                uae.Enabled = false;
            }
            if (udg.Text == "P" || udg.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Leones Negros");
                udg.Enabled = false;
            }
            if (ven.Text == "P" || ven.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Venados");
                ven.Enabled = false;
            }
            #endregion
        }

        public void actualiza(Label Pjornada, Label equipo, Label Cequipo, string cadena)
        {
            Odatos.aGF("GF", Pjornada.Text, Convert.ToInt32(equipo.Text), cadena);
            Odatos.aGC("GC", Pjornada.Text, Convert.ToInt32(Cequipo.Text), cadena);
            Odatos.aPar("Partidos", Pjornada.Text, cadena);
            if (Convert.ToInt32(equipo.Text) > Convert.ToInt32(Cequipo.Text))
            {
                Odatos.aEdPar("Gana", Pjornada.Text, 1, cadena);
                Odatos.aEdPar("Empate", Pjornada.Text, 0, cadena);
                Odatos.aEdPar("Pierde", Pjornada.Text, 0, cadena);
            }
            else if (Convert.ToInt32(equipo.Text) == Convert.ToInt32(Cequipo.Text))
            {
                Odatos.aEdPar("Gana", Pjornada.Text, 0, cadena);
                Odatos.aEdPar("Empate", Pjornada.Text, 1, cadena);
                Odatos.aEdPar("Pierde", Pjornada.Text, 0, cadena);
            }
            else if (Convert.ToInt32(equipo.Text) < Convert.ToInt32(Cequipo.Text))
            {
                Odatos.aEdPar("Gana", Pjornada.Text, 0, cadena);
                Odatos.aEdPar("Empate", Pjornada.Text, 0, cadena);
                Odatos.aEdPar("Pierde", Pjornada.Text, 1, cadena);
            }
            equipo.Enabled = false;
        }

        public void ActGF(Label Pjornada, Label ale, Label atl, Label caf, Label cim, Label zac, Label cel, Label cor, Label dor, Label lor, Label min, Label tam, Label uae, Label udg, Label ven, Label Cale, Label Catl, Label Ccaf, Label Ccim, Label Czac, Label Ccel, Label Ccor, Label Cdor, Label Clor, Label Cmin, Label Ctam, Label Cuae, Label Cudg, Label Cven)
        {
            #region Actualiza los Goles a favor, en Contra además de G, E, P
            if (ale.Text != "" && ale.Text != "P")
                actualiza(Pjornada, ale, Cale, "Alebrijes");
            if (atl.Text != "" && atl.Text != "P")
                actualiza(Pjornada, atl, Catl, "Atlante");
            if (caf.Text != "" && caf.Text != "P")
                actualiza(Pjornada, caf, Ccaf, "Cafetaleros");
            if (cim.Text != "" && cim.Text != "P")
                actualiza(Pjornada, cim, Ccim, "Cimarrones");
            if (zac.Text != "" && zac.Text != "P")
                actualiza(Pjornada, zac, Czac, "Zacatepec");
            if (cel.Text != "" && cel.Text != "P")
                actualiza(Pjornada, cel, Ccel, "Celaya");
            if (cor.Text != "" && cor.Text != "P")
                actualiza(Pjornada, cor, Ccor, "Correcaminos");
            if (dor.Text != "" && dor.Text != "P")
                actualiza(Pjornada, dor, Cdor, "Dorados");
            if (lor.Text != "" && lor.Text != "P")
                actualiza(Pjornada, lor, Clor, "Loros Colima");
            if (min.Text != "" && min.Text != "P")
                actualiza(Pjornada, min, Cmin, "Mineros");
            if (tam.Text != "" && tam.Text != "P")
                actualiza(Pjornada, tam, Ctam, "Tampico Madero");
            if (uae.Text != "" && uae.Text != "P")
                actualiza(Pjornada, uae, Cuae, "Potros UAEM");
            if (udg.Text != "" && udg.Text != "P")
                actualiza(Pjornada, udg, Cudg, "Leones Negros");
            if (ven.Text != "" && ven.Text != "P")
                actualiza(Pjornada, ven, Cven, "Venados");
            #endregion
        }

        public void Tmpactualiza(Label Pjornada, Label equipo, Label Cequipo, string cadena)
        {
            Odatos.aGF("tmpGF", Pjornada.Text, Convert.ToInt32(equipo.Text), cadena);
            Odatos.aGC("tmpGC", Pjornada.Text, Convert.ToInt32(Cequipo.Text), cadena);
            Odatos.aPar("tmpPartidos", Pjornada.Text, cadena);
            if (Convert.ToInt32(equipo.Text) > Convert.ToInt32(Cequipo.Text))
            {
                Odatos.aEdPar("tmpGana", Pjornada.Text, 1, cadena);
                Odatos.aEdPar("tmpEmpate", Pjornada.Text, 0, cadena);
                Odatos.aEdPar("tmpPierde", Pjornada.Text, 0, cadena);
            }
            else if (Convert.ToInt32(equipo.Text) == Convert.ToInt32(Cequipo.Text))
            {
                Odatos.aEdPar("tmpGana", Pjornada.Text, 0, cadena);
                Odatos.aEdPar("tmpEmpate", Pjornada.Text, 1, cadena);
                Odatos.aEdPar("tmpPierde", Pjornada.Text, 0, cadena);
            }
            else if (Convert.ToInt32(equipo.Text) < Convert.ToInt32(Cequipo.Text))
            {
                Odatos.aEdPar("tmpGana", Pjornada.Text, 0, cadena);
                Odatos.aEdPar("tmpEmpate", Pjornada.Text, 0, cadena);
                Odatos.aEdPar("tmpPierde", Pjornada.Text, 1, cadena);
            }
            equipo.Enabled = false;
        }

        public void ActTmpGF(Label Pjornada, Label ale, Label atl, Label caf, Label cim, Label zac, Label cel, Label cor, Label dor, Label lor, Label min, Label tam, Label uae, Label udg, Label ven, Label Cale, Label Catl, Label Ccaf, Label Ccim, Label Czac, Label Ccel, Label Ccor, Label Cdor, Label Clor, Label Cmin, Label Ctam, Label Cuae, Label Cudg, Label Cven)
        {
            #region Actualiza los Goles a favor, en Contra además de G, E, P
            if (ale.Text != "" && ale.Text != "P")
                Tmpactualiza(Pjornada, ale, Cale, "Alebrijes");
            if (atl.Text != "" && atl.Text != "P")
                Tmpactualiza(Pjornada, atl, Catl, "Atlante");
            if (caf.Text != "" && caf.Text != "P")
                Tmpactualiza(Pjornada, caf, Ccaf, "Cafetaleros");
            if (cim.Text != "" && cim.Text != "P")
                Tmpactualiza(Pjornada, cim, Ccim, "Cimarrones");
            if (zac.Text != "" && zac.Text != "P")
                Tmpactualiza(Pjornada, zac, Czac, "Zacatepec");
            if (cel.Text != "" && cel.Text != "P")
                Tmpactualiza(Pjornada, cel, Ccel, "Celaya");
            if (cor.Text != "" && cor.Text != "P")
                Tmpactualiza(Pjornada, cor, Ccor, "Correcaminos");
            if (dor.Text != "" && dor.Text != "P")
                Tmpactualiza(Pjornada, dor, Cdor, "Dorados");
            if (lor.Text != "" && lor.Text != "P")
                Tmpactualiza(Pjornada, lor, Clor, "Loros Colima");
            if (min.Text != "" && min.Text != "P")
                Tmpactualiza(Pjornada, min, Cmin, "Mineros");
            if (tam.Text != "" && tam.Text != "P")
                Tmpactualiza(Pjornada, tam, Ctam, "Tampico Madero");
            if (uae.Text != "" && uae.Text != "P")
                Tmpactualiza(Pjornada, uae, Cuae, "Potros UAEM");
            if (udg.Text != "" && udg.Text != "P")
                Tmpactualiza(Pjornada, udg, Cudg, "Leones Negros");
            if (ven.Text != "" && ven.Text != "P")
                Tmpactualiza(Pjornada, ven, Cven, "Venados");
            #endregion
        }

        //HABilita textbox        
        public void HabGF(DataGridView TGF, string condicion, Label ale, Label atl, Label caf, Label cim, Label zac, Label cel, Label cor, Label dor, Label lor, Label min, Label tam, Label uae, Label udg, Label ven)
        {
            Odatos.consultar("select Club, " + condicion + " from GF;", "GF");
            TGF.DataSource = Odatos.ds.Tables["GF"];
            TGF.Refresh();

            #region Muestra los Goles a favor en la consulta
            for (int i = 0; i <= 13; i++)
            {
                if (TGF.Rows[i].Cells[0].Value.ToString() == "Alebrijes")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        ale.Enabled = true;
                        ale.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "Atlante")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        atl.Enabled = true;
                        atl.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "Cafetaleros")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        caf.Enabled = true;
                        caf.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "Cimarrones")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        cim.Enabled = true;
                        cim.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "Zacatepec")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        zac.Enabled = true;
                        zac.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "Celaya")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        cel.Enabled = true;
                        cel.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "Correcaminos")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        cor.Enabled = true;
                        cor.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "Dorados")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        dor.Enabled = true;
                        dor.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "Loros Colima")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        lor.Enabled = true;
                        lor.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "Mineros")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        min.Enabled = true;
                        min.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "Tampico Madero")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        tam.Enabled = true;
                        tam.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "Potros UAEM")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        uae.Enabled = true;
                        uae.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "Leones Negros")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        udg.Enabled = true;
                        udg.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "Venados")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        ven.Enabled = true;
                        ven.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
            }
            #endregion
        }

        public void HabPen(DataGridView TP, string condicion, Label ale, Label atl, Label caf, Label cim, Label zac, Label cel, Label cor, Label dor, Label lor, Label min, Label tam, Label uae, Label udg, Label ven)
        {
            Odatos.consultar("select Club, " + condicion + " from Partidos;", "Partidos");
            TP.DataSource = Odatos.ds.Tables["Partidos"];
            TP.Refresh();

            #region Muestra los Pendientes en la consulta
            for (int i = 0; i <= 13; i++)
            {
                if (TP.Rows[i].Cells[0].Value.ToString() == "Alebrijes")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        ale.Enabled = true;
                        ale.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Atlante")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        atl.Enabled = true;
                        atl.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Cafetaleros")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        caf.Enabled = true;
                        caf.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Cimarrones")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        cim.Enabled = true;
                        cim.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Zacatepec")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        zac.Enabled = true;
                        zac.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Celaya")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        cel.Enabled = true;
                        cel.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Correcaminos")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        cor.Enabled = true;
                        cor.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Dorados")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        dor.Enabled = true;
                        dor.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Loros Colima")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        lor.Enabled = true;
                        lor.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Mineros")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        min.Enabled = true;
                        min.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Tampico Madero")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        tam.Enabled = true;
                        tam.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Potros UAEM")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        uae.Enabled = true;
                        uae.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Leones Negros")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        udg.Enabled = true;
                        udg.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Venados")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        ven.Enabled = true;
                        ven.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
            }
            #endregion
        }
        
        #endregion

        public void AsociarText(string condicion, Label ale, Label atl, Label caf, Label cim, Label zac, Label cel, Label cor, Label dor, Label lor, Label min, Label tam, Label uae, Label udg, Label ven, TextBox txbL1, TextBox txbL2, TextBox txbL3, TextBox txbL4, TextBox txbL5, TextBox txbL6, TextBox txbL7, TextBox txbV1, TextBox txbV2, TextBox txbV3, TextBox txbV4, TextBox txbV5, TextBox txbV6, TextBox txbV7, Label Cale, Label Catl, Label Ccaf, Label Ccim, Label Czac, Label Ccel, Label Ccor, Label Cdor, Label Clor, Label Cmin, Label Ctam, Label Cuae, Label Cudg, Label Cven)
        {
            #region Asocia los TextBox a los Label
            if (condicion == "A1")
            {
                cel.Text = txbL1.Text; zac.Text = txbV1.Text; /**/ Ccel.Text = txbV1.Text; Czac.Text = txbL1.Text; /**/ txbL1.Enabled = cel.Enabled; txbV1.Enabled = zac.Enabled;
                uae.Text = txbL2.Text; cor.Text = txbV2.Text; /**/ Cuae.Text = txbV2.Text; Ccor.Text = txbL2.Text; /**/ txbL2.Enabled = uae.Enabled; txbV2.Enabled = cor.Enabled;
                tam.Text = txbL3.Text; dor.Text = txbV3.Text; /**/ Ctam.Text = txbV3.Text; Cdor.Text = txbL3.Text; /**/ txbL3.Enabled = tam.Enabled; txbV3.Enabled = dor.Enabled;
                atl.Text = txbL4.Text; min.Text = txbV4.Text; /**/ Catl.Text = txbV4.Text; Cmin.Text = txbL4.Text; /**/ txbL4.Enabled = atl.Enabled; txbV4.Enabled = min.Enabled;
                lor.Text = txbL5.Text; ven.Text = txbV5.Text; /**/ Clor.Text = txbV5.Text; Cven.Text = txbL5.Text; /**/ txbL5.Enabled = lor.Enabled; txbV5.Enabled = ven.Enabled;
                caf.Text = txbL6.Text; cim.Text = txbV6.Text; /**/ Ccaf.Text = txbV6.Text; Ccim.Text = txbL6.Text; /**/ txbL6.Enabled = caf.Enabled; txbV6.Enabled = cim.Enabled;
                ale.Text = txbL7.Text; udg.Text = txbV7.Text; /**/ Cale.Text = txbV7.Text; Cudg.Text = txbL7.Text; /**/ txbL7.Enabled = ale.Enabled; txbV7.Enabled = udg.Enabled;
            }
            else if (condicion == "A2")
            {
                cim.Text = txbL1.Text; ale.Text = txbV1.Text; /**/ Ccim.Text = txbV1.Text; Cale.Text = txbL1.Text; /**/ txbL1.Enabled = cim.Enabled; txbV1.Enabled = ale.Enabled;
                min.Text = txbL2.Text; tam.Text = txbV2.Text; /**/ Cmin.Text = txbV2.Text; Ctam.Text = txbL2.Text; /**/ txbL2.Enabled = min.Enabled; txbV2.Enabled = tam.Enabled;
                cor.Text = txbL3.Text; atl.Text = txbV3.Text; /**/ Ccor.Text = txbV3.Text; Catl.Text = txbL3.Text; /**/ txbL3.Enabled = cor.Enabled; txbV3.Enabled = atl.Enabled;
                zac.Text = txbL4.Text; lor.Text = txbV4.Text; /**/ Czac.Text = txbV4.Text; Clor.Text = txbL4.Text; /**/ txbL4.Enabled = zac.Enabled; txbV4.Enabled = lor.Enabled;
                ven.Text = txbL5.Text; uae.Text = txbV5.Text; /**/ Cven.Text = txbV5.Text; Cuae.Text = txbL5.Text; /**/ txbL5.Enabled = ven.Enabled; txbV5.Enabled = uae.Enabled;
                dor.Text = txbL6.Text; cel.Text = txbV6.Text; /**/ Cdor.Text = txbV6.Text; Ccel.Text = txbL6.Text; /**/ txbL6.Enabled = dor.Enabled; txbV6.Enabled = cel.Enabled;
                udg.Text = txbL7.Text; caf.Text = txbV7.Text; /**/ Cudg.Text = txbV7.Text; Ccaf.Text = txbL7.Text; /**/ txbL7.Enabled = udg.Enabled; txbV7.Enabled = caf.Enabled;
            }
            else if (condicion == "A3")
            {
                tam.Text = txbL1.Text; cor.Text = txbV1.Text; /**/ Ctam.Text = txbV1.Text; Ccor.Text = txbL1.Text; /**/ txbL1.Enabled = tam.Enabled; txbV1.Enabled = cor.Enabled;
                uae.Text = txbL2.Text; dor.Text = txbV2.Text; /**/ Cuae.Text = txbV2.Text; Cdor.Text = txbL2.Text; /**/ txbL2.Enabled = uae.Enabled; txbV2.Enabled = dor.Enabled;
                ven.Text = txbL3.Text; udg.Text = txbV3.Text; /**/ Cven.Text = txbV3.Text; Cudg.Text = txbL3.Text; /**/ txbL3.Enabled = ven.Enabled; txbV3.Enabled = udg.Enabled;
                zac.Text = txbL4.Text; min.Text = txbV4.Text; /**/ Czac.Text = txbV4.Text; Cmin.Text = txbL4.Text; /**/ txbL4.Enabled = zac.Enabled; txbV4.Enabled = min.Enabled;
                caf.Text = txbL5.Text; atl.Text = txbV5.Text; /**/ Ccaf.Text = txbV5.Text; Catl.Text = txbL5.Text; /**/ txbL5.Enabled = caf.Enabled; txbV5.Enabled = atl.Enabled;
                cel.Text = txbL6.Text; cim.Text = txbV6.Text; /**/ Ccel.Text = txbV6.Text; Ccim.Text = txbL6.Text; /**/ txbL6.Enabled = cel.Enabled; txbV6.Enabled = cim.Enabled;
                lor.Text = txbL7.Text; ale.Text = txbV7.Text; /**/ Clor.Text = txbV7.Text; Cale.Text = txbL7.Text; /**/ txbL7.Enabled = lor.Enabled; txbV7.Enabled = ale.Enabled;
            }
            else if (condicion == "A4")
            {
                udg.Text = txbL1.Text; zac.Text = txbV1.Text; /**/ Cudg.Text = txbV1.Text; Czac.Text = txbL1.Text; /**/ txbL1.Enabled = udg.Enabled; txbV1.Enabled = zac.Enabled;
                min.Text = txbL2.Text; cel.Text = txbV2.Text; /**/ Cmin.Text = txbV2.Text; Ccel.Text = txbL2.Text; /**/ txbL2.Enabled = min.Enabled; txbV2.Enabled = cel.Enabled;
                cor.Text = txbL3.Text; lor.Text = txbV3.Text; /**/ Ccor.Text = txbV3.Text; Clor.Text = txbL3.Text; /**/ txbL3.Enabled = cor.Enabled; txbV3.Enabled = lor.Enabled;
                ale.Text = txbL4.Text; caf.Text = txbV4.Text; /**/ Cale.Text = txbV4.Text; Ccaf.Text = txbL4.Text; /**/ txbL4.Enabled = ale.Enabled; txbV4.Enabled = caf.Enabled;
                atl.Text = txbL5.Text; uae.Text = txbV5.Text; /**/ Catl.Text = txbV5.Text; Cuae.Text = txbL5.Text; /**/ txbL5.Enabled = atl.Enabled; txbV5.Enabled = uae.Enabled;
                dor.Text = txbL6.Text; ven.Text = txbV6.Text; /**/ Cdor.Text = txbV6.Text; Cven.Text = txbL6.Text; /**/ txbL6.Enabled = dor.Enabled; txbV6.Enabled = ven.Enabled;
                cim.Text = txbL7.Text; tam.Text = txbV7.Text; /**/ Ccim.Text = txbV7.Text; Ctam.Text = txbL7.Text; /**/ txbL7.Enabled = cim.Enabled; txbV7.Enabled = tam.Enabled;
            }
            else if (condicion == "A5")
            {
                uae.Text = txbL1.Text; ale.Text = txbV1.Text; /**/ Cuae.Text = txbV1.Text; Cale.Text = txbL1.Text; /**/ txbL1.Enabled = uae.Enabled; txbV1.Enabled = ale.Enabled;
                tam.Text = txbL2.Text; caf.Text = txbV2.Text; /**/ Ctam.Text = txbV2.Text; Ccaf.Text = txbL2.Text; /**/ txbL2.Enabled = tam.Enabled; txbV2.Enabled = caf.Enabled;
                ven.Text = txbL3.Text; min.Text = txbV3.Text; /**/ Cven.Text = txbV3.Text; Cmin.Text = txbL3.Text; /**/ txbL3.Enabled = ven.Enabled; txbV3.Enabled = min.Enabled;
                lor.Text = txbL4.Text; cim.Text = txbV4.Text; /**/ Clor.Text = txbV4.Text; Ccim.Text = txbL4.Text; /**/ txbL4.Enabled = lor.Enabled; txbV4.Enabled = cim.Enabled;
                zac.Text = txbL5.Text; atl.Text = txbV5.Text; /**/ Czac.Text = txbV5.Text; Catl.Text = txbL5.Text; /**/ txbL5.Enabled = zac.Enabled; txbV5.Enabled = atl.Enabled;
                dor.Text = txbL6.Text; udg.Text = txbV6.Text; /**/ Cdor.Text = txbV6.Text; Cudg.Text = txbL6.Text; /**/ txbL6.Enabled = dor.Enabled; txbV6.Enabled = udg.Enabled;
                cel.Text = txbL7.Text; cor.Text = txbV7.Text; /**/ Ccel.Text = txbV7.Text; Ccor.Text = txbL7.Text; /**/ txbL7.Enabled = cel.Enabled; txbV7.Enabled = cor.Enabled;
            }
            else if (condicion == "A6")
            {
                atl.Text = txbL1.Text; tam.Text = txbV1.Text; /**/ Catl.Text = txbV1.Text; Ctam.Text = txbL1.Text; /**/ txbL1.Enabled = atl.Enabled; txbV1.Enabled = tam.Enabled;
                min.Text = txbL2.Text; uae.Text = txbV2.Text; /**/ Cmin.Text = txbV2.Text; Cuae.Text = txbL2.Text; /**/ txbL2.Enabled = min.Enabled; txbV2.Enabled = uae.Enabled;
                cor.Text = txbL3.Text; dor.Text = txbV3.Text; /**/ Ccor.Text = txbV3.Text; Cdor.Text = txbL3.Text; /**/ txbL3.Enabled = cor.Enabled; txbV3.Enabled = dor.Enabled;
                ale.Text = txbL4.Text; zac.Text = txbV4.Text; /**/ Cale.Text = txbV4.Text; Czac.Text = txbL4.Text; /**/ txbL4.Enabled = ale.Enabled; txbV4.Enabled = zac.Enabled;
                caf.Text = txbL5.Text; lor.Text = txbV5.Text; /**/ Ccaf.Text = txbV5.Text; Clor.Text = txbL5.Text; /**/ txbL5.Enabled = caf.Enabled; txbV5.Enabled = lor.Enabled;
                cim.Text = txbL6.Text; ven.Text = txbV6.Text; /**/ Ccim.Text = txbV6.Text; Cven.Text = txbL6.Text; /**/ txbL6.Enabled = cim.Enabled; txbV6.Enabled = ven.Enabled;
                udg.Text = txbL7.Text; cel.Text = txbV7.Text; /**/ Cudg.Text = txbV7.Text; Ccel.Text = txbL7.Text; /**/ txbL7.Enabled = udg.Enabled; txbV7.Enabled = cel.Enabled;
            }
            else if (condicion == "A7")
            {
                dor.Text = txbL1.Text; caf.Text = txbV1.Text; /**/ Cdor.Text = txbV1.Text; Ccaf.Text = txbL1.Text; /**/ txbL1.Enabled = dor.Enabled; txbV1.Enabled = caf.Enabled;
                lor.Text = txbL2.Text; atl.Text = txbV2.Text; /**/ Clor.Text = txbV2.Text; Catl.Text = txbL2.Text; /**/ txbL2.Enabled = lor.Enabled; txbV2.Enabled = atl.Enabled;
                tam.Text = txbL3.Text; udg.Text = txbV3.Text; /**/ Ctam.Text = txbV3.Text; Cudg.Text = txbL3.Text; /**/ txbL3.Enabled = tam.Enabled; txbV3.Enabled = udg.Enabled;
                ven.Text = txbL4.Text; ale.Text = txbV4.Text; /**/ Cven.Text = txbV4.Text; Cale.Text = txbL4.Text; /**/ txbL4.Enabled = ven.Enabled; txbV4.Enabled = ale.Enabled;
                zac.Text = txbL5.Text; cor.Text = txbV5.Text; /**/ Czac.Text = txbV5.Text; Ccor.Text = txbL5.Text; /**/ txbL5.Enabled = zac.Enabled; txbV5.Enabled = cor.Enabled;
                cim.Text = txbL6.Text; min.Text = txbV6.Text; /**/ Ccim.Text = txbV6.Text; Cmin.Text = txbL6.Text; /**/ txbL6.Enabled = cim.Enabled; txbV6.Enabled = min.Enabled;
                cel.Text = txbL7.Text; uae.Text = txbV7.Text; /**/ Ccel.Text = txbV7.Text; Cuae.Text = txbL7.Text; /**/ txbL7.Enabled = cel.Enabled; txbV7.Enabled = uae.Enabled;
            }
            else if (condicion == "A8")
            {
                uae.Text = txbL1.Text; lor.Text = txbV1.Text; /**/ Cuae.Text = txbV1.Text; Clor.Text = txbL1.Text; /**/ txbL1.Enabled = uae.Enabled; txbV1.Enabled = lor.Enabled;
                min.Text = txbL2.Text; caf.Text = txbV2.Text; /**/ Cmin.Text = txbV2.Text; Ccaf.Text = txbL2.Text; /**/ txbL2.Enabled = min.Enabled; txbV2.Enabled = caf.Enabled;
                atl.Text = txbL3.Text; udg.Text = txbV3.Text; /**/ Catl.Text = txbV3.Text; Cudg.Text = txbL3.Text; /**/ txbL3.Enabled = atl.Enabled; txbV3.Enabled = udg.Enabled;
                ale.Text = txbL4.Text; tam.Text = txbV4.Text; /**/ Cale.Text = txbV4.Text; Ctam.Text = txbL4.Text; /**/ txbL4.Enabled = ale.Enabled; txbV4.Enabled = tam.Enabled;
                cor.Text = txbL5.Text; cim.Text = txbV5.Text; /**/ Ccor.Text = txbV5.Text; Ccim.Text = txbL5.Text; /**/ txbL5.Enabled = cor.Enabled; txbV5.Enabled = cim.Enabled;
                dor.Text = txbL6.Text; zac.Text = txbV6.Text; /**/ Cdor.Text = txbV6.Text; Czac.Text = txbL6.Text; /**/ txbL6.Enabled = dor.Enabled; txbV6.Enabled = zac.Enabled;
                cel.Text = txbL7.Text; ven.Text = txbV7.Text; /**/ Ccel.Text = txbV7.Text; Cven.Text = txbL7.Text; /**/ txbL7.Enabled = cel.Enabled; txbV7.Enabled = ven.Enabled;
            }
            else if (condicion == "A9")
            {
                zac.Text = txbL1.Text; ven.Text = txbV1.Text; /**/ Czac.Text = txbV1.Text; Cven.Text = txbL1.Text; /**/ txbL1.Enabled = zac.Enabled; txbV1.Enabled = ven.Enabled;
                tam.Text = txbL2.Text; cel.Text = txbV2.Text; /**/ Ctam.Text = txbV2.Text; Ccel.Text = txbL2.Text; /**/ txbL2.Enabled = tam.Enabled; txbV2.Enabled = cel.Enabled;
                caf.Text = txbL3.Text; cor.Text = txbV3.Text; /**/ Ccaf.Text = txbV3.Text; Ccor.Text = txbL3.Text; /**/ txbL3.Enabled = caf.Enabled; txbV3.Enabled = cor.Enabled;
                lor.Text = txbL4.Text; min.Text = txbV4.Text; /**/ Clor.Text = txbV4.Text; Cmin.Text = txbL4.Text; /**/ txbL4.Enabled = lor.Enabled; txbV4.Enabled = min.Enabled;
                udg.Text = txbL5.Text; uae.Text = txbV5.Text; /**/ Cudg.Text = txbV5.Text; Cuae.Text = txbL5.Text; /**/ txbL5.Enabled = udg.Enabled; txbV5.Enabled = uae.Enabled;
                atl.Text = txbL6.Text; ale.Text = txbV6.Text; /**/ Catl.Text = txbV6.Text; Cale.Text = txbL6.Text; /**/ txbL6.Enabled = atl.Enabled; txbV6.Enabled = ale.Enabled;
                cim.Text = txbL7.Text; dor.Text = txbV7.Text; /**/ Ccim.Text = txbV7.Text; Cdor.Text = txbL7.Text; /**/ txbL7.Enabled = cim.Enabled; txbV7.Enabled = dor.Enabled;
            }
            else if (condicion == "A10")
            {
                dor.Text = txbL1.Text; atl.Text = txbV1.Text; /**/ Cdor.Text = txbV1.Text; Catl.Text = txbL1.Text; /**/ txbL1.Enabled = dor.Enabled; txbV1.Enabled = atl.Enabled;
                uae.Text = txbL2.Text; caf.Text = txbV2.Text; /**/ Cuae.Text = txbV2.Text; Ccaf.Text = txbL2.Text; /**/ txbL2.Enabled = uae.Enabled; txbV2.Enabled = caf.Enabled;
                min.Text = txbL3.Text; udg.Text = txbV3.Text; /**/ Cmin.Text = txbV3.Text; Cudg.Text = txbL3.Text; /**/ txbL3.Enabled = min.Enabled; txbV3.Enabled = udg.Enabled;
                ven.Text = txbL4.Text; tam.Text = txbV4.Text; /**/ Cven.Text = txbV4.Text; Ctam.Text = txbL4.Text; /**/ txbL4.Enabled = ven.Enabled; txbV4.Enabled = tam.Enabled;
                zac.Text = txbL5.Text; cim.Text = txbV5.Text; /**/ Czac.Text = txbV5.Text; Ccim.Text = txbL5.Text; /**/ txbL5.Enabled = zac.Enabled; txbV5.Enabled = cim.Enabled;
                cor.Text = txbL6.Text; ale.Text = txbV6.Text; /**/ Ccor.Text = txbV6.Text; Cale.Text = txbL6.Text; /**/ txbL6.Enabled = cor.Enabled; txbV6.Enabled = ale.Enabled;
                cel.Text = txbL7.Text; lor.Text = txbV7.Text; /**/ Ccel.Text = txbV7.Text; Clor.Text = txbL7.Text; /**/ txbL7.Enabled = cel.Enabled; txbV7.Enabled = lor.Enabled;
            }
            else if (condicion == "A11")
            {
                atl.Text = txbL1.Text; cel.Text = txbV1.Text; /**/ Catl.Text = txbV1.Text; Ccel.Text = txbL1.Text; /**/ txbL1.Enabled = atl.Enabled; txbV1.Enabled = cel.Enabled;
                ale.Text = txbL2.Text; min.Text = txbV2.Text; /**/ Cale.Text = txbV2.Text; Cmin.Text = txbL2.Text; /**/ txbL2.Enabled = ale.Enabled; txbV2.Enabled = min.Enabled;
                lor.Text = txbL3.Text; dor.Text = txbV3.Text; /**/ Clor.Text = txbV3.Text; Cdor.Text = txbL3.Text; /**/ txbL3.Enabled = lor.Enabled; txbV3.Enabled = dor.Enabled;
                caf.Text = txbL4.Text; ven.Text = txbV4.Text; /**/ Ccaf.Text = txbV4.Text; Cven.Text = txbL4.Text; /**/ txbL4.Enabled = caf.Enabled; txbV4.Enabled = ven.Enabled;
                cim.Text = txbL5.Text; uae.Text = txbV5.Text; /**/ Ccim.Text = txbV5.Text; Cuae.Text = txbL5.Text; /**/ txbL5.Enabled = cim.Enabled; txbV5.Enabled = uae.Enabled;
                udg.Text = txbL6.Text; cor.Text = txbV6.Text; /**/ Cudg.Text = txbV6.Text; Ccor.Text = txbL6.Text; /**/ txbL6.Enabled = udg.Enabled; txbV6.Enabled = cor.Enabled;
                tam.Text = txbL7.Text; zac.Text = txbV7.Text; /**/ Ctam.Text = txbV7.Text; Czac.Text = txbL7.Text; /**/ txbL7.Enabled = tam.Enabled; txbV7.Enabled = zac.Enabled;
            }
            else if (condicion == "A12")
            {
                lor.Text = txbL1.Text; tam.Text = txbV1.Text; /**/ Clor.Text = txbV1.Text; Ctam.Text = txbL1.Text; /**/ txbL1.Enabled = lor.Enabled; txbV1.Enabled = tam.Enabled;
                cor.Text = txbL2.Text; min.Text = txbV2.Text; /**/ Ccor.Text = txbV2.Text; Cmin.Text = txbL2.Text; /**/ txbL2.Enabled = cor.Enabled; txbV2.Enabled = min.Enabled;
                ven.Text = txbL3.Text; atl.Text = txbV3.Text; /**/ Cven.Text = txbV3.Text; Catl.Text = txbL3.Text; /**/ txbL3.Enabled = ven.Enabled; txbV3.Enabled = atl.Enabled;
                cel.Text = txbL4.Text; caf.Text = txbV4.Text; /**/ Ccel.Text = txbV4.Text; Ccaf.Text = txbL4.Text; /**/ txbL4.Enabled = cel.Enabled; txbV4.Enabled = caf.Enabled;
                dor.Text = txbL5.Text; ale.Text = txbV5.Text; /**/ Cdor.Text = txbV5.Text; Cale.Text = txbL5.Text; /**/ txbL5.Enabled = dor.Enabled; txbV5.Enabled = ale.Enabled;
                cim.Text = txbL6.Text; udg.Text = txbV6.Text; /**/ Ccim.Text = txbV6.Text; Cudg.Text = txbL6.Text; /**/ txbL6.Enabled = cim.Enabled; txbV6.Enabled = udg.Enabled;
                zac.Text = txbL7.Text; uae.Text = txbV7.Text; /**/ Czac.Text = txbV7.Text; Cuae.Text = txbL7.Text; /**/ txbL7.Enabled = zac.Enabled; txbV7.Enabled = uae.Enabled;
            }
            else if (condicion == "A13")
            {
                min.Text = txbL1.Text; dor.Text = txbV1.Text; /**/ Cmin.Text = txbV1.Text; Cdor.Text = txbL1.Text; /**/ txbL1.Enabled = min.Enabled; txbV1.Enabled = dor.Enabled;
                uae.Text = txbL2.Text; tam.Text = txbV2.Text; /**/ Cuae.Text = txbV2.Text; Ctam.Text = txbL2.Text; /**/ txbL2.Enabled = uae.Enabled; txbV2.Enabled = tam.Enabled;
                atl.Text = txbL3.Text; cim.Text = txbV3.Text; /**/ Catl.Text = txbV3.Text; Ccim.Text = txbL3.Text; /**/ txbL3.Enabled = atl.Enabled; txbV3.Enabled = cim.Enabled;
                cor.Text = txbL4.Text; ven.Text = txbV4.Text; /**/ Ccor.Text = txbV4.Text; Cven.Text = txbL4.Text; /**/ txbL4.Enabled = cor.Enabled; txbV4.Enabled = ven.Enabled;
                ale.Text = txbL5.Text; cel.Text = txbV5.Text; /**/ Cale.Text = txbV5.Text; Ccel.Text = txbL5.Text; /**/ txbL5.Enabled = ale.Enabled; txbV5.Enabled = cel.Enabled;
                caf.Text = txbL6.Text; zac.Text = txbV6.Text; /**/ Ccaf.Text = txbV6.Text; Czac.Text = txbL6.Text; /**/ txbL6.Enabled = caf.Enabled; txbV6.Enabled = zac.Enabled;
                udg.Text = txbL7.Text; lor.Text = txbV7.Text; /**/ Cudg.Text = txbV7.Text; Clor.Text = txbL7.Text; /**/ txbL7.Enabled = udg.Enabled; txbV7.Enabled = lor.Enabled;
            }
            #endregion
        }

        public void AsociarLabel(string condicion, Label ale, Label atl, Label caf, Label cim, Label zac, Label cel, Label cor, Label dor, Label lor, Label min, Label tam, Label uae, Label udg, Label ven, TextBox txbL1, TextBox txbL2, TextBox txbL3, TextBox txbL4, TextBox txbL5, TextBox txbL6, TextBox txbL7, TextBox txbV1, TextBox txbV2, TextBox txbV3, TextBox txbV4, TextBox txbV5, TextBox txbV6, TextBox txbV7)
        {
            #region Asociar Label a Textbox
            if (condicion == "A1")
            {
                txbL1.Text = cel.Text; txbV1.Text = zac.Text; /**/ txbL1.Enabled = cel.Enabled; txbV1.Enabled = zac.Enabled;
                txbL2.Text = uae.Text; txbV2.Text = cor.Text; /**/ txbL2.Enabled = uae.Enabled; txbV2.Enabled = cor.Enabled;
                txbL3.Text = tam.Text; txbV3.Text = dor.Text; /**/ txbL3.Enabled = tam.Enabled; txbV3.Enabled = dor.Enabled;
                txbL4.Text = atl.Text; txbV4.Text = min.Text; /**/ txbL4.Enabled = atl.Enabled; txbV4.Enabled = min.Enabled;
                txbL5.Text = lor.Text; txbV5.Text = ven.Text; /**/ txbL5.Enabled = lor.Enabled; txbV5.Enabled = ven.Enabled;
                txbL6.Text = caf.Text; txbV6.Text = cim.Text; /**/ txbL6.Enabled = caf.Enabled; txbV6.Enabled = cim.Enabled;
                txbL7.Text = ale.Text; txbV7.Text = udg.Text; /**/ txbL7.Enabled = ale.Enabled; txbV7.Enabled = udg.Enabled;
            }
            else if (condicion == "A2")
            {
                txbL1.Text = cim.Text; txbV1.Text = ale.Text; /**/ txbL1.Enabled = cim.Enabled; txbV1.Enabled = ale.Enabled;
                txbL2.Text = min.Text; txbV2.Text = tam.Text; /**/ txbL2.Enabled = min.Enabled; txbV2.Enabled = tam.Enabled;
                txbL3.Text = cor.Text; txbV3.Text = atl.Text; /**/ txbL3.Enabled = cor.Enabled; txbV3.Enabled = atl.Enabled;
                txbL4.Text = zac.Text; txbV4.Text = lor.Text; /**/ txbL4.Enabled = zac.Enabled; txbV4.Enabled = lor.Enabled;
                txbL5.Text = ven.Text; txbV5.Text = uae.Text; /**/ txbL5.Enabled = ven.Enabled; txbV5.Enabled = uae.Enabled;
                txbL6.Text = dor.Text; txbV6.Text = cel.Text; /**/ txbL6.Enabled = dor.Enabled; txbV6.Enabled = cel.Enabled;
                txbL7.Text = udg.Text; txbV7.Text = caf.Text; /**/ txbL7.Enabled = udg.Enabled; txbV7.Enabled = caf.Enabled;
            }
            else if (condicion == "A3")
            {
                txbL1.Text = tam.Text; txbV1.Text = cor.Text; /**/ txbL1.Enabled = tam.Enabled; txbV1.Enabled = cor.Enabled;
                txbL2.Text = uae.Text; txbV2.Text = dor.Text; /**/ txbL2.Enabled = uae.Enabled; txbV2.Enabled = dor.Enabled;
                txbL3.Text = ven.Text; txbV3.Text = udg.Text; /**/ txbL3.Enabled = ven.Enabled; txbV3.Enabled = udg.Enabled;
                txbL4.Text = zac.Text; txbV4.Text = min.Text; /**/ txbL4.Enabled = zac.Enabled; txbV4.Enabled = min.Enabled;
                txbL5.Text = caf.Text; txbV5.Text = atl.Text; /**/ txbL5.Enabled = caf.Enabled; txbV5.Enabled = atl.Enabled;
                txbL6.Text = cel.Text; txbV6.Text = cim.Text; /**/ txbL6.Enabled = cel.Enabled; txbV6.Enabled = cim.Enabled;
                txbL7.Text = lor.Text; txbV7.Text = ale.Text; /**/ txbL7.Enabled = lor.Enabled; txbV7.Enabled = ale.Enabled;
            }
            else if (condicion == "A4")
            {
                txbL1.Text = udg.Text; txbV1.Text = zac.Text; /**/ txbL1.Enabled = udg.Enabled; txbV1.Enabled = zac.Enabled;
                txbL2.Text = min.Text; txbV2.Text = cel.Text; /**/ txbL2.Enabled = min.Enabled; txbV2.Enabled = cel.Enabled;
                txbL3.Text = cor.Text; txbV3.Text = lor.Text; /**/ txbL3.Enabled = cor.Enabled; txbV3.Enabled = lor.Enabled;
                txbL4.Text = ale.Text; txbV4.Text = caf.Text; /**/ txbL4.Enabled = ale.Enabled; txbV4.Enabled = caf.Enabled;
                txbL5.Text = atl.Text; txbV5.Text = uae.Text; /**/ txbL5.Enabled = atl.Enabled; txbV5.Enabled = uae.Enabled;
                txbL6.Text = dor.Text; txbV6.Text = ven.Text; /**/ txbL6.Enabled = dor.Enabled; txbV6.Enabled = ven.Enabled;
                txbL7.Text = cim.Text; txbV7.Text = tam.Text; /**/ txbL7.Enabled = cim.Enabled; txbV7.Enabled = tam.Enabled;
            }
            else if (condicion == "A5")
            {
                txbL1.Text = uae.Text; txbV1.Text = ale.Text; /**/ txbL1.Enabled = uae.Enabled; txbV1.Enabled = ale.Enabled;
                txbL2.Text = tam.Text; txbV2.Text = caf.Text; /**/ txbL2.Enabled = tam.Enabled; txbV2.Enabled = caf.Enabled;
                txbL3.Text = ven.Text; txbV3.Text = min.Text; /**/ txbL3.Enabled = ven.Enabled; txbV3.Enabled = min.Enabled;
                txbL4.Text = lor.Text; txbV4.Text = cim.Text; /**/ txbL4.Enabled = lor.Enabled; txbV4.Enabled = cim.Enabled;
                txbL5.Text = zac.Text; txbV5.Text = atl.Text; /**/ txbL5.Enabled = zac.Enabled; txbV5.Enabled = atl.Enabled;
                txbL6.Text = dor.Text; txbV6.Text = udg.Text; /**/ txbL6.Enabled = dor.Enabled; txbV6.Enabled = udg.Enabled;
                txbL7.Text = cel.Text; txbV7.Text = cor.Text; /**/ txbL7.Enabled = cel.Enabled; txbV7.Enabled = cor.Enabled;
            }
            else if (condicion == "A6")
            {
                txbL1.Text = atl.Text; txbV1.Text = tam.Text; /**/ txbL1.Enabled = atl.Enabled; txbV1.Enabled = tam.Enabled;
                txbL2.Text = min.Text; txbV2.Text = uae.Text; /**/ txbL2.Enabled = min.Enabled; txbV2.Enabled = uae.Enabled;
                txbL3.Text = cor.Text; txbV3.Text = dor.Text; /**/ txbL3.Enabled = cor.Enabled; txbV3.Enabled = dor.Enabled;
                txbL4.Text = ale.Text; txbV4.Text = zac.Text; /**/ txbL4.Enabled = ale.Enabled; txbV4.Enabled = zac.Enabled;
                txbL5.Text = caf.Text; txbV5.Text = lor.Text; /**/ txbL5.Enabled = caf.Enabled; txbV5.Enabled = lor.Enabled;
                txbL6.Text = cim.Text; txbV6.Text = ven.Text; /**/ txbL6.Enabled = cim.Enabled; txbV6.Enabled = ven.Enabled;
                txbL7.Text = udg.Text; txbV7.Text = cel.Text; /**/ txbL7.Enabled = udg.Enabled; txbV7.Enabled = cel.Enabled;
            }
            else if (condicion == "A7")
            {
                txbL1.Text = dor.Text; txbV1.Text = caf.Text; /**/ txbL1.Enabled = dor.Enabled; txbV1.Enabled = caf.Enabled;
                txbL2.Text = lor.Text; txbV2.Text = atl.Text; /**/ txbL2.Enabled = lor.Enabled; txbV2.Enabled = atl.Enabled;
                txbL3.Text = tam.Text; txbV3.Text = udg.Text; /**/ txbL3.Enabled = tam.Enabled; txbV3.Enabled = udg.Enabled;
                txbL4.Text = ven.Text; txbV4.Text = ale.Text; /**/ txbL4.Enabled = ven.Enabled; txbV4.Enabled = ale.Enabled;
                txbL5.Text = zac.Text; txbV5.Text = cor.Text; /**/ txbL5.Enabled = zac.Enabled; txbV5.Enabled = cor.Enabled;
                txbL6.Text = cim.Text; txbV6.Text = min.Text; /**/ txbL6.Enabled = cim.Enabled; txbV6.Enabled = min.Enabled;
                txbL7.Text = cel.Text; txbV7.Text = uae.Text; /**/ txbL7.Enabled = cel.Enabled; txbV7.Enabled = uae.Enabled;
            }
            else if (condicion == "A8")
            {
                txbL1.Text = uae.Text; txbV1.Text = lor.Text; /**/ txbL1.Enabled = uae.Enabled; txbV1.Enabled = lor.Enabled;
                txbL2.Text = min.Text; txbV2.Text = caf.Text; /**/ txbL2.Enabled = min.Enabled; txbV2.Enabled = caf.Enabled;
                txbL3.Text = atl.Text; txbV3.Text = udg.Text; /**/ txbL3.Enabled = atl.Enabled; txbV3.Enabled = udg.Enabled;
                txbL4.Text = ale.Text; txbV4.Text = tam.Text; /**/ txbL4.Enabled = ale.Enabled; txbV4.Enabled = tam.Enabled;
                txbL5.Text = cor.Text; txbV5.Text = cim.Text; /**/ txbL5.Enabled = cor.Enabled; txbV5.Enabled = cim.Enabled;
                txbL6.Text = dor.Text; txbV6.Text = zac.Text; /**/ txbL6.Enabled = dor.Enabled; txbV6.Enabled = zac.Enabled;
                txbL7.Text = cel.Text; txbV7.Text = ven.Text; /**/ txbL7.Enabled = cel.Enabled; txbV7.Enabled = ven.Enabled;
            }
            else if (condicion == "A9")
            {
                txbL1.Text = zac.Text; txbV1.Text = ven.Text; /**/ txbL1.Enabled = zac.Enabled; txbV1.Enabled = ven.Enabled;
                txbL2.Text = tam.Text; txbV2.Text = cel.Text; /**/ txbL2.Enabled = tam.Enabled; txbV2.Enabled = cel.Enabled;
                txbL3.Text = caf.Text; txbV3.Text = cor.Text; /**/ txbL3.Enabled = caf.Enabled; txbV3.Enabled = cor.Enabled;
                txbL4.Text = lor.Text; txbV4.Text = min.Text; /**/ txbL4.Enabled = lor.Enabled; txbV4.Enabled = min.Enabled;
                txbL5.Text = udg.Text; txbV5.Text = uae.Text; /**/ txbL5.Enabled = udg.Enabled; txbV5.Enabled = uae.Enabled;
                txbL6.Text = atl.Text; txbV6.Text = ale.Text; /**/ txbL6.Enabled = atl.Enabled; txbV6.Enabled = ale.Enabled;
                txbL7.Text = cim.Text; txbV7.Text = dor.Text; /**/ txbL7.Enabled = cim.Enabled; txbV7.Enabled = dor.Enabled;
            }
            else if (condicion == "A10")
            {
                txbL1.Text = dor.Text; txbV1.Text = atl.Text; /**/ txbL1.Enabled = dor.Enabled; txbV1.Enabled = atl.Enabled;
                txbL2.Text = uae.Text; txbV2.Text = caf.Text; /**/ txbL2.Enabled = uae.Enabled; txbV2.Enabled = caf.Enabled;
                txbL3.Text = min.Text; txbV3.Text = udg.Text; /**/ txbL3.Enabled = min.Enabled; txbV3.Enabled = udg.Enabled;
                txbL4.Text = ven.Text; txbV4.Text = tam.Text; /**/ txbL4.Enabled = ven.Enabled; txbV4.Enabled = tam.Enabled;
                txbL5.Text = zac.Text; txbV5.Text = cim.Text; /**/ txbL5.Enabled = zac.Enabled; txbV5.Enabled = cim.Enabled;
                txbL6.Text = cor.Text; txbV6.Text = ale.Text; /**/ txbL6.Enabled = cor.Enabled; txbV6.Enabled = ale.Enabled;
                txbL7.Text = cel.Text; txbV7.Text = lor.Text; /**/ txbL7.Enabled = cel.Enabled; txbV7.Enabled = lor.Enabled;
            }
            else if (condicion == "A11")
            {
                txbL1.Text = atl.Text; txbV1.Text = cel.Text; /**/ txbL1.Enabled = atl.Enabled; txbV1.Enabled = cel.Enabled;
                txbL2.Text = ale.Text; txbV2.Text = min.Text; /**/ txbL2.Enabled = ale.Enabled; txbV2.Enabled = min.Enabled;
                txbL3.Text = lor.Text; txbV3.Text = dor.Text; /**/ txbL3.Enabled = lor.Enabled; txbV3.Enabled = dor.Enabled;
                txbL4.Text = caf.Text; txbV4.Text = ven.Text; /**/ txbL4.Enabled = caf.Enabled; txbV4.Enabled = ven.Enabled;
                txbL5.Text = cim.Text; txbV5.Text = uae.Text; /**/ txbL5.Enabled = cim.Enabled; txbV5.Enabled = uae.Enabled;
                txbL6.Text = udg.Text; txbV6.Text = cor.Text; /**/ txbL6.Enabled = udg.Enabled; txbV6.Enabled = cor.Enabled;
                txbL7.Text = tam.Text; txbV7.Text = zac.Text; /**/ txbL7.Enabled = tam.Enabled; txbV7.Enabled = zac.Enabled;
            }
            else if (condicion == "A12")
            {
                txbL1.Text = lor.Text; txbV1.Text = tam.Text; /**/ txbL1.Enabled = lor.Enabled; txbV1.Enabled = tam.Enabled;
                txbL2.Text = cor.Text; txbV2.Text = min.Text; /**/ txbL2.Enabled = cor.Enabled; txbV2.Enabled = min.Enabled;
                txbL3.Text = ven.Text; txbV3.Text = atl.Text; /**/ txbL3.Enabled = ven.Enabled; txbV3.Enabled = atl.Enabled;
                txbL4.Text = cel.Text; txbV4.Text = caf.Text; /**/ txbL4.Enabled = cel.Enabled; txbV4.Enabled = caf.Enabled;
                txbL5.Text = dor.Text; txbV5.Text = ale.Text; /**/ txbL5.Enabled = dor.Enabled; txbV5.Enabled = ale.Enabled;
                txbL6.Text = cim.Text; txbV6.Text = udg.Text; /**/ txbL6.Enabled = cim.Enabled; txbV6.Enabled = udg.Enabled;
                txbL7.Text = zac.Text; txbV7.Text = uae.Text; /**/ txbL7.Enabled = zac.Enabled; txbV7.Enabled = uae.Enabled;
            }
            else if (condicion == "A13")
            {
                txbL1.Text = min.Text; txbV1.Text = dor.Text; /**/ txbL1.Enabled = min.Enabled; txbV1.Enabled = dor.Enabled;
                txbL2.Text = uae.Text; txbV2.Text = tam.Text; /**/ txbL2.Enabled = uae.Enabled; txbV2.Enabled = tam.Enabled;
                txbL3.Text = atl.Text; txbV3.Text = cim.Text; /**/ txbL3.Enabled = atl.Enabled; txbV3.Enabled = cim.Enabled;
                txbL4.Text = cor.Text; txbV4.Text = ven.Text; /**/ txbL4.Enabled = cor.Enabled; txbV4.Enabled = ven.Enabled;
                txbL5.Text = ale.Text; txbV5.Text = cel.Text; /**/ txbL5.Enabled = ale.Enabled; txbV5.Enabled = cel.Enabled;
                txbL6.Text = caf.Text; txbV6.Text = zac.Text; /**/ txbL6.Enabled = caf.Enabled; txbV6.Enabled = zac.Enabled;
                txbL7.Text = udg.Text; txbV7.Text = lor.Text; /**/ txbL7.Enabled = udg.Enabled; txbV7.Enabled = lor.Enabled;
            }
            #endregion
        }           

    }
}
