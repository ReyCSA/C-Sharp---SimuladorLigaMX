using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador.Class.Mex
{
    class Partidos
    {
        datos Odatos = new datos();

        public Partidos()
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
                for (int j = 1; j <= 19; j++)
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
                for (int j = 1; j <= 19; j++)
                {
                    total += Convert.ToInt32(T.Rows[0].Cells[j].Value is DBNull ? 0 : T.Rows[0].Cells[j].Value);
                    Torneo.SelectedIndex = 0;
                    Jornada.SelectedIndex = total;
                }
            }
        }

        public void Pendiente(DataGridView TPen, string condicion, Label ame, Label atl, Label caz, Label gua, Label leo, Label jua, Label mon, Label mty, Label nec, Label pac, Label pue, Label pum, Label qro, Label san, Label sal, Label tig, Label tij, Label tol, Label vrz)
        {
            Odatos.consultar("select Club, " + condicion + " from Partidos;", "Partidos"); 
            TPen.DataSource = Odatos.ds.Tables["Partidos"]; 
            TPen.Refresh();

            #region Se habilita los textbox si el equipo aun no juega
            for (int i = 0; i <= 18; i++)
            {
                if (TPen.Rows[i].Cells[0].Value.ToString() == "América")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") ame.Enabled = true;
                    else ame.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "Atlas")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") atl.Enabled = true;
                    else atl.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "Cruz Azul")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") caz.Enabled = true;
                    else caz.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "Guadalajara")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") gua.Enabled = true;
                    else gua.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "León")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") leo.Enabled = true;
                    else leo.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "Juárez")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") jua.Enabled = true;
                    else jua.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "Morelia")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") mon.Enabled = true;
                    else mon.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "Monterrey")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") mty.Enabled = true;
                    else mty.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "Necaxa")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") nec.Enabled = true;
                    else nec.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "Pachuca")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") pac.Enabled = true;
                    else pac.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "Puebla")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") pue.Enabled = true;
                    else pue.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "Querétaro")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") qro.Enabled = true;
                    else qro.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "Santos")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") san.Enabled = true;
                    else san.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "A. San Luis")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") sal.Enabled = true;
                    else sal.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "Tigres")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") tig.Enabled = true;
                    else tig.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "Tijuana")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") tij.Enabled = true;
                    else tij.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "Toluca")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") tol.Enabled = true;
                    else tol.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "UNAM")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") pum.Enabled = true;
                    else pum.Enabled = false;
                }
                else if (TPen.Rows[i].Cells[0].Value.ToString() == "Veracruz")
                {
                    if (TPen.Rows[i].Cells[1].Value.ToString() == "0") vrz.Enabled = true;
                    else vrz.Enabled = false;
                }
            }
            #endregion
        }

        //ACTualiza Pendientes y GF
        public void ActPen(Label Pjornada, Label ame, Label atl, Label caz, Label gua, Label leo, Label jua, Label mon, Label mty, Label nec, Label pac, Label pue, Label pum, Label qro, Label san, Label sal, Label tig, Label tij, Label tol, Label vrz)
        {
            #region Actualizar Pendientes
            if (ame.Text == "P" || ame.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "América");
                ame.Enabled = false;
            }
            if (atl.Text == "P" || atl.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Atlas");
                atl.Enabled = false;
            }
            if (sal.Text == "P" || sal.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "A. San Luis");
                sal.Enabled = false;
            }
            if (caz.Text == "P" || caz.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Cruz Azul");
                caz.Enabled = false;
            }
            if (gua.Text == "P" || gua.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Guadalajara");
                gua.Enabled = false;
            }
            if (leo.Text == "P" || leo.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "León");
                leo.Enabled = false;
            }
            if (jua.Text == "P" || jua.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Juárez");
                jua.Enabled = false;
            }
            if (mon.Text == "P" || mon.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Morelia");
                mon.Enabled = false;
            }
            if (mty.Text == "P" || mty.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Monterrey");
                mty.Enabled = false;
            }
            if (nec.Text == "P" || nec.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Necaxa");
                nec.Enabled = false;
            }
            if (pac.Text == "P" || pac.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Pachuca");
                pac.Enabled = false;
            }
            if (pue.Text == "P" || pue.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Puebla");
                pue.Enabled = false;
            }
            if (qro.Text == "P" || qro.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Querétaro");
                qro.Enabled = false;
            }
            if (san.Text == "P" || san.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Santos");
                san.Enabled = false;
            }
            if (tig.Text == "P" || tig.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Tigres");
                tig.Enabled = false;
            }
            if (tij.Text == "P" || tij.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Tijuana");
                tij.Enabled = false;
            }
            if (tol.Text == "P" || tol.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Toluca");
                tol.Enabled = false;
            }
            if (pum.Text == "P" || pum.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "UNAM");
                pum.Enabled = false;
            }
            if (vrz.Text == "P" || vrz.Text == "p")
            {
                Odatos.aPen("Partidos", Pjornada.Text, "Veracruz");
                vrz.Enabled = false;
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

        public void ActGF(Label Pjornada, Label ame, Label atl, Label caz, Label gua, Label leo, Label jua, Label mon, Label mty, Label nec, Label pac, Label pue, Label pum, Label qro, Label san, Label sal, Label tig, Label tij, Label tol, Label vrz, Label Came, Label Cpac, Label Catl, Label Cpue, Label Ccaz, Label Cpum, Label Cgua, Label Cqro, Label Cleo, Label Csan, Label Clob, Label Csal, Label Cmon, Label Ctig, Label Cmty, Label Ctij, Label Cnec, Label Ctol, Label Cvrz)
        {
            #region Actualiza los Goles a favor, en Contra además de G, E, P
            if (ame.Text != "" && ame.Text != "P")
                actualiza(Pjornada, ame, Came, "América");
            if (atl.Text != "" && atl.Text != "P")
                actualiza(Pjornada, atl, Catl, "Atlas");
            if (sal.Text != "" && sal.Text != "P")
                actualiza(Pjornada, sal, Csal, "A. San Luis");
            if (caz.Text != "" && caz.Text != "P")
                actualiza(Pjornada, caz, Ccaz, "Cruz Azul");
            if (gua.Text != "" && gua.Text != "P")
                actualiza(Pjornada, gua, Cgua, "Guadalajara");
            if (leo.Text != "" && leo.Text != "P")
                actualiza(Pjornada, leo, Cleo, "León");
            if (jua.Text != "" && jua.Text != "P")
                actualiza(Pjornada, jua, Clob, "Juárez");
            if (mon.Text != "" && mon.Text != "P")
                actualiza(Pjornada, mon, Cmon, "Morelia");
            if (mty.Text != "" && mty.Text != "P")
                actualiza(Pjornada, mty, Cmty, "Monterrey");
            if (nec.Text != "" && nec.Text != "P")
                actualiza(Pjornada, nec, Cnec, "Necaxa");
            if (pac.Text != "" && pac.Text != "P")
                actualiza(Pjornada, pac, Cpac, "Pachuca");
            if (pue.Text != "" && pue.Text != "P")
                actualiza(Pjornada, pue, Cpue, "Puebla");
            if (qro.Text != "" && qro.Text != "P")
                actualiza(Pjornada, qro, Cqro, "Quéretaro");
            if (san.Text != "" && san.Text != "P")
                actualiza(Pjornada, san, Csan, "Santos");
            if (tig.Text != "" && tig.Text != "P")
                actualiza(Pjornada, tig, Ctig, "Tigres");
            if (tij.Text != "" && tij.Text != "P")
                actualiza(Pjornada, tij, Ctij, "Tijuana");
            if (tol.Text != "" && tol.Text != "P")
                actualiza(Pjornada, tol, Ctol, "Toluca");
            if (pum.Text != "" && pum.Text != "P")
                actualiza(Pjornada, pum, Cpum, "UNAM");
            if (vrz.Text != "" && vrz.Text != "P")
                actualiza(Pjornada, vrz, Cvrz, "Veracruz");
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

        public void ActTmpGF(Label Pjornada, Label ame, Label atl, Label caz, Label gua, Label leo, Label jua, Label mon, Label mty, Label nec, Label pac, Label pue, Label pum, Label qro, Label san, Label sal, Label tig, Label tij, Label tol, Label vrz, Label Came, Label Cpac, Label Catl, Label Cpue, Label Ccaz, Label Cpum, Label Cgua, Label Cqro, Label Cleo, Label Csan, Label Clob, Label Csal, Label Cmon, Label Ctig, Label Cmty, Label Ctij, Label Cnec, Label Ctol, Label Cvrz)
        {
            #region Actualiza los Goles a favor, en Contra además de G, E, P
            if (ame.Text != "" && ame.Text != "P")
                Tmpactualiza(Pjornada, ame, Came, "América");
            if (atl.Text != "" && atl.Text != "P")
                Tmpactualiza(Pjornada, atl, Catl, "Atlas");
            if (sal.Text != "" && sal.Text != "P")
                Tmpactualiza(Pjornada, sal, Csal, "A. San Luis");
            if (caz.Text != "" && caz.Text != "P")
                Tmpactualiza(Pjornada, caz, Ccaz, "Cruz Azul");
            if (gua.Text != "" && gua.Text != "P")
                Tmpactualiza(Pjornada, gua, Cgua, "Guadalajara");
            if (leo.Text != "" && leo.Text != "P")
                Tmpactualiza(Pjornada, leo, Cleo, "León");
            if (jua.Text != "" && jua.Text != "P")
                Tmpactualiza(Pjornada, jua, Clob, "Juárez");
            if (mon.Text != "" && mon.Text != "P")
                Tmpactualiza(Pjornada, mon, Cmon, "Morelia");
            if (mty.Text != "" && mty.Text != "P")
                Tmpactualiza(Pjornada, mty, Cmty, "Monterrey");
            if (nec.Text != "" && nec.Text != "P")
                Tmpactualiza(Pjornada, nec, Cnec, "Necaxa");
            if (pac.Text != "" && pac.Text != "P")
                Tmpactualiza(Pjornada, pac, Cpac, "Pachuca");
            if (pue.Text != "" && pue.Text != "P")
                Tmpactualiza(Pjornada, pue, Cpue, "Puebla");
            if (qro.Text != "" && qro.Text != "P")
                Tmpactualiza(Pjornada, qro, Cqro, "Quéretaro");
            if (san.Text != "" && san.Text != "P")
                Tmpactualiza(Pjornada, san, Csan, "Santos");
            if (tig.Text != "" && tig.Text != "P")
                Tmpactualiza(Pjornada, tig, Ctig, "Tigres");
            if (tij.Text != "" && tij.Text != "P")
                Tmpactualiza(Pjornada, tij, Ctij, "Tijuana");
            if (tol.Text != "" && tol.Text != "P")
                Tmpactualiza(Pjornada, tol, Ctol, "Toluca");
            if (pum.Text != "" && pum.Text != "P")
                Tmpactualiza(Pjornada, pum, Cpum, "UNAM");
            if (vrz.Text != "" && vrz.Text != "P")
                Tmpactualiza(Pjornada, vrz, Cvrz, "Veracruz");
            #endregion
        }

        //HABilita textbox        
        public void HabGF(DataGridView TGF, string condicion, Label ame, Label atl, Label caz, Label gua, Label leo, Label jua, Label mon, Label mty, Label nec, Label pac, Label pue, Label pum, Label qro, Label san, Label sal, Label tig, Label tij, Label tol, Label vrz)
        {
            Odatos.consultar("select Club, " + condicion + " from GF;", "GF");
            TGF.DataSource = Odatos.ds.Tables["GF"];
            TGF.Refresh();

            #region Muestra los Goles a favor en la consulta
            for (int i = 0; i <= 18; i++)
            {
                if (TGF.Rows[i].Cells[0].Value.ToString() == "América")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        ame.Enabled = true;
                        ame.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "Atlas")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        atl.Enabled = true;
                        atl.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "Cruz Azul")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        caz.Enabled = true;
                        caz.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "Guadalajara")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        gua.Enabled = true;
                        gua.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "León")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        leo.Enabled = true;
                        leo.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "Juárez")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        jua.Enabled = true;
                        jua.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "Morelia")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        mon.Enabled = true;
                        mon.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "Monterrey")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        mty.Enabled = true;
                        mty.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "Necaxa")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        nec.Enabled = true;
                        nec.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "Pachuca")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        pac.Enabled = true;
                        pac.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "Puebla")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        pue.Enabled = true;
                        pue.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "Querétaro")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        qro.Enabled = true;
                        qro.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "Santos")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        san.Enabled = true;
                        san.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "A. San Luis")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        sal.Enabled = true;
                        sal.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "Tigres")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        tig.Enabled = true;
                        tig.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "Tijuana")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        tij.Enabled = true;
                        tij.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "Toluca")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        tol.Enabled = true;
                        tol.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "UNAM")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        pum.Enabled = true;
                        pum.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TGF.Rows[i].Cells[0].Value.ToString() == "Veracruz")
                {
                    if (TGF.Rows[i].Cells[1].Value.ToString() != "")
                    {
                        vrz.Enabled = true;
                        vrz.Text = TGF.Rows[i].Cells[1].Value.ToString();
                    }
                }
            }
            #endregion
        }


        public void HabPen(DataGridView TP, string condicion, Label ame, Label atl, Label caz, Label gua, Label leo, Label jua, Label mon, Label mty, Label nec, Label pac, Label pue, Label pum, Label qro, Label san, Label sal, Label tig, Label tij, Label tol, Label vrz)
        {
            Odatos.consultar("select Club, " + condicion + " from Partidos;", "Partidos");
            TP.DataSource = Odatos.ds.Tables["Partidos"];
            TP.Refresh();

            #region Muestra los Pendientes en la consulta
            for (int i = 0; i <= 18; i++)
            {
                if (TP.Rows[i].Cells[0].Value.ToString() == "América")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        ame.Enabled = true;
                        ame.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Atlas")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        atl.Enabled = true;
                        atl.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Cruz Azul")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        caz.Enabled = true;
                        caz.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Guadalajara")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        gua.Enabled = true;
                        gua.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "León")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        leo.Enabled = true;
                        leo.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Juárez")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        jua.Enabled = true;
                        jua.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Morelia")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        mon.Enabled = true;
                        mon.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Monterrey")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        mty.Enabled = true;
                        mty.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Necaxa")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        nec.Enabled = true;
                        nec.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Pachuca")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        pac.Enabled = true;
                        pac.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Puebla")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        pue.Enabled = true;
                        pue.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Querétaro")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        qro.Enabled = true;
                        qro.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Santos")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        san.Enabled = true;
                        san.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "A. San Luis")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        sal.Enabled = true;
                        sal.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Tigres")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        tig.Enabled = true;
                        tig.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Tijuana")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        tij.Enabled = true;
                        tij.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Toluca")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        tol.Enabled = true;
                        tol.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "UNAM")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        pum.Enabled = true;
                        pum.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
                else if (TP.Rows[i].Cells[0].Value.ToString() == "Veracruz")
                {
                    if (TP.Rows[i].Cells[1].Value.ToString() == "P" || TP.Rows[i].Cells[1].Value.ToString() == "p")
                    {
                        vrz.Enabled = true;
                        vrz.Text = TP.Rows[i].Cells[1].Value.ToString();
                    }
                }
            }
            #endregion
        }
        
        #endregion

        public void AsociarText(string condicion, Label ame, Label atl, Label caz, Label gua, Label leo, Label jua, Label mon, Label mty, Label nec, Label pac, Label pue, Label pum, Label qro, Label san, Label sal, Label tig, Label tij, Label tol, Label vrz, TextBox txbL1, TextBox txbL2, TextBox txbL3, TextBox txbL4, TextBox txbL5, TextBox txbL6, TextBox txbL7, TextBox txbL8, TextBox txbL9, TextBox txbV1, TextBox txbV2, TextBox txbV3, TextBox txbV4, TextBox txbV5, TextBox txbV6, TextBox txbV7, TextBox txbV8, TextBox txbV9, Label Came, Label Cpac, Label Catl, Label Cpue, Label Ccaz, Label Cpum, Label Cgua, Label Cqro, Label Cleo, Label Csan, Label Cjua, Label Csal, Label Cmon, Label Ctig, Label Cmty, Label Ctij, Label Cnec, Label Ctol, Label Cvrz)
        {
            #region Asocia los TextBox a los Label
            if (condicion == "A1")
            {
                vrz.Text = "P"; Cvrz.Text = "P";
                pue.Text = txbL1.Text; tij.Text = txbV1.Text; /**/ Cpue.Text = txbV1.Text; Ctij.Text = txbL1.Text; /**/ txbL1.Enabled = pue.Enabled; txbV1.Enabled = tij.Enabled;
                atl.Text = txbL2.Text; jua.Text = txbV2.Text; /**/ Catl.Text = txbV2.Text; Cjua.Text = txbL2.Text; /**/ txbL2.Enabled = atl.Enabled; txbV2.Enabled = jua.Enabled;
                sal.Text = txbL3.Text; pum.Text = txbV3.Text; /**/ Csal.Text = txbV3.Text; Cpum.Text = txbL3.Text; /**/ txbL3.Enabled = sal.Enabled; txbV3.Enabled = pum.Enabled;
                pac.Text = txbL4.Text; leo.Text = txbV4.Text; /**/ Cpac.Text = txbV4.Text; Cleo.Text = txbL4.Text; /**/ txbL4.Enabled = pac.Enabled; txbV4.Enabled = leo.Enabled;
                tig.Text = txbL5.Text; mon.Text = txbV5.Text; /**/ Ctig.Text = txbV5.Text; Cmon.Text = txbL5.Text; /**/ txbL5.Enabled = tig.Enabled; txbV5.Enabled = mon.Enabled;
                ame.Text = txbL6.Text; mty.Text = txbV6.Text; /**/ Came.Text = txbV6.Text; Cmty.Text = txbL6.Text; /**/ txbL6.Enabled = ame.Enabled; txbV6.Enabled = mty.Enabled;
                nec.Text = txbL7.Text; caz.Text = txbV7.Text; /**/ Cnec.Text = txbV7.Text; Ccaz.Text = txbL7.Text; /**/ txbL7.Enabled = nec.Enabled; txbV7.Enabled = caz.Enabled;
                tol.Text = txbL8.Text; qro.Text = txbV8.Text; /**/ Ctol.Text = txbV8.Text; Cqro.Text = txbL8.Text; /**/ txbL8.Enabled = tol.Enabled; txbV8.Enabled = qro.Enabled;
                san.Text = txbL9.Text; gua.Text = txbV9.Text; /**/ Csan.Text = txbV9.Text; Cgua.Text = txbL9.Text; /**/ txbL9.Enabled = san.Enabled; txbV9.Enabled = gua.Enabled;
            }
            else if (condicion == "A2")
            {
                pue.Text = "P"; Cpue.Text = "P";
                mon.Text = txbL1.Text; atl.Text = txbV1.Text; /**/ Cmon.Text = txbV1.Text; Catl.Text = txbL1.Text; /**/ txbL1.Enabled = mon.Enabled; txbV1.Enabled = atl.Enabled;
                vrz.Text = txbL2.Text; pac.Text = txbV2.Text; /**/ Cvrz.Text = txbV2.Text; Cpac.Text = txbL2.Text; /**/ txbL2.Enabled = vrz.Enabled; txbV2.Enabled = pac.Enabled;
                leo.Text = txbL3.Text; ame.Text = txbV3.Text; /**/ Cleo.Text = txbV3.Text; Came.Text = txbL3.Text; /**/ txbL3.Enabled = leo.Enabled; txbV3.Enabled = ame.Enabled;
                tij.Text = txbL4.Text; qro.Text = txbV4.Text; /**/ Ctij.Text = txbV4.Text; Cqro.Text = txbL4.Text; /**/ txbL4.Enabled = tij.Enabled; txbV4.Enabled = qro.Enabled;
                caz.Text = txbL5.Text; tol.Text = txbV5.Text; /**/ Ccaz.Text = txbV5.Text; Ctol.Text = txbL5.Text; /**/ txbL5.Enabled = caz.Enabled; txbV5.Enabled = tol.Enabled;
                pum.Text = txbL6.Text; nec.Text = txbV6.Text; /**/ Cpum.Text = txbV6.Text; Cnec.Text = txbL6.Text; /**/ txbL6.Enabled = pum.Enabled; txbV6.Enabled = nec.Enabled;
                sal.Text = txbL7.Text; mty.Text = txbV7.Text; /**/ Csal.Text = txbV7.Text; Cmty.Text = txbL7.Text; /**/ txbL7.Enabled = sal.Enabled; txbV7.Enabled = mty.Enabled;
                gua.Text = txbL8.Text; tig.Text = txbV8.Text; /**/ Cgua.Text = txbV8.Text; Ctig.Text = txbL8.Text; /**/ txbL8.Enabled = gua.Enabled; txbV8.Enabled = tig.Enabled;
                san.Text = txbL9.Text; jua.Text = txbV9.Text; /**/ Csan.Text = txbV9.Text; Cjua.Text = txbL9.Text; /**/ txbL9.Enabled = san.Enabled; txbV9.Enabled = jua.Enabled;
            }
            else if (condicion == "A3")
            {
                sal.Text = "P"; Csal.Text = "P";
                pue.Text = txbL1.Text; gua.Text = txbV1.Text; /**/ Cpue.Text = txbV1.Text; Cgua.Text = txbL1.Text; /**/ txbL1.Enabled = pue.Enabled; txbV1.Enabled = gua.Enabled;
                atl.Text = txbL2.Text; san.Text = txbV2.Text; /**/ Catl.Text = txbV2.Text; Csan.Text = txbL2.Text; /**/ txbL2.Enabled = atl.Enabled; txbV2.Enabled = san.Enabled;
                qro.Text = txbL3.Text; caz.Text = txbV3.Text; /**/ Cqro.Text = txbV3.Text; Ccaz.Text = txbL3.Text; /**/ txbL3.Enabled = qro.Enabled; txbV3.Enabled = caz.Enabled;
                ame.Text = txbL4.Text; tij.Text = txbV4.Text; /**/ Came.Text = txbV4.Text; Ctij.Text = txbL4.Text; /**/ txbL4.Enabled = ame.Enabled; txbV4.Enabled = tij.Enabled;
                pac.Text = txbL5.Text; mon.Text = txbV5.Text; /**/ Cpac.Text = txbV5.Text; Cmon.Text = txbL5.Text; /**/ txbL5.Enabled = pac.Enabled; txbV5.Enabled = mon.Enabled;
                mty.Text = txbL6.Text; leo.Text = txbV6.Text; /**/ Cmty.Text = txbV6.Text; Cleo.Text = txbL6.Text; /**/ txbL6.Enabled = mty.Enabled; txbV6.Enabled = leo.Enabled;
                nec.Text = txbL7.Text; vrz.Text = txbV7.Text; /**/ Cnec.Text = txbV7.Text; Cvrz.Text = txbL7.Text; /**/ txbL7.Enabled = nec.Enabled; txbV7.Enabled = vrz.Enabled;
                pum.Text = txbL8.Text; tig.Text = txbV8.Text; /**/ Cpum.Text = txbV8.Text; Ctig.Text = txbL8.Text; /**/ txbL8.Enabled = pum.Enabled; txbV8.Enabled = tig.Enabled;
                jua.Text = txbL9.Text; tol.Text = txbV9.Text; /**/ Cjua.Text = txbV9.Text; Ctol.Text = txbL9.Text; /**/ txbL9.Enabled = jua.Enabled; txbV9.Enabled = tol.Enabled;
            }
            else if (condicion == "A4")
            {
                leo.Text = "P"; Cleo.Text = "P";
                mon.Text = txbL1.Text; mty.Text = txbV1.Text; /**/ Cmon.Text = txbV1.Text; Cmty.Text = txbL1.Text; /**/ txbL1.Enabled = mon.Enabled; txbV1.Enabled = mty.Enabled;
                vrz.Text = txbL2.Text; atl.Text = txbV2.Text; /**/ Cvrz.Text = txbV2.Text; Catl.Text = txbL2.Text; /**/ txbL2.Enabled = vrz.Enabled; txbV2.Enabled = atl.Enabled;
                tij.Text = txbL3.Text; pum.Text = txbV3.Text; /**/ Ctij.Text = txbV3.Text; Cpum.Text = txbL3.Text; /**/ txbL3.Enabled = tij.Enabled; txbV3.Enabled = pum.Enabled;
                qro.Text = txbL4.Text; pac.Text = txbV4.Text; /**/ Cqro.Text = txbV4.Text; Cpac.Text = txbL4.Text; /**/ txbL4.Enabled = qro.Enabled; txbV4.Enabled = pac.Enabled;
                caz.Text = txbL5.Text; jua.Text = txbV5.Text; /**/ Ccaz.Text = txbV5.Text; Cjua.Text = txbL5.Text; /**/ txbL5.Enabled = caz.Enabled; txbV5.Enabled = jua.Enabled;
                tig.Text = txbL6.Text; nec.Text = txbV6.Text; /**/ Ctig.Text = txbV6.Text; Cnec.Text = txbL6.Text; /**/ txbL6.Enabled = tig.Enabled; txbV6.Enabled = nec.Enabled;
                gua.Text = txbL7.Text; sal.Text = txbV7.Text; /**/ Cgua.Text = txbV7.Text; Csal.Text = txbL7.Text; /**/ txbL7.Enabled = gua.Enabled; txbV7.Enabled = sal.Enabled;
                tol.Text = txbL8.Text; ame.Text = txbV8.Text; /**/ Ctol.Text = txbV8.Text; Came.Text = txbL8.Text; /**/ txbL8.Enabled = tol.Enabled; txbV8.Enabled = ame.Enabled;
                san.Text = txbL9.Text; pue.Text = txbV9.Text; /**/ Csan.Text = txbV9.Text; Cpue.Text = txbL9.Text; /**/ txbL9.Enabled = san.Enabled; txbV9.Enabled = pue.Enabled;
            }
            else if (condicion == "A5")
            {
                tij.Text = "P"; Ctij.Text = "P";
                pue.Text = txbL1.Text; pac.Text = txbV1.Text; /**/ Cpue.Text = txbV1.Text; Cpac.Text = txbL1.Text; /**/ txbL1.Enabled = pue.Enabled; txbV1.Enabled = pac.Enabled;
                atl.Text = txbL2.Text; caz.Text = txbV2.Text; /**/ Catl.Text = txbV2.Text; Ccaz.Text = txbL2.Text; /**/ txbL2.Enabled = atl.Enabled; txbV2.Enabled = caz.Enabled;
                sal.Text = txbL3.Text; tig.Text = txbV3.Text; /**/ Csal.Text = txbV3.Text; Ctig.Text = txbL3.Text; /**/ txbL3.Enabled = sal.Enabled; txbV3.Enabled = tig.Enabled;
                leo.Text = txbL4.Text; gua.Text = txbV4.Text; /**/ Cleo.Text = txbV4.Text; Cgua.Text = txbL4.Text; /**/ txbL4.Enabled = leo.Enabled; txbV4.Enabled = gua.Enabled;
                ame.Text = txbL5.Text; mon.Text = txbV5.Text; /**/ Came.Text = txbV5.Text; Cmon.Text = txbL5.Text; /**/ txbL5.Enabled = ame.Enabled; txbV5.Enabled = mon.Enabled;
                mty.Text = txbL6.Text; tol.Text = txbV6.Text; /**/ Cmty.Text = txbV6.Text; Ctol.Text = txbL6.Text; /**/ txbL6.Enabled = mty.Enabled; txbV6.Enabled = tol.Enabled;
                pum.Text = txbL7.Text; vrz.Text = txbV7.Text; /**/ Cpum.Text = txbV7.Text; Cvrz.Text = txbL7.Text; /**/ txbL7.Enabled = pum.Enabled; txbV7.Enabled = vrz.Enabled;
                nec.Text = txbL8.Text; san.Text = txbV8.Text; /**/ Cnec.Text = txbV8.Text; Csan.Text = txbL8.Text; /**/ txbL8.Enabled = nec.Enabled; txbV8.Enabled = san.Enabled;
                jua.Text = txbL9.Text; qro.Text = txbV9.Text; /**/ Cjua.Text = txbV9.Text; Cqro.Text = txbL9.Text; /**/ txbL9.Enabled = jua.Enabled; txbV9.Enabled = qro.Enabled;
            }
            else if (condicion == "A6")
            {
                jua.Text = "P"; Cjua.Text = "P";
                vrz.Text = txbL1.Text; sal.Text = txbV1.Text; /**/ Cvrz.Text = txbV1.Text; Csal.Text = txbL1.Text; /**/ txbL1.Enabled = vrz.Enabled; txbV1.Enabled = sal.Enabled;
                mon.Text = txbL2.Text; pum.Text = txbV2.Text; /**/ Cmon.Text = txbV2.Text; Cpum.Text = txbL2.Text; /**/ txbL2.Enabled = mon.Enabled; txbV2.Enabled = pum.Enabled;
                san.Text = txbL3.Text; mty.Text = txbV3.Text; /**/ Csan.Text = txbV3.Text; Cmty.Text = txbL3.Text; /**/ txbL3.Enabled = san.Enabled; txbV3.Enabled = mty.Enabled;
                qro.Text = txbL4.Text; leo.Text = txbV4.Text; /**/ Cqro.Text = txbV4.Text; Cleo.Text = txbL4.Text; /**/ txbL4.Enabled = qro.Enabled; txbV4.Enabled = leo.Enabled;
                pac.Text = txbL5.Text; atl.Text = txbV5.Text; /**/ Cpac.Text = txbV5.Text; Catl.Text = txbL5.Text; /**/ txbL5.Enabled = pac.Enabled; txbV5.Enabled = atl.Enabled;
                caz.Text = txbL6.Text; pue.Text = txbV6.Text; /**/ Ccaz.Text = txbV6.Text; Cpue.Text = txbL6.Text; /**/ txbL6.Enabled = caz.Enabled; txbV6.Enabled = pue.Enabled;
                tig.Text = txbL7.Text; ame.Text = txbV7.Text; /**/ Ctig.Text = txbV7.Text; Came.Text = txbL7.Text; /**/ txbL7.Enabled = tig.Enabled; txbV7.Enabled = ame.Enabled;
                tol.Text = txbL8.Text; tij.Text = txbV8.Text; /**/ Ctol.Text = txbV8.Text; Ctij.Text = txbL8.Text; /**/ txbL8.Enabled = tol.Enabled; txbV8.Enabled = tij.Enabled;
                gua.Text = txbL9.Text; nec.Text = txbV9.Text; /**/ Cgua.Text = txbV9.Text; Cnec.Text = txbL9.Text; /**/ txbL9.Enabled = gua.Enabled; txbV9.Enabled = nec.Enabled;
            }
            else if (condicion == "A7")
            {
                gua.Text = "P"; Cgua.Text = "P";
                vrz.Text = txbL1.Text; qro.Text = txbV1.Text; /**/ Cvrz.Text = txbV1.Text; Cqro.Text = txbL1.Text; /**/ txbL1.Enabled = vrz.Enabled; txbV1.Enabled = qro.Enabled;
                sal.Text = txbL2.Text; mon.Text = txbV2.Text; /**/ Csal.Text = txbV2.Text; Cmon.Text = txbL2.Text; /**/ txbL2.Enabled = sal.Enabled; txbV2.Enabled = mon.Enabled;
                atl.Text = txbL3.Text; tig.Text = txbV3.Text; /**/ Catl.Text = txbV3.Text; Ctig.Text = txbL3.Text; /**/ txbL3.Enabled = atl.Enabled; txbV3.Enabled = tig.Enabled;
                ame.Text = txbL4.Text; pac.Text = txbV4.Text; /**/ Came.Text = txbV4.Text; Cpac.Text = txbL4.Text; /**/ txbL4.Enabled = ame.Enabled; txbV4.Enabled = pac.Enabled;
                leo.Text = txbL5.Text; san.Text = txbV5.Text; /**/ Cleo.Text = txbV5.Text; Csan.Text = txbL5.Text; /**/ txbL5.Enabled = leo.Enabled; txbV5.Enabled = san.Enabled;
                tij.Text = txbL6.Text; caz.Text = txbV6.Text; /**/ Ctij.Text = txbV6.Text; Ccaz.Text = txbL6.Text; /**/ txbL6.Enabled = tij.Enabled; txbV6.Enabled = caz.Enabled;
                nec.Text = txbL7.Text; tol.Text = txbV7.Text; /**/ Cnec.Text = txbV7.Text; Ctol.Text = txbL7.Text; /**/ txbL7.Enabled = nec.Enabled; txbV7.Enabled = tol.Enabled;
                pue.Text = txbL8.Text; jua.Text = txbV8.Text; /**/ Cpue.Text = txbV8.Text; Cjua.Text = txbL8.Text; /**/ txbL8.Enabled = pue.Enabled; txbV8.Enabled = jua.Enabled;
                mty.Text = txbL9.Text; pum.Text = txbV9.Text; /**/ Cmty.Text = txbV9.Text; Cpum.Text = txbL9.Text; /**/ txbL9.Enabled = mty.Enabled; txbV9.Enabled = pum.Enabled;
            }
            else if (condicion == "A8")
            {
                san.Text = "P"; Csan.Text = "P";
                mon.Text = txbL1.Text; vrz.Text = txbV1.Text; /**/ Cmon.Text = txbV1.Text; Cvrz.Text = txbL1.Text; /**/ txbL1.Enabled = mon.Enabled; txbV1.Enabled = vrz.Enabled;
                atl.Text = txbL2.Text; ame.Text = txbV2.Text; /**/ Catl.Text = txbV2.Text; Came.Text = txbL2.Text; /**/ txbL2.Enabled = atl.Enabled; txbV2.Enabled = ame.Enabled;
                nec.Text = txbL3.Text; tij.Text = txbV3.Text; /**/ Cnec.Text = txbV3.Text; Ctij.Text = txbL3.Text; /**/ txbL3.Enabled = nec.Enabled; txbV3.Enabled = tij.Enabled;
                tig.Text = txbL4.Text; leo.Text = txbV4.Text; /**/ Ctig.Text = txbV4.Text; Cleo.Text = txbL4.Text; /**/ txbL4.Enabled = tig.Enabled; txbV4.Enabled = leo.Enabled;
                pac.Text = txbL5.Text; sal.Text = txbV5.Text; /**/ Cpac.Text = txbV5.Text; Csal.Text = txbL5.Text; /**/ txbL5.Enabled = pac.Enabled; txbV5.Enabled = sal.Enabled;
                caz.Text = txbL6.Text; gua.Text = txbV6.Text; /**/ Ccaz.Text = txbV6.Text; Cgua.Text = txbL6.Text; /**/ txbL6.Enabled = caz.Enabled; txbV6.Enabled = gua.Enabled;
                pum.Text = txbL7.Text; tol.Text = txbV7.Text; /**/ Cpum.Text = txbV7.Text; Ctol.Text = txbL7.Text; /**/ txbL7.Enabled = pum.Enabled; txbV7.Enabled = tol.Enabled;
                qro.Text = txbL8.Text; pue.Text = txbV8.Text; /**/ Cqro.Text = txbV8.Text; Cpue.Text = txbL8.Text; /**/ txbL8.Enabled = qro.Enabled; txbV8.Enabled = pue.Enabled;
                jua.Text = txbL9.Text; mty.Text = txbV9.Text; /**/ Cjua.Text = txbV9.Text; Cmty.Text = txbL9.Text; /**/ txbL9.Enabled = jua.Enabled; txbV9.Enabled = mty.Enabled;
            }
            else if (condicion == "A9")
            {
                qro.Text = "P"; Cqro.Text = "P";
                pue.Text = txbL1.Text; sal.Text = txbV1.Text; /**/ Cpue.Text = txbV1.Text; Csal.Text = txbL1.Text; /**/ txbL1.Enabled = pue.Enabled; txbV1.Enabled = sal.Enabled;
                vrz.Text = txbL2.Text; caz.Text = txbV2.Text; /**/ Cvrz.Text = txbV2.Text; Ccaz.Text = txbL2.Text; /**/ txbL2.Enabled = vrz.Enabled; txbV2.Enabled = caz.Enabled;
                tij.Text = txbL3.Text; tig.Text = txbV3.Text; /**/ Ctij.Text = txbV3.Text; Ctig.Text = txbL3.Text; /**/ txbL3.Enabled = tij.Enabled; txbV3.Enabled = tig.Enabled;
                mty.Text = txbL4.Text; nec.Text = txbV4.Text; /**/ Cmty.Text = txbV4.Text; Cnec.Text = txbL4.Text; /**/ txbL4.Enabled = mty.Enabled; txbV4.Enabled = nec.Enabled;
                leo.Text = txbL5.Text; jua.Text = txbV5.Text; /**/ Cleo.Text = txbV5.Text; Cjua.Text = txbL5.Text; /**/ txbL5.Enabled = leo.Enabled; txbV5.Enabled = jua.Enabled;
                gua.Text = txbL6.Text; atl.Text = txbV6.Text; /**/ Cgua.Text = txbV6.Text; Catl.Text = txbL6.Text; /**/ txbL6.Enabled = gua.Enabled; txbV6.Enabled = atl.Enabled;
                tol.Text = txbL7.Text; mon.Text = txbV7.Text; /**/ Ctol.Text = txbV7.Text; Cmon.Text = txbL7.Text; /**/ txbL7.Enabled = tol.Enabled; txbV7.Enabled = mon.Enabled;
                san.Text = txbL8.Text; pac.Text = txbV8.Text; /**/ Csan.Text = txbV8.Text; Cpac.Text = txbL8.Text; /**/ txbL8.Enabled = san.Enabled; txbV8.Enabled = pac.Enabled;
                ame.Text = txbL9.Text; pum.Text = txbV9.Text; /**/ Came.Text = txbV9.Text; Cpum.Text = txbL9.Text; /**/ txbL9.Enabled = ame.Enabled; txbV9.Enabled = pum.Enabled;
            }
            else if (condicion == "A10")
            {
                tig.Text = "P"; Ctig.Text = "P";
                mon.Text = txbL1.Text; gua.Text = txbV1.Text; /**/ Cmon.Text = txbV1.Text; Cgua.Text = txbL1.Text; /**/ txbL1.Enabled = mon.Enabled; txbV1.Enabled = gua.Enabled;
                atl.Text = txbL2.Text; tol.Text = txbV2.Text; /**/ Catl.Text = txbV2.Text; Ctol.Text = txbL2.Text; /**/ txbL2.Enabled = atl.Enabled; txbV2.Enabled = tol.Enabled;
                sal.Text = txbL3.Text; san.Text = txbV3.Text; /**/ Csal.Text = txbV3.Text; Csan.Text = txbL3.Text; /**/ txbL3.Enabled = sal.Enabled; txbV3.Enabled = san.Enabled;
                nec.Text = txbL4.Text; leo.Text = txbV4.Text; /**/ Cnec.Text = txbV4.Text; Cleo.Text = txbL4.Text; /**/ txbL4.Enabled = nec.Enabled; txbV4.Enabled = leo.Enabled;
                mty.Text = txbL5.Text; pue.Text = txbV5.Text; /**/ Cmty.Text = txbV5.Text; Cpue.Text = txbL5.Text; /**/ txbL5.Enabled = mty.Enabled; txbV5.Enabled = pue.Enabled;
                pac.Text = txbL6.Text; tij.Text = txbV6.Text; /**/ Cpac.Text = txbV6.Text; Ctij.Text = txbL6.Text; /**/ txbL6.Enabled = pac.Enabled; txbV6.Enabled = tij.Enabled;
                ame.Text = txbL7.Text; qro.Text = txbV7.Text; /**/ Came.Text = txbV7.Text; Cqro.Text = txbL7.Text; /**/ txbL7.Enabled = ame.Enabled; txbV7.Enabled = qro.Enabled;
                pum.Text = txbL8.Text; caz.Text = txbV8.Text; /**/ Cpum.Text = txbV8.Text; Ccaz.Text = txbL8.Text; /**/ txbL8.Enabled = pum.Enabled; txbV8.Enabled = caz.Enabled;
                jua.Text = txbL9.Text; vrz.Text = txbV9.Text; /**/ Cjua.Text = txbV9.Text; Cvrz.Text = txbL9.Text; /**/ txbL9.Enabled = jua.Enabled; txbV9.Enabled = vrz.Enabled;
            }
            else if (condicion == "A11")
            {
                pum.Text = "P"; Cpum.Text = "P";
                qro.Text = txbL1.Text; nec.Text = txbV1.Text; /**/ Cqro.Text = txbV1.Text; Cnec.Text = txbL1.Text; /**/ txbL1.Enabled = qro.Enabled; txbV1.Enabled = nec.Enabled;
                tig.Text = txbL2.Text; pue.Text = txbV2.Text; /**/ Ctig.Text = txbV2.Text; Cpue.Text = txbL2.Text; /**/ txbL2.Enabled = tig.Enabled; txbV2.Enabled = pue.Enabled;
                gua.Text = txbL3.Text; pac.Text = txbV3.Text; /**/ Cgua.Text = txbV3.Text; Cpac.Text = txbL3.Text; /**/ txbL3.Enabled = gua.Enabled; txbV3.Enabled = pac.Enabled;
                leo.Text = txbL4.Text; atl.Text = txbV4.Text; /**/ Cleo.Text = txbV4.Text; Catl.Text = txbL4.Text; /**/ txbL4.Enabled = leo.Enabled; txbV4.Enabled = atl.Enabled;
                jua.Text = txbL5.Text; ame.Text = txbV5.Text; /**/ Cjua.Text = txbV5.Text; Came.Text = txbL5.Text; /**/ txbL5.Enabled = jua.Enabled; txbV5.Enabled = ame.Enabled;
                san.Text = txbL6.Text; vrz.Text = txbV6.Text; /**/ Csan.Text = txbV6.Text; Cvrz.Text = txbL6.Text; /**/ txbL6.Enabled = san.Enabled; txbV6.Enabled = vrz.Enabled;
                tij.Text = txbL7.Text; mon.Text = txbV7.Text; /**/ Ctij.Text = txbV7.Text; Cmon.Text = txbL7.Text; /**/ txbL7.Enabled = tij.Enabled; txbV7.Enabled = mon.Enabled;
                caz.Text = txbL8.Text; mty.Text = txbV8.Text; /**/ Ccaz.Text = txbV8.Text; Cmty.Text = txbL8.Text; /**/ txbL8.Enabled = caz.Enabled; txbV8.Enabled = mty.Enabled;
                tol.Text = txbL9.Text; sal.Text = txbV9.Text; /**/ Ctol.Text = txbV9.Text; Csal.Text = txbL9.Text; /**/ txbL9.Enabled = tol.Enabled; txbV9.Enabled = sal.Enabled;
            }
            else if (condicion == "A12")
            {
                mon.Text = "P"; Cmon.Text = "P";
                pue.Text = txbL1.Text; leo.Text = txbV1.Text; /**/ Cpue.Text = txbV1.Text; Cleo.Text = txbL1.Text; /**/ txbL1.Enabled = pue.Enabled; txbV1.Enabled = leo.Enabled;
                atl.Text = txbL2.Text; qro.Text = txbV2.Text; /**/ Catl.Text = txbV2.Text; Cqro.Text = txbL2.Text; /**/ txbL2.Enabled = atl.Enabled; txbV2.Enabled = qro.Enabled;
                pac.Text = txbL3.Text; caz.Text = txbV3.Text; /**/ Cpac.Text = txbV3.Text; Ccaz.Text = txbL3.Text; /**/ txbL3.Enabled = pac.Enabled; txbV3.Enabled = caz.Enabled;
                mty.Text = txbL4.Text; tig.Text = txbV4.Text; /**/ Cmty.Text = txbV4.Text; Ctig.Text = txbL4.Text; /**/ txbL4.Enabled = mty.Enabled; txbV4.Enabled = tig.Enabled;
                nec.Text = txbL5.Text; jua.Text = txbV5.Text; /**/ Cnec.Text = txbV5.Text; Cjua.Text = txbL5.Text; /**/ txbL5.Enabled = nec.Enabled; txbV5.Enabled = jua.Enabled;
                ame.Text = txbL6.Text; gua.Text = txbV6.Text; /**/ Came.Text = txbV6.Text; Cgua.Text = txbL6.Text; /**/ txbL6.Enabled = ame.Enabled; txbV6.Enabled = gua.Enabled;
                pum.Text = txbL7.Text; san.Text = txbV7.Text; /**/ Cpum.Text = txbV7.Text; Csan.Text = txbL7.Text; /**/ txbL7.Enabled = pum.Enabled; txbV7.Enabled = san.Enabled;
                sal.Text = txbL8.Text; tij.Text = txbV8.Text; /**/ Csal.Text = txbV8.Text; Ctij.Text = txbL8.Text; /**/ txbL8.Enabled = sal.Enabled; txbV8.Enabled = tij.Enabled;
                vrz.Text = txbL9.Text; tol.Text = txbV9.Text; /**/ Cvrz.Text = txbV9.Text; Ctol.Text = txbL9.Text; /**/ txbL9.Enabled = vrz.Enabled; txbV9.Enabled = tol.Enabled;
            }
            else if (condicion == "A13")
            {
                pac.Text = "P"; Cpac.Text = "P";
                mon.Text = txbL1.Text; nec.Text = txbV1.Text; /**/ Cmon.Text = txbV1.Text; Cnec.Text = txbL1.Text; /**/ txbL1.Enabled = mon.Enabled; txbV1.Enabled = nec.Enabled;
                tij.Text = txbL2.Text; atl.Text = txbV2.Text; /**/ Ctij.Text = txbV2.Text; Catl.Text = txbL2.Text; /**/ txbL2.Enabled = tij.Enabled; txbV2.Enabled = atl.Enabled;
                leo.Text = txbL3.Text; vrz.Text = txbV3.Text; /**/ Cleo.Text = txbV3.Text; Cvrz.Text = txbL3.Text; /**/ txbL3.Enabled = leo.Enabled; txbV3.Enabled = vrz.Enabled;
                caz.Text = txbL4.Text; ame.Text = txbV4.Text; /**/ Ccaz.Text = txbV4.Text; Came.Text = txbL4.Text; /**/ txbL4.Enabled = caz.Enabled; txbV4.Enabled = ame.Enabled;
                tig.Text = txbL5.Text; san.Text = txbV5.Text; /**/ Ctig.Text = txbV5.Text; Csan.Text = txbL5.Text; /**/ txbL5.Enabled = tig.Enabled; txbV5.Enabled = san.Enabled;
                gua.Text = txbL6.Text; pum.Text = txbV6.Text; /**/ Cgua.Text = txbV6.Text; Cpum.Text = txbL6.Text; /**/ txbL6.Enabled = gua.Enabled; txbV6.Enabled = pum.Enabled;
                tol.Text = txbL7.Text; pue.Text = txbV7.Text; /**/ Ctol.Text = txbV7.Text; Cpue.Text = txbL7.Text; /**/ txbL7.Enabled = tol.Enabled; txbV7.Enabled = pue.Enabled;
                jua.Text = txbL8.Text; sal.Text = txbV8.Text; /**/ Cjua.Text = txbV8.Text; Csal.Text = txbL8.Text; /**/ txbL8.Enabled = jua.Enabled; txbV8.Enabled = sal.Enabled;
                qro.Text = txbL9.Text; mty.Text = txbV9.Text; /**/ Cqro.Text = txbV9.Text; Cmty.Text = txbL9.Text; /**/ txbL9.Enabled = qro.Enabled; txbV9.Enabled = mty.Enabled;
            }
            else if (condicion == "A14")
            {
                tol.Text = "P"; Ctol.Text = "P";
                pue.Text = txbL1.Text; atl.Text = txbV1.Text; /**/ Cpue.Text = txbV1.Text; Catl.Text = txbL1.Text; /**/ txbL1.Enabled = pue.Enabled; txbV1.Enabled = atl.Enabled;
                vrz.Text = txbL2.Text; tig.Text = txbV2.Text; /**/ Cvrz.Text = txbV2.Text; Ctig.Text = txbL2.Text; /**/ txbL2.Enabled = vrz.Enabled; txbV2.Enabled = tig.Enabled;
                san.Text = txbL3.Text; tij.Text = txbV3.Text; /**/ Csan.Text = txbV3.Text; Ctij.Text = txbL3.Text; /**/ txbL3.Enabled = san.Enabled; txbV3.Enabled = tij.Enabled;
                caz.Text = txbL4.Text; mon.Text = txbV4.Text; /**/ Ccaz.Text = txbV4.Text; Cmon.Text = txbL4.Text; /**/ txbL4.Enabled = caz.Enabled; txbV4.Enabled = mon.Enabled;
                pac.Text = txbL5.Text; jua.Text = txbV5.Text; /**/ Cpac.Text = txbV5.Text; Cjua.Text = txbL5.Text; /**/ txbL5.Enabled = pac.Enabled; txbV5.Enabled = jua.Enabled;
                nec.Text = txbL6.Text; ame.Text = txbV6.Text; /**/ Cnec.Text = txbV6.Text; Came.Text = txbL6.Text; /**/ txbL6.Enabled = nec.Enabled; txbV6.Enabled = ame.Enabled;
                pum.Text = txbL7.Text; leo.Text = txbV7.Text; /**/ Cpum.Text = txbV7.Text; Cleo.Text = txbL7.Text; /**/ txbL7.Enabled = pum.Enabled; txbV7.Enabled = leo.Enabled;
                sal.Text = txbL8.Text; qro.Text = txbV8.Text; /**/ Csal.Text = txbV8.Text; Cqro.Text = txbL8.Text; /**/ txbL8.Enabled = sal.Enabled; txbV8.Enabled = qro.Enabled;
                mty.Text = txbL9.Text; gua.Text = txbV9.Text; /**/ Cmty.Text = txbV9.Text; Cgua.Text = txbL9.Text; /**/ txbL9.Enabled = mty.Enabled; txbV9.Enabled = gua.Enabled;
            }
            else if (condicion == "A15")
            {
                mty.Text = "P"; Cmty.Text = "P";
                mon.Text = txbL1.Text; san.Text = txbV1.Text; /**/ Cmon.Text = txbV1.Text; Csan.Text = txbL1.Text; /**/ txbL1.Enabled = mon.Enabled; txbV1.Enabled = san.Enabled;
                atl.Text = txbL2.Text; nec.Text = txbV2.Text; /**/ Catl.Text = txbV2.Text; Cnec.Text = txbL2.Text; /**/ txbL2.Enabled = atl.Enabled; txbV2.Enabled = nec.Enabled;
                tij.Text = txbL3.Text; vrz.Text = txbV3.Text; /**/ Ctij.Text = txbV3.Text; Cvrz.Text = txbL3.Text; /**/ txbL3.Enabled = tij.Enabled; txbV3.Enabled = vrz.Enabled;
                qro.Text = txbL4.Text; pum.Text = txbV4.Text; /**/ Cqro.Text = txbV4.Text; Cpum.Text = txbL4.Text; /**/ txbL4.Enabled = qro.Enabled; txbV4.Enabled = pum.Enabled;
                ame.Text = txbL5.Text; pue.Text = txbV5.Text; /**/ Came.Text = txbV5.Text; Cpue.Text = txbL5.Text; /**/ txbL5.Enabled = ame.Enabled; txbV5.Enabled = pue.Enabled;
                leo.Text = txbL6.Text; sal.Text = txbV6.Text; /**/ Cleo.Text = txbV6.Text; Csal.Text = txbL6.Text; /**/ txbL6.Enabled = leo.Enabled; txbV6.Enabled = sal.Enabled;
                tig.Text = txbL7.Text; caz.Text = txbV7.Text; /**/ Ctig.Text = txbV7.Text; Ccaz.Text = txbL7.Text; /**/ txbL7.Enabled = tig.Enabled; txbV7.Enabled = caz.Enabled;
                tol.Text = txbL8.Text; pac.Text = txbV8.Text; /**/ Ctol.Text = txbV8.Text; Cpac.Text = txbL8.Text; /**/ txbL8.Enabled = tol.Enabled; txbV8.Enabled = pac.Enabled;
                jua.Text = txbL9.Text; gua.Text = txbV9.Text; /**/ Cjua.Text = txbV9.Text; Cgua.Text = txbL9.Text; /**/ txbL9.Enabled = jua.Enabled; txbV9.Enabled = gua.Enabled;
            }
            else if (condicion == "A16")
            {
                nec.Text = "P"; Cnec.Text = "P";
                san.Text = txbL1.Text; qro.Text = txbV1.Text; /**/ Csan.Text = txbV1.Text; Cqro.Text = txbL1.Text; /**/ txbL1.Enabled = san.Enabled; txbV1.Enabled = qro.Enabled;
                vrz.Text = txbL2.Text; pue.Text = txbV2.Text; /**/ Cvrz.Text = txbV2.Text; Cpue.Text = txbL2.Text; /**/ txbL2.Enabled = vrz.Enabled; txbV2.Enabled = pue.Enabled;
                sal.Text = txbL3.Text; ame.Text = txbV3.Text; /**/ Csal.Text = txbV3.Text; Came.Text = txbL3.Text; /**/ txbL3.Enabled = sal.Enabled; txbV3.Enabled = ame.Enabled;
                pum.Text = txbL4.Text; atl.Text = txbV4.Text; /**/ Cpum.Text = txbV4.Text; Catl.Text = txbL4.Text; /**/ txbL4.Enabled = pum.Enabled; txbV4.Enabled = atl.Enabled;
                pac.Text = txbL5.Text; mty.Text = txbV5.Text; /**/ Cpac.Text = txbV5.Text; Cmty.Text = txbL5.Text; /**/ txbL5.Enabled = pac.Enabled; txbV5.Enabled = mty.Enabled;
                gua.Text = txbL6.Text; tij.Text = txbV6.Text; /**/ Cgua.Text = txbV6.Text; Ctij.Text = txbL6.Text; /**/ txbL6.Enabled = gua.Enabled; txbV6.Enabled = tij.Enabled;
                tig.Text = txbL7.Text; tol.Text = txbV7.Text; /**/ Ctig.Text = txbV7.Text; Ctol.Text = txbL7.Text; /**/ txbL7.Enabled = tig.Enabled; txbV7.Enabled = tol.Enabled;
                mon.Text = txbL8.Text; jua.Text = txbV8.Text; /**/ Cmon.Text = txbV8.Text; Cjua.Text = txbL8.Text; /**/ txbL8.Enabled = mon.Enabled; txbV8.Enabled = jua.Enabled;
                caz.Text = txbL9.Text; leo.Text = txbV9.Text; /**/ Ccaz.Text = txbV9.Text; Cleo.Text = txbL9.Text; /**/ txbL9.Enabled = caz.Enabled; txbV9.Enabled = leo.Enabled;
            }
            else if (condicion == "A17")
            {
                caz.Text = "P"; Ccaz.Text = "P";
                pue.Text = txbL1.Text; pum.Text = txbV1.Text; /**/ Cpue.Text = txbV1.Text; Cpum.Text = txbL1.Text; /**/ txbL1.Enabled = pue.Enabled; txbV1.Enabled = pum.Enabled;
                atl.Text = txbL2.Text; sal.Text = txbV2.Text; /**/ Catl.Text = txbV2.Text; Csal.Text = txbL2.Text; /**/ txbL2.Enabled = atl.Enabled; txbV2.Enabled = sal.Enabled;
                qro.Text = txbL3.Text; tig.Text = txbV3.Text; /**/ Cqro.Text = txbV3.Text; Ctig.Text = txbL3.Text; /**/ txbL3.Enabled = qro.Enabled; txbV3.Enabled = tig.Enabled;
                ame.Text = txbL4.Text; san.Text = txbV4.Text; /**/ Came.Text = txbV4.Text; Csan.Text = txbL4.Text; /**/ txbL4.Enabled = ame.Enabled; txbV4.Enabled = san.Enabled;
                mty.Text = txbL5.Text; vrz.Text = txbV5.Text; /**/ Cmty.Text = txbV5.Text; Cvrz.Text = txbL5.Text; /**/ txbL5.Enabled = mty.Enabled; txbV5.Enabled = vrz.Enabled;
                nec.Text = txbL6.Text; pac.Text = txbV6.Text; /**/ Cnec.Text = txbV6.Text; Cpac.Text = txbL6.Text; /**/ txbL6.Enabled = nec.Enabled; txbV6.Enabled = pac.Enabled;
                tol.Text = txbL7.Text; gua.Text = txbV7.Text; /**/ Ctol.Text = txbV7.Text; Cgua.Text = txbL7.Text; /**/ txbL7.Enabled = tol.Enabled; txbV7.Enabled = gua.Enabled;
                jua.Text = txbL8.Text; tij.Text = txbV8.Text; /**/ Cjua.Text = txbV8.Text; Ctij.Text = txbL8.Text; /**/ txbL8.Enabled = jua.Enabled; txbV8.Enabled = tij.Enabled;
                leo.Text = txbL9.Text; mon.Text = txbV9.Text; /**/ Cleo.Text = txbV9.Text; Cmon.Text = txbL9.Text; /**/ txbL9.Enabled = leo.Enabled; txbV9.Enabled = mon.Enabled;
            }
            else if (condicion == "A18")
            {
                atl.Text = "P"; Catl.Text = "P";
                mon.Text = txbL1.Text; pue.Text = txbV1.Text; /**/ Cmon.Text = txbV1.Text; Cpue.Text = txbL1.Text; /**/ txbL1.Enabled = mon.Enabled; txbV1.Enabled = pue.Enabled;
                vrz.Text = txbL2.Text; ame.Text = txbV2.Text; /**/ Cvrz.Text = txbV2.Text; Came.Text = txbL2.Text; /**/ txbL2.Enabled = vrz.Enabled; txbV2.Enabled = ame.Enabled;
                tij.Text = txbL3.Text; mty.Text = txbV3.Text; /**/ Ctij.Text = txbV3.Text; Cmty.Text = txbL3.Text; /**/ txbL3.Enabled = tij.Enabled; txbV3.Enabled = mty.Enabled;
                sal.Text = txbL4.Text; nec.Text = txbV4.Text; /**/ Csal.Text = txbV4.Text; Cnec.Text = txbL4.Text; /**/ txbL4.Enabled = sal.Enabled; txbV4.Enabled = nec.Enabled;
                tig.Text = txbL5.Text; pac.Text = txbV5.Text; /**/ Ctig.Text = txbV5.Text; Cpac.Text = txbL5.Text; /**/ txbL5.Enabled = tig.Enabled; txbV5.Enabled = pac.Enabled;
                gua.Text = txbL6.Text; qro.Text = txbV6.Text; /**/ Cgua.Text = txbV6.Text; Cqro.Text = txbL6.Text; /**/ txbL6.Enabled = gua.Enabled; txbV6.Enabled = qro.Enabled;
                leo.Text = txbL7.Text; tol.Text = txbV7.Text; /**/ Cleo.Text = txbV7.Text; Ctol.Text = txbL7.Text; /**/ txbL7.Enabled = leo.Enabled; txbV7.Enabled = tol.Enabled;
                pum.Text = txbL8.Text; jua.Text = txbV8.Text; /**/ Cpum.Text = txbV8.Text; Cjua.Text = txbL8.Text; /**/ txbL8.Enabled = pum.Enabled; txbV8.Enabled = jua.Enabled;
                san.Text = txbL9.Text; caz.Text = txbV9.Text; /**/ Csan.Text = txbV9.Text; Ccaz.Text = txbL9.Text; /**/ txbL9.Enabled = san.Enabled; txbV9.Enabled = caz.Enabled;
            }
            else if (condicion == "A19")
            {
                ame.Text = "P"; Came.Text = "P";
                pue.Text = txbL1.Text; nec.Text = txbV1.Text; /**/ Cpue.Text = txbV1.Text; Cnec.Text = txbL1.Text; /**/ txbL1.Enabled = pue.Enabled; txbV1.Enabled = nec.Enabled;
                tij.Text = txbL2.Text; leo.Text = txbV2.Text; /**/ Ctij.Text = txbV2.Text; Cleo.Text = txbL2.Text; /**/ txbL2.Enabled = tij.Enabled; txbV2.Enabled = leo.Enabled;
                qro.Text = txbL3.Text; mon.Text = txbV3.Text; /**/ Cqro.Text = txbV3.Text; Cmon.Text = txbL3.Text; /**/ txbL3.Enabled = qro.Enabled; txbV3.Enabled = mon.Enabled;
                caz.Text = txbL4.Text; sal.Text = txbV4.Text; /**/ Ccaz.Text = txbV4.Text; Csal.Text = txbL4.Text; /**/ txbL4.Enabled = caz.Enabled; txbV4.Enabled = sal.Enabled;
                mty.Text = txbL5.Text; atl.Text = txbV5.Text; /**/ Cmty.Text = txbV5.Text; Catl.Text = txbL5.Text; /**/ txbL5.Enabled = mty.Enabled; txbV5.Enabled = atl.Enabled;
                pac.Text = txbL6.Text; pum.Text = txbV6.Text; /**/ Cpac.Text = txbV6.Text; Cpum.Text = txbL6.Text; /**/ txbL6.Enabled = pac.Enabled; txbV6.Enabled = pum.Enabled;
                gua.Text = txbL7.Text; vrz.Text = txbV7.Text; /**/ Cgua.Text = txbV7.Text; Cvrz.Text = txbL7.Text; /**/ txbL7.Enabled = gua.Enabled; txbV7.Enabled = vrz.Enabled;
                tol.Text = txbL8.Text; san.Text = txbV8.Text; /**/ Ctol.Text = txbV8.Text; Csan.Text = txbL8.Text; /**/ txbL8.Enabled = tol.Enabled; txbV8.Enabled = san.Enabled;
                jua.Text = txbL9.Text; tig.Text = txbV9.Text; /**/ Cjua.Text = txbV9.Text; Ctig.Text = txbL9.Text; /**/ txbL9.Enabled = jua.Enabled; txbV9.Enabled = tig.Enabled;
            }
            else if (condicion == "C1")
            {

            }
            else if (condicion == "C2") { }
            else if (condicion == "C3") { }
            else if (condicion == "C4") { }
            else if (condicion == "C5") { }
            else if (condicion == "C6") { }
            else if (condicion == "C7") { }
            else if (condicion == "C8") { }
            else if (condicion == "C9") { }
            else if (condicion == "C10") { }
            else if (condicion == "C11") { }
            else if (condicion == "C12") { }
            else if (condicion == "C13") { }
            else if (condicion == "C14") { }
            else if (condicion == "C15") { }
            else if (condicion == "C16") { }
            else if (condicion == "C17") { }
            else if (condicion == "C18") { }

            #endregion
        }

        public void AsociarLabel(string condicion, Label ame, Label atl, Label caz, Label gua, Label leo, Label jua, Label mon, Label mty, Label nec, Label pac, Label pue, Label pum, Label qro, Label san, Label sal, Label tig, Label tij, Label tol, Label vrz, TextBox txbL1, TextBox txbL2, TextBox txbL3, TextBox txbL4, TextBox txbL5, TextBox txbL6, TextBox txbL7, TextBox txbL8, TextBox txbL9, TextBox txbV1, TextBox txbV2, TextBox txbV3, TextBox txbV4, TextBox txbV5, TextBox txbV6, TextBox txbV7, TextBox txbV8, TextBox txbV9)
        {
            #region Asociar Label a Textbox
            if (condicion == "A1")
            {
                vrz.Text = "P";
                txbL1.Text = pue.Text; txbV1.Text = tij.Text; /**/ txbL1.Enabled = pue.Enabled; txbV1.Enabled = tij.Enabled;
                txbL2.Text = atl.Text; txbV2.Text = jua.Text; /**/ txbL2.Enabled = atl.Enabled; txbV2.Enabled = jua.Enabled;
                txbL3.Text = sal.Text; txbV3.Text = pum.Text; /**/ txbL3.Enabled = sal.Enabled; txbV3.Enabled = pum.Enabled;
                txbL4.Text = pac.Text; txbV4.Text = leo.Text; /**/ txbL4.Enabled = pac.Enabled; txbV4.Enabled = leo.Enabled;
                txbL5.Text = tig.Text; txbV5.Text = mon.Text; /**/ txbL5.Enabled = tig.Enabled; txbV5.Enabled = mon.Enabled;
                txbL6.Text = ame.Text; txbV6.Text = mty.Text; /**/ txbL6.Enabled = ame.Enabled; txbV6.Enabled = mty.Enabled;
                txbL7.Text = nec.Text; txbV7.Text = caz.Text; /**/ txbL7.Enabled = nec.Enabled; txbV7.Enabled = caz.Enabled;
                txbL8.Text = tol.Text; txbV8.Text = qro.Text; /**/ txbL8.Enabled = tol.Enabled; txbV8.Enabled = qro.Enabled;
                txbL9.Text = san.Text; txbV9.Text = gua.Text; /**/ txbL9.Enabled = san.Enabled; txbV9.Enabled = gua.Enabled;
            }
            else if (condicion == "A2")
            {
                pue.Text = "P";
                txbL1.Text = mon.Text; txbV1.Text = atl.Text; /**/ txbL1.Enabled = mon.Enabled; txbV1.Enabled = atl.Enabled;
                txbL2.Text = vrz.Text; txbV2.Text = pac.Text; /**/ txbL2.Enabled = vrz.Enabled; txbV2.Enabled = pac.Enabled;
                txbL3.Text = leo.Text; txbV3.Text = ame.Text; /**/ txbL3.Enabled = leo.Enabled; txbV3.Enabled = ame.Enabled;
                txbL4.Text = tij.Text; txbV4.Text = qro.Text; /**/ txbL4.Enabled = tij.Enabled; txbV4.Enabled = qro.Enabled;
                txbL5.Text = caz.Text; txbV5.Text = tol.Text; /**/ txbL5.Enabled = caz.Enabled; txbV5.Enabled = tol.Enabled;
                txbL6.Text = pum.Text; txbV6.Text = nec.Text; /**/ txbL6.Enabled = pum.Enabled; txbV6.Enabled = nec.Enabled;
                txbL7.Text = sal.Text; txbV7.Text = mty.Text; /**/ txbL7.Enabled = sal.Enabled; txbV7.Enabled = mty.Enabled;
                txbL8.Text = gua.Text; txbV8.Text = tig.Text; /**/ txbL8.Enabled = gua.Enabled; txbV8.Enabled = tig.Enabled;
                txbL9.Text = san.Text; txbV9.Text = jua.Text; /**/ txbL9.Enabled = san.Enabled; txbV9.Enabled = jua.Enabled;
            }
            else if (condicion == "A3")
            {
                sal.Text = "P";
                txbL1.Text = pue.Text; txbV1.Text = gua.Text; /**/ txbL1.Enabled = pue.Enabled; txbV1.Enabled = gua.Enabled;
                txbL2.Text = atl.Text; txbV2.Text = san.Text; /**/ txbL2.Enabled = atl.Enabled; txbV2.Enabled = san.Enabled;
                txbL3.Text = qro.Text; txbV3.Text = caz.Text; /**/ txbL3.Enabled = qro.Enabled; txbV3.Enabled = caz.Enabled;
                txbL4.Text = ame.Text; txbV4.Text = tij.Text; /**/ txbL4.Enabled = ame.Enabled; txbV4.Enabled = tij.Enabled;
                txbL5.Text = pac.Text; txbV5.Text = mon.Text; /**/ txbL5.Enabled = pac.Enabled; txbV5.Enabled = mon.Enabled;
                txbL6.Text = mty.Text; txbV6.Text = leo.Text; /**/ txbL6.Enabled = mty.Enabled; txbV6.Enabled = leo.Enabled;
                txbL7.Text = nec.Text; txbV7.Text = vrz.Text; /**/ txbL7.Enabled = nec.Enabled; txbV7.Enabled = vrz.Enabled;
                txbL8.Text = pum.Text; txbV8.Text = tig.Text; /**/ txbL8.Enabled = pum.Enabled; txbV8.Enabled = tig.Enabled;
                txbL9.Text = jua.Text; txbV9.Text = tol.Text; /**/ txbL9.Enabled = jua.Enabled; txbV9.Enabled = tol.Enabled;
            }
            else if (condicion == "A4")
            {
                leo.Text = "P";
                txbL1.Text = mon.Text; txbV1.Text = mty.Text; /**/ txbL1.Enabled = mon.Enabled; txbV1.Enabled = mty.Enabled;
                txbL2.Text = vrz.Text; txbV2.Text = atl.Text; /**/ txbL2.Enabled = vrz.Enabled; txbV2.Enabled = atl.Enabled;
                txbL3.Text = tij.Text; txbV3.Text = pum.Text; /**/ txbL3.Enabled = tij.Enabled; txbV3.Enabled = pum.Enabled;
                txbL4.Text = qro.Text; txbV4.Text = pac.Text; /**/ txbL4.Enabled = qro.Enabled; txbV4.Enabled = pac.Enabled;
                txbL5.Text = caz.Text; txbV5.Text = jua.Text; /**/ txbL5.Enabled = caz.Enabled; txbV5.Enabled = jua.Enabled;
                txbL6.Text = tig.Text; txbV6.Text = nec.Text; /**/ txbL6.Enabled = tig.Enabled; txbV6.Enabled = nec.Enabled;
                txbL7.Text = gua.Text; txbV7.Text = sal.Text; /**/ txbL7.Enabled = gua.Enabled; txbV7.Enabled = sal.Enabled;
                txbL8.Text = tol.Text; txbV8.Text = ame.Text; /**/ txbL8.Enabled = tol.Enabled; txbV8.Enabled = ame.Enabled;
                txbL9.Text = san.Text; txbV9.Text = pue.Text; /**/ txbL9.Enabled = san.Enabled; txbV9.Enabled = pue.Enabled;
            }
            else if (condicion == "A5")
            {
                tij.Text = "P";
                txbL1.Text = pue.Text; txbV1.Text = pac.Text; /**/ txbL1.Enabled = pue.Enabled; txbV1.Enabled = pac.Enabled;
                txbL2.Text = atl.Text; txbV2.Text = caz.Text; /**/ txbL2.Enabled = atl.Enabled; txbV2.Enabled = caz.Enabled;
                txbL3.Text = sal.Text; txbV3.Text = tig.Text; /**/ txbL3.Enabled = sal.Enabled; txbV3.Enabled = tig.Enabled;
                txbL4.Text = leo.Text; txbV4.Text = gua.Text; /**/ txbL4.Enabled = leo.Enabled; txbV4.Enabled = gua.Enabled;
                txbL5.Text = ame.Text; txbV5.Text = mon.Text; /**/ txbL5.Enabled = ame.Enabled; txbV5.Enabled = mon.Enabled;
                txbL6.Text = mty.Text; txbV6.Text = tol.Text; /**/ txbL6.Enabled = mty.Enabled; txbV6.Enabled = tol.Enabled;
                txbL7.Text = pum.Text; txbV7.Text = vrz.Text; /**/ txbL7.Enabled = pum.Enabled; txbV7.Enabled = vrz.Enabled;
                txbL8.Text = nec.Text; txbV8.Text = san.Text; /**/ txbL8.Enabled = nec.Enabled; txbV8.Enabled = san.Enabled;
                txbL9.Text = jua.Text; txbV9.Text = qro.Text; /**/ txbL9.Enabled = jua.Enabled; txbV9.Enabled = qro.Enabled;
            }
            else if (condicion == "A6")
            {
                jua.Text = "P";
                txbL1.Text = vrz.Text; txbV1.Text = sal.Text; /**/ txbL1.Enabled = vrz.Enabled; txbV1.Enabled = sal.Enabled;
                txbL2.Text = mon.Text; txbV2.Text = pum.Text; /**/ txbL2.Enabled = mon.Enabled; txbV2.Enabled = pum.Enabled;
                txbL3.Text = san.Text; txbV3.Text = mty.Text; /**/ txbL3.Enabled = san.Enabled; txbV3.Enabled = mty.Enabled;
                txbL4.Text = qro.Text; txbV4.Text = leo.Text; /**/ txbL4.Enabled = qro.Enabled; txbV4.Enabled = leo.Enabled;
                txbL5.Text = pac.Text; txbV5.Text = atl.Text; /**/ txbL5.Enabled = pac.Enabled; txbV5.Enabled = atl.Enabled;
                txbL6.Text = caz.Text; txbV6.Text = pue.Text; /**/ txbL6.Enabled = caz.Enabled; txbV6.Enabled = pue.Enabled;
                txbL7.Text = tig.Text; txbV7.Text = ame.Text; /**/ txbL7.Enabled = tig.Enabled; txbV7.Enabled = ame.Enabled;
                txbL8.Text = tol.Text; txbV8.Text = tij.Text; /**/ txbL8.Enabled = tol.Enabled; txbV8.Enabled = tij.Enabled;
                txbL9.Text = gua.Text; txbV9.Text = nec.Text; /**/ txbL9.Enabled = gua.Enabled; txbV9.Enabled = nec.Enabled;
            }
            else if (condicion == "A7")
            {
                gua.Text = "P";
                txbL1.Text = vrz.Text; txbV1.Text = qro.Text; /**/ txbL1.Enabled = vrz.Enabled; txbV1.Enabled = qro.Enabled;
                txbL2.Text = sal.Text; txbV2.Text = mon.Text; /**/ txbL2.Enabled = sal.Enabled; txbV2.Enabled = mon.Enabled;
                txbL3.Text = atl.Text; txbV3.Text = tig.Text; /**/ txbL3.Enabled = atl.Enabled; txbV3.Enabled = tig.Enabled;
                txbL4.Text = ame.Text; txbV4.Text = pac.Text; /**/ txbL4.Enabled = ame.Enabled; txbV4.Enabled = pac.Enabled;
                txbL5.Text = leo.Text; txbV5.Text = san.Text; /**/ txbL5.Enabled = leo.Enabled; txbV5.Enabled = san.Enabled;
                txbL6.Text = tij.Text; txbV6.Text = caz.Text; /**/ txbL6.Enabled = tij.Enabled; txbV6.Enabled = caz.Enabled;
                txbL7.Text = nec.Text; txbV7.Text = tol.Text; /**/ txbL7.Enabled = nec.Enabled; txbV7.Enabled = tol.Enabled;
                txbL8.Text = pue.Text; txbV8.Text = jua.Text; /**/ txbL8.Enabled = pue.Enabled; txbV8.Enabled = jua.Enabled;
                txbL9.Text = mty.Text; txbV9.Text = pum.Text; /**/ txbL9.Enabled = mty.Enabled; txbV9.Enabled = pum.Enabled;
            }
            else if (condicion == "A8")
            {
                san.Text = "P";
                txbL1.Text = mon.Text; txbV1.Text = vrz.Text; /**/ txbL1.Enabled = mon.Enabled; txbV1.Enabled = vrz.Enabled;
                txbL2.Text = atl.Text; txbV2.Text = ame.Text; /**/ txbL2.Enabled = atl.Enabled; txbV2.Enabled = ame.Enabled;
                txbL3.Text = nec.Text; txbV3.Text = tij.Text; /**/ txbL3.Enabled = nec.Enabled; txbV3.Enabled = tij.Enabled;
                txbL4.Text = tig.Text; txbV4.Text = leo.Text; /**/ txbL4.Enabled = tig.Enabled; txbV4.Enabled = leo.Enabled;
                txbL5.Text = pac.Text; txbV5.Text = sal.Text; /**/ txbL5.Enabled = pac.Enabled; txbV5.Enabled = sal.Enabled;
                txbL6.Text = caz.Text; txbV6.Text = gua.Text; /**/ txbL6.Enabled = caz.Enabled; txbV6.Enabled = gua.Enabled;
                txbL7.Text = pum.Text; txbV7.Text = tol.Text; /**/ txbL7.Enabled = pum.Enabled; txbV7.Enabled = tol.Enabled;
                txbL8.Text = qro.Text; txbV8.Text = pue.Text; /**/ txbL8.Enabled = qro.Enabled; txbV8.Enabled = pue.Enabled;
                txbL9.Text = jua.Text; txbV9.Text = mty.Text; /**/ txbL9.Enabled = jua.Enabled; txbV9.Enabled = mty.Enabled;
            }
            else if (condicion == "A9")
            {
                qro.Text = "P";
                txbL1.Text = pue.Text; txbV1.Text = sal.Text; /**/ txbL1.Enabled = pue.Enabled; txbV1.Enabled = sal.Enabled;
                txbL2.Text = vrz.Text; txbV2.Text = caz.Text; /**/ txbL2.Enabled = vrz.Enabled; txbV2.Enabled = caz.Enabled;
                txbL3.Text = tij.Text; txbV3.Text = tig.Text; /**/ txbL3.Enabled = tij.Enabled; txbV3.Enabled = tig.Enabled;
                txbL4.Text = mty.Text; txbV4.Text = nec.Text; /**/ txbL4.Enabled = mty.Enabled; txbV4.Enabled = nec.Enabled;
                txbL5.Text = leo.Text; txbV5.Text = jua.Text; /**/ txbL5.Enabled = leo.Enabled; txbV5.Enabled = jua.Enabled;
                txbL6.Text = gua.Text; txbV6.Text = atl.Text; /**/ txbL6.Enabled = gua.Enabled; txbV6.Enabled = atl.Enabled;
                txbL7.Text = tol.Text; txbV7.Text = mon.Text; /**/ txbL7.Enabled = tol.Enabled; txbV7.Enabled = mon.Enabled;
                txbL8.Text = san.Text; txbV8.Text = pac.Text; /**/ txbL8.Enabled = san.Enabled; txbV8.Enabled = pac.Enabled;
                txbL9.Text = ame.Text; txbV9.Text = pum.Text; /**/ txbL9.Enabled = ame.Enabled; txbV9.Enabled = pum.Enabled;
            }
            else if (condicion == "A10")
            {
                tig.Text = "P";
                txbL1.Text = mon.Text; txbV1.Text = gua.Text; /**/ txbL1.Enabled = mon.Enabled; txbV1.Enabled = gua.Enabled;
                txbL2.Text = atl.Text; txbV2.Text = tol.Text; /**/ txbL2.Enabled = atl.Enabled; txbV2.Enabled = tol.Enabled;
                txbL3.Text = sal.Text; txbV3.Text = san.Text; /**/ txbL3.Enabled = sal.Enabled; txbV3.Enabled = san.Enabled;
                txbL4.Text = nec.Text; txbV4.Text = leo.Text; /**/ txbL4.Enabled = nec.Enabled; txbV4.Enabled = leo.Enabled;
                txbL5.Text = mty.Text; txbV5.Text = pue.Text; /**/ txbL5.Enabled = mty.Enabled; txbV5.Enabled = pue.Enabled;
                txbL6.Text = pac.Text; txbV6.Text = tij.Text; /**/ txbL6.Enabled = pac.Enabled; txbV6.Enabled = tij.Enabled;
                txbL7.Text = ame.Text; txbV7.Text = qro.Text; /**/ txbL7.Enabled = ame.Enabled; txbV7.Enabled = qro.Enabled;
                txbL8.Text = pum.Text; txbV8.Text = caz.Text; /**/ txbL8.Enabled = pum.Enabled; txbV8.Enabled = caz.Enabled;
                txbL9.Text = jua.Text; txbV9.Text = vrz.Text; /**/ txbL9.Enabled = jua.Enabled; txbV9.Enabled = vrz.Enabled;
            }
            else if (condicion == "A11")
            {
                pum.Text = "P";
                txbL1.Text = qro.Text; txbV1.Text = nec.Text; /**/ txbL1.Enabled = qro.Enabled; txbV1.Enabled = nec.Enabled;
                txbL2.Text = tig.Text; txbV2.Text = pue.Text; /**/ txbL2.Enabled = tig.Enabled; txbV2.Enabled = pue.Enabled;
                txbL3.Text = gua.Text; txbV3.Text = pac.Text; /**/ txbL3.Enabled = gua.Enabled; txbV3.Enabled = pac.Enabled;
                txbL4.Text = leo.Text; txbV4.Text = atl.Text; /**/ txbL4.Enabled = leo.Enabled; txbV4.Enabled = atl.Enabled;
                txbL5.Text = jua.Text; txbV5.Text = ame.Text; /**/ txbL5.Enabled = jua.Enabled; txbV5.Enabled = ame.Enabled;
                txbL6.Text = san.Text; txbV6.Text = vrz.Text; /**/ txbL6.Enabled = san.Enabled; txbV6.Enabled = vrz.Enabled;
                txbL7.Text = tij.Text; txbV7.Text = mon.Text; /**/ txbL7.Enabled = tij.Enabled; txbV7.Enabled = mon.Enabled;
                txbL8.Text = caz.Text; txbV8.Text = mty.Text; /**/ txbL8.Enabled = caz.Enabled; txbV8.Enabled = mty.Enabled;
                txbL9.Text = tol.Text; txbV9.Text = sal.Text; /**/ txbL9.Enabled = tol.Enabled; txbV9.Enabled = sal.Enabled;
            }
            else if (condicion == "A12")
            {
                mon.Text = "P";
                txbL1.Text = pue.Text; txbV1.Text = leo.Text; /**/ txbL1.Enabled = pue.Enabled; txbV1.Enabled = leo.Enabled;
                txbL2.Text = atl.Text; txbV2.Text = qro.Text; /**/ txbL2.Enabled = atl.Enabled; txbV2.Enabled = qro.Enabled;
                txbL3.Text = pac.Text; txbV3.Text = caz.Text; /**/ txbL3.Enabled = pac.Enabled; txbV3.Enabled = caz.Enabled;
                txbL4.Text = mty.Text; txbV4.Text = tig.Text; /**/ txbL4.Enabled = mty.Enabled; txbV4.Enabled = tig.Enabled;
                txbL5.Text = nec.Text; txbV5.Text = jua.Text; /**/ txbL5.Enabled = nec.Enabled; txbV5.Enabled = jua.Enabled;
                txbL6.Text = ame.Text; txbV6.Text = gua.Text; /**/ txbL6.Enabled = ame.Enabled; txbV6.Enabled = gua.Enabled;
                txbL7.Text = pum.Text; txbV7.Text = san.Text; /**/ txbL7.Enabled = pum.Enabled; txbV7.Enabled = san.Enabled;
                txbL8.Text = sal.Text; txbV8.Text = tij.Text; /**/ txbL8.Enabled = sal.Enabled; txbV8.Enabled = tij.Enabled;
                txbL9.Text = vrz.Text; txbV9.Text = tol.Text; /**/ txbL9.Enabled = vrz.Enabled; txbV9.Enabled = tol.Enabled;
            }
            else if (condicion == "A13")
            {
                pac.Text = "P";
                txbL1.Text = mon.Text; txbV1.Text = nec.Text; /**/ txbL1.Enabled = mon.Enabled; txbV1.Enabled = nec.Enabled;
                txbL2.Text = tij.Text; txbV2.Text = atl.Text; /**/ txbL2.Enabled = tij.Enabled; txbV2.Enabled = atl.Enabled;
                txbL3.Text = leo.Text; txbV3.Text = vrz.Text; /**/ txbL3.Enabled = leo.Enabled; txbV3.Enabled = vrz.Enabled;
                txbL4.Text = caz.Text; txbV4.Text = ame.Text; /**/ txbL4.Enabled = caz.Enabled; txbV4.Enabled = ame.Enabled;
                txbL5.Text = tig.Text; txbV5.Text = san.Text; /**/ txbL5.Enabled = tig.Enabled; txbV5.Enabled = san.Enabled;
                txbL6.Text = gua.Text; txbV6.Text = pum.Text; /**/ txbL6.Enabled = gua.Enabled; txbV6.Enabled = pum.Enabled;
                txbL7.Text = tol.Text; txbV7.Text = pue.Text; /**/ txbL7.Enabled = tol.Enabled; txbV7.Enabled = pue.Enabled;
                txbL8.Text = jua.Text; txbV8.Text = sal.Text; /**/ txbL8.Enabled = jua.Enabled; txbV8.Enabled = sal.Enabled;
                txbL9.Text = qro.Text; txbV9.Text = mty.Text; /**/ txbL9.Enabled = qro.Enabled; txbV9.Enabled = mty.Enabled;
            }
            else if (condicion == "A14")
            {
                tol.Text = "P";
                txbL1.Text = pue.Text; txbV1.Text = atl.Text; /**/ txbL1.Enabled = pue.Enabled; txbV1.Enabled = atl.Enabled;
                txbL2.Text = vrz.Text; txbV2.Text = tig.Text; /**/ txbL2.Enabled = vrz.Enabled; txbV2.Enabled = tig.Enabled;
                txbL3.Text = san.Text; txbV3.Text = tij.Text; /**/ txbL3.Enabled = san.Enabled; txbV3.Enabled = tij.Enabled;
                txbL4.Text = caz.Text; txbV4.Text = mon.Text; /**/ txbL4.Enabled = caz.Enabled; txbV4.Enabled = mon.Enabled;
                txbL5.Text = pac.Text; txbV5.Text = jua.Text; /**/ txbL5.Enabled = pac.Enabled; txbV5.Enabled = jua.Enabled;
                txbL6.Text = nec.Text; txbV6.Text = ame.Text; /**/ txbL6.Enabled = nec.Enabled; txbV6.Enabled = ame.Enabled;
                txbL7.Text = pum.Text; txbV7.Text = leo.Text; /**/ txbL7.Enabled = pum.Enabled; txbV7.Enabled = leo.Enabled;
                txbL8.Text = sal.Text; txbV8.Text = qro.Text; /**/ txbL8.Enabled = sal.Enabled; txbV8.Enabled = qro.Enabled;
                txbL9.Text = mty.Text; txbV9.Text = gua.Text; /**/ txbL9.Enabled = mty.Enabled; txbV9.Enabled = gua.Enabled;
            }
            else if (condicion == "A15")
            {
                mty.Text = "P";
                txbL1.Text = mon.Text; txbV1.Text = san.Text; /**/ txbL1.Enabled = mon.Enabled; txbV1.Enabled = san.Enabled;
                txbL2.Text = atl.Text; txbV2.Text = nec.Text; /**/ txbL2.Enabled = atl.Enabled; txbV2.Enabled = nec.Enabled;
                txbL3.Text = tij.Text; txbV3.Text = vrz.Text; /**/ txbL3.Enabled = tij.Enabled; txbV3.Enabled = vrz.Enabled;
                txbL4.Text = qro.Text; txbV4.Text = pum.Text; /**/ txbL4.Enabled = qro.Enabled; txbV4.Enabled = pum.Enabled;
                txbL5.Text = ame.Text; txbV5.Text = pue.Text; /**/ txbL5.Enabled = ame.Enabled; txbV5.Enabled = pue.Enabled;
                txbL6.Text = leo.Text; txbV6.Text = sal.Text; /**/ txbL6.Enabled = leo.Enabled; txbV6.Enabled = sal.Enabled;
                txbL7.Text = tig.Text; txbV7.Text = caz.Text; /**/ txbL7.Enabled = tig.Enabled; txbV7.Enabled = caz.Enabled;
                txbL8.Text = tol.Text; txbV8.Text = pac.Text; /**/ txbL8.Enabled = tol.Enabled; txbV8.Enabled = pac.Enabled;
                txbL9.Text = jua.Text; txbV9.Text = gua.Text; /**/ txbL9.Enabled = jua.Enabled; txbV9.Enabled = gua.Enabled;
            }
            else if (condicion == "A16")
            {
                nec.Text = "P";
                txbL1.Text = san.Text; txbV1.Text = qro.Text; /**/ txbL1.Enabled = san.Enabled; txbV1.Enabled = qro.Enabled;
                txbL2.Text = vrz.Text; txbV2.Text = pue.Text; /**/ txbL2.Enabled = vrz.Enabled; txbV2.Enabled = pue.Enabled;
                txbL3.Text = sal.Text; txbV3.Text = ame.Text; /**/ txbL3.Enabled = sal.Enabled; txbV3.Enabled = ame.Enabled;
                txbL4.Text = pum.Text; txbV4.Text = atl.Text; /**/ txbL4.Enabled = pum.Enabled; txbV4.Enabled = atl.Enabled;
                txbL5.Text = pac.Text; txbV5.Text = mty.Text; /**/ txbL5.Enabled = pac.Enabled; txbV5.Enabled = mty.Enabled;
                txbL6.Text = gua.Text; txbV6.Text = tij.Text; /**/ txbL6.Enabled = gua.Enabled; txbV6.Enabled = tij.Enabled;
                txbL7.Text = tig.Text; txbV7.Text = tol.Text; /**/ txbL7.Enabled = tig.Enabled; txbV7.Enabled = tol.Enabled;
                txbL8.Text = mon.Text; txbV8.Text = jua.Text; /**/ txbL8.Enabled = mon.Enabled; txbV8.Enabled = jua.Enabled;
                txbL9.Text = caz.Text; txbV9.Text = leo.Text; /**/ txbL9.Enabled = caz.Enabled; txbV9.Enabled = leo.Enabled;
            }
            else if (condicion == "A17")
            {
                caz.Text = "P";
                txbL1.Text = pue.Text; txbV1.Text = pum.Text; /**/ txbL1.Enabled = pue.Enabled; txbV1.Enabled = pum.Enabled;
                txbL2.Text = atl.Text; txbV2.Text = sal.Text; /**/ txbL2.Enabled = atl.Enabled; txbV2.Enabled = sal.Enabled;
                txbL3.Text = qro.Text; txbV3.Text = tig.Text; /**/ txbL3.Enabled = qro.Enabled; txbV3.Enabled = tig.Enabled;
                txbL4.Text = ame.Text; txbV4.Text = san.Text; /**/ txbL4.Enabled = ame.Enabled; txbV4.Enabled = san.Enabled;
                txbL5.Text = mty.Text; txbV5.Text = vrz.Text; /**/ txbL5.Enabled = mty.Enabled; txbV5.Enabled = vrz.Enabled;
                txbL6.Text = nec.Text; txbV6.Text = pac.Text; /**/ txbL6.Enabled = nec.Enabled; txbV6.Enabled = pac.Enabled;
                txbL7.Text = tol.Text; txbV7.Text = gua.Text; /**/ txbL7.Enabled = tol.Enabled; txbV7.Enabled = gua.Enabled;
                txbL8.Text = jua.Text; txbV8.Text = tij.Text; /**/ txbL8.Enabled = jua.Enabled; txbV8.Enabled = tij.Enabled;
                txbL9.Text = leo.Text; txbV9.Text = mon.Text; /**/ txbL9.Enabled = leo.Enabled; txbV9.Enabled = mon.Enabled;
            }
            else if (condicion == "A18")
            {
                atl.Text = "P";
                txbL1.Text = mon.Text; txbV1.Text = pue.Text; /**/ txbL1.Enabled = mon.Enabled; txbV1.Enabled = pue.Enabled;
                txbL2.Text = vrz.Text; txbV2.Text = ame.Text; /**/ txbL2.Enabled = vrz.Enabled; txbV2.Enabled = ame.Enabled;
                txbL3.Text = tij.Text; txbV3.Text = mty.Text; /**/ txbL3.Enabled = tij.Enabled; txbV3.Enabled = mty.Enabled;
                txbL4.Text = sal.Text; txbV4.Text = nec.Text; /**/ txbL4.Enabled = sal.Enabled; txbV4.Enabled = nec.Enabled;
                txbL5.Text = tig.Text; txbV5.Text = pac.Text; /**/ txbL5.Enabled = tig.Enabled; txbV5.Enabled = pac.Enabled;
                txbL6.Text = gua.Text; txbV6.Text = qro.Text; /**/ txbL6.Enabled = gua.Enabled; txbV6.Enabled = qro.Enabled;
                txbL7.Text = leo.Text; txbV7.Text = tol.Text; /**/ txbL7.Enabled = leo.Enabled; txbV7.Enabled = tol.Enabled;
                txbL8.Text = pum.Text; txbV8.Text = jua.Text; /**/ txbL8.Enabled = pum.Enabled; txbV8.Enabled = jua.Enabled;
                txbL9.Text = san.Text; txbV9.Text = caz.Text; /**/ txbL9.Enabled = san.Enabled; txbV9.Enabled = caz.Enabled;
            }
            else if (condicion == "A19")
            {
                ame.Text = "P";
                txbL1.Text = pue.Text; txbV1.Text = nec.Text; /**/ txbL1.Enabled = pue.Enabled; txbV1.Enabled = nec.Enabled;
                txbL2.Text = tij.Text; txbV2.Text = leo.Text; /**/ txbL2.Enabled = tij.Enabled; txbV2.Enabled = leo.Enabled;
                txbL3.Text = qro.Text; txbV3.Text = mon.Text; /**/ txbL3.Enabled = qro.Enabled; txbV3.Enabled = mon.Enabled;
                txbL4.Text = caz.Text; txbV4.Text = sal.Text; /**/ txbL4.Enabled = caz.Enabled; txbV4.Enabled = sal.Enabled;
                txbL5.Text = mty.Text; txbV5.Text = atl.Text; /**/ txbL5.Enabled = mty.Enabled; txbV5.Enabled = atl.Enabled;
                txbL6.Text = pac.Text; txbV6.Text = pum.Text; /**/ txbL6.Enabled = pac.Enabled; txbV6.Enabled = pum.Enabled;
                txbL7.Text = gua.Text; txbV7.Text = vrz.Text; /**/ txbL7.Enabled = gua.Enabled; txbV7.Enabled = vrz.Enabled;
                txbL8.Text = tol.Text; txbV8.Text = san.Text; /**/ txbL8.Enabled = tol.Enabled; txbV8.Enabled = san.Enabled;
                txbL9.Text = jua.Text; txbV9.Text = tig.Text; /**/ txbL9.Enabled = jua.Enabled; txbV9.Enabled = tig.Enabled;
            }

            else if (condicion == "C1") { }
            else if (condicion == "C2") { }
            else if (condicion == "C3") { }
            else if (condicion == "C4") { }
            else if (condicion == "C5") { }
            else if (condicion == "C6") { }
            else if (condicion == "C7") { }
            else if (condicion == "C8") { }
            else if (condicion == "C9") { }
            else if (condicion == "C10") { }
            else if (condicion == "C11") { }
            else if (condicion == "C12") { }
            else if (condicion == "C13") { }
            else if (condicion == "C14") { }
            else if (condicion == "C15") { }
            else if (condicion == "C16") { }
            else if (condicion == "C17") { }
            else if (condicion == "C18") { }
            #endregion
        }           

    }
}
