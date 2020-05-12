using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador.Class.Mex
{
    class imgs
    {
        
        #region Variables Logos
        
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
        #endregion

        public imgs()
        {

        }

        #region Condición
        public void Condicion(Label Torneo, Label Jornada, Label Pjornada)
        {
            if (Torneo.Text == "Apertura" && Jornada.Text == "Jornada 1") { Pjornada.Text = "A1"; }
            else if (Torneo.Text == "Apertura" && Jornada.Text == "Jornada 2") { Pjornada.Text = "A2"; }
            else if (Torneo.Text == "Apertura" && Jornada.Text == "Jornada 3") { Pjornada.Text = "A3"; }
            else if (Torneo.Text == "Apertura" && Jornada.Text == "Jornada 4") { Pjornada.Text = "A4"; }
            else if (Torneo.Text == "Apertura" && Jornada.Text == "Jornada 5") { Pjornada.Text = "A5"; }
            else if (Torneo.Text == "Apertura" && Jornada.Text == "Jornada 6") { Pjornada.Text = "A6"; }
            else if (Torneo.Text == "Apertura" && Jornada.Text == "Jornada 7") { Pjornada.Text = "A7"; }
            else if (Torneo.Text == "Apertura" && Jornada.Text == "Jornada 8") { Pjornada.Text = "A8"; }
            else if (Torneo.Text == "Apertura" && Jornada.Text == "Jornada 9") { Pjornada.Text = "A9"; }
            else if (Torneo.Text == "Apertura" && Jornada.Text == "Jornada 10") { Pjornada.Text = "A10"; }
            else if (Torneo.Text == "Apertura" && Jornada.Text == "Jornada 11") { Pjornada.Text = "A11"; }
            else if (Torneo.Text == "Apertura" && Jornada.Text == "Jornada 12") { Pjornada.Text = "A12"; }
            else if (Torneo.Text == "Apertura" && Jornada.Text == "Jornada 13") { Pjornada.Text = "A13"; }
            else if (Torneo.Text == "Apertura" && Jornada.Text == "Jornada 14") { Pjornada.Text = "A14"; }
            else if (Torneo.Text == "Apertura" && Jornada.Text == "Jornada 15") { Pjornada.Text = "A15"; }
            else if (Torneo.Text == "Apertura" && Jornada.Text == "Jornada 16") { Pjornada.Text = "A16"; }
            else if (Torneo.Text == "Apertura" && Jornada.Text == "Jornada 17") { Pjornada.Text = "A17"; }
            else if (Torneo.Text == "Apertura" && Jornada.Text == "Jornada 18") { Pjornada.Text = "A18"; }
            else if (Torneo.Text == "Apertura" && Jornada.Text == "Jornada 19") { Pjornada.Text = "A19"; }
            else if (Torneo.Text == "Clausura" && Jornada.Text == "Jornada 1") { Pjornada.Text = "C1"; }
            else if (Torneo.Text == "Clausura" && Jornada.Text == "Jornada 2") { Pjornada.Text = "C2"; }
            else if (Torneo.Text == "Clausura" && Jornada.Text == "Jornada 3") { Pjornada.Text = "C3"; }
            else if (Torneo.Text == "Clausura" && Jornada.Text == "Jornada 4") { Pjornada.Text = "C4"; }
            else if (Torneo.Text == "Clausura" && Jornada.Text == "Jornada 5") { Pjornada.Text = "C5"; }
            else if (Torneo.Text == "Clausura" && Jornada.Text == "Jornada 6") { Pjornada.Text = "C6"; }
            else if (Torneo.Text == "Clausura" && Jornada.Text == "Jornada 7") { Pjornada.Text = "C7"; }
            else if (Torneo.Text == "Clausura" && Jornada.Text == "Jornada 8") { Pjornada.Text = "C8"; }
            else if (Torneo.Text == "Clausura" && Jornada.Text == "Jornada 9") { Pjornada.Text = "C9"; }
            else if (Torneo.Text == "Clausura" && Jornada.Text == "Jornada 10") { Pjornada.Text = "C10"; }
            else if (Torneo.Text == "Clausura" && Jornada.Text == "Jornada 11") { Pjornada.Text = "C11"; }
            else if (Torneo.Text == "Clausura" && Jornada.Text == "Jornada 12") { Pjornada.Text = "C12"; }
            else if (Torneo.Text == "Clausura" && Jornada.Text == "Jornada 13") { Pjornada.Text = "C13"; }
            else if (Torneo.Text == "Clausura" && Jornada.Text == "Jornada 14") { Pjornada.Text = "C14"; }
            else if (Torneo.Text == "Clausura" && Jornada.Text == "Jornada 15") { Pjornada.Text = "C15"; }
            else if (Torneo.Text == "Clausura" && Jornada.Text == "Jornada 16") { Pjornada.Text = "C16"; }
            else if (Torneo.Text == "Clausura" && Jornada.Text == "Jornada 17") { Pjornada.Text = "C17"; }
            else if (Torneo.Text == "Clausura" && Jornada.Text == "Jornada 18") { Pjornada.Text = "C18"; }
            else if (Torneo.Text == "Clausura" && Jornada.Text == "Jornada 18") { Pjornada.Text = "C19"; }
        }
        #endregion

        public void logos(string condicion,PictureBox Liga, PictureBox D, PictureBox L1, PictureBox L2, PictureBox L3, PictureBox L4, PictureBox L5, PictureBox L6, PictureBox L7, PictureBox L8, PictureBox L9, PictureBox V1, PictureBox V2, PictureBox V3, PictureBox V4, PictureBox V5, PictureBox V6, PictureBox V7, PictureBox V8, PictureBox V9, Label F1, Label F2, Label F3, Label F4, Label F5, Label F6, Label F7, Label F8, Label F9, Label H1, Label H2, Label H3, Label H4, Label H5, Label H6, Label H7, Label H8, Label H9)
        {
            #region Logos
            if (condicion == "A1")
            {
                D.Image = Image.FromFile(Lvrz);
                L1.Image = Image.FromFile(Lpue); V1.Image = Image.FromFile(Ltij); F1.Text = "Vie. 19/Jul"; H1.Text = "19:00 hrs";
                L2.Image = Image.FromFile(Latl); V2.Image = Image.FromFile(Ljua); F2.Text = "Vie. 19/Jul"; H2.Text = "21:00 hrs";
                L3.Image = Image.FromFile(Lsal); V3.Image = Image.FromFile(Lpum); F3.Text = "Sáb. 20/Jul"; H3.Text = "17:00 hrs";
                L4.Image = Image.FromFile(Lpac); V4.Image = Image.FromFile(Lleo); F4.Text = "Sáb. 20/Jul"; H4.Text = "17:00 hrs";
                L5.Image = Image.FromFile(Ltig); V5.Image = Image.FromFile(Lmon); F5.Text = "Sáb. 20/Jul"; H5.Text = "19:00 hrs";
                L6.Image = Image.FromFile(Lame); V6.Image = Image.FromFile(Lmty); F6.Text = "Sáb. 20/Jul"; H6.Text = "19:00 hrs";
                L7.Image = Image.FromFile(Lnec); V7.Image = Image.FromFile(Lcaz); F7.Text = "Sáb. 20/Jul"; H7.Text = "21:00 hrs";
                L8.Image = Image.FromFile(Ltol); V8.Image = Image.FromFile(Lqro); F8.Text = "Dom. 21/Jul"; H8.Text = "12:00 hrs";
                L9.Image = Image.FromFile(Lsan); V9.Image = Image.FromFile(Lgua); F9.Text = "Dom. 21/Jul"; H9.Text = "18:50 hrs";
            }
            else if (condicion == "A2")
            {
                D.Image = Image.FromFile(Lpue);
                L1.Image = Image.FromFile(Lmon); V1.Image = Image.FromFile(Latl); F1.Text = "Vie. 26/Jul"; H1.Text = "19:00 hrs";
                L2.Image = Image.FromFile(Lvrz); V2.Image = Image.FromFile(Lpac); F2.Text = "Vie. 26/Jul"; H2.Text = "21:00 hrs";
                L3.Image = Image.FromFile(Lleo); V3.Image = Image.FromFile(Lame); F3.Text = "Sáb. 27/Jul"; H3.Text = "19:00 hrs";
                L4.Image = Image.FromFile(Ltij); V4.Image = Image.FromFile(Lqro); F4.Text = "Sáb. 27/Jul"; H4.Text = "21:00 hrs";
                L5.Image = Image.FromFile(Lcaz); V5.Image = Image.FromFile(Ltol); F5.Text = "Sáb. 27/Jul"; H5.Text = "21:00 hrs";
                L6.Image = Image.FromFile(Lpum); V6.Image = Image.FromFile(Lnec); F6.Text = "Dom. 28/Jul"; H6.Text = "12:00 hrs";
                L7.Image = Image.FromFile(Lsal); V7.Image = Image.FromFile(Lmty); F7.Text = "Dom. 28/Jul"; H7.Text = "17:00 hrs";
                L8.Image = Image.FromFile(Lgua); V8.Image = Image.FromFile(Ltig); F8.Text = "Dom. 28/Jul"; H8.Text = "19:00 hrs";
                L9.Image = Image.FromFile(Lsan); V9.Image = Image.FromFile(Ljua); F9.Text = "Dom. 28/Jul"; H9.Text = "18:50 hrs";
            }
            else if (condicion == "A3")
            {
                D.Image = Image.FromFile(Lsal);
                L1.Image = Image.FromFile(Lpue); V1.Image = Image.FromFile(Lgua); F1.Text = "Vie. 02/Ago"; H1.Text = "19:00 hrs";
                L2.Image = Image.FromFile(Latl); V2.Image = Image.FromFile(Lsan); F2.Text = "Vie. 02/Ago"; H2.Text = "21:00 hrs";
                L3.Image = Image.FromFile(Lqro); V3.Image = Image.FromFile(Lcaz); F3.Text = "Sáb. 03/Ago"; H3.Text = "17:00 hrs";
                L4.Image = Image.FromFile(Lame); V4.Image = Image.FromFile(Ltij); F4.Text = "Sáb. 03/Ago"; H4.Text = "19:00 hrs";
                L5.Image = Image.FromFile(Lpac); V5.Image = Image.FromFile(Lmon); F5.Text = "Sáb. 03/Ago"; H5.Text = "19:00 hrs";
                L6.Image = Image.FromFile(Lmty); V6.Image = Image.FromFile(Lleo); F6.Text = "Sáb. 03/Ago"; H6.Text = "21:00 hrs";
                L7.Image = Image.FromFile(Lnec); V7.Image = Image.FromFile(Lvrz); F7.Text = "Sáb. 03/Ago"; H7.Text = "21:00 hrs";
                L8.Image = Image.FromFile(Lpum); V8.Image = Image.FromFile(Ltig); F8.Text = "Dom. 04/Ago"; H8.Text = "12:00 hrs";
                L9.Image = Image.FromFile(Ljua); V9.Image = Image.FromFile(Ltol); F9.Text = "Dom. 04/Ago"; H9.Text = "19:00 hrs";
            }
            else if (condicion == "A4")
            {
                D.Image = Image.FromFile(Lleo);
                L1.Image = Image.FromFile(Lmon); V1.Image = Image.FromFile(Lmty); F1.Text = "Vie. 09/Ago"; H1.Text = "19:00 hrs";
                L2.Image = Image.FromFile(Lvrz); V2.Image = Image.FromFile(Latl); F2.Text = "Vie. 09/Ago"; H2.Text = "21:00 hrs";
                L3.Image = Image.FromFile(Ltij); V3.Image = Image.FromFile(Lpum); F3.Text = "Vie. 09/Ago"; H3.Text = "21:00 hrs";
                L4.Image = Image.FromFile(Lqro); V4.Image = Image.FromFile(Lpac); F4.Text = "Sáb. 10/Ago"; H4.Text = "17:00 hrs";
                L5.Image = Image.FromFile(Lcaz); V5.Image = Image.FromFile(Ljua); F5.Text = "Sáb. 10/Ago"; H5.Text = "17:00 hrs";
                L6.Image = Image.FromFile(Ltig); V6.Image = Image.FromFile(Lnec); F6.Text = "Sáb. 10/Ago"; H6.Text = "19:00 hrs";
                L7.Image = Image.FromFile(Lgua); V7.Image = Image.FromFile(Lsal); F7.Text = "Sáb. 10/Ago"; H7.Text = "21:00 hrs";
                L8.Image = Image.FromFile(Ltol); V8.Image = Image.FromFile(Lame); F8.Text = "Dom. 11/Ago"; H8.Text = "12:00 hrs";
                L9.Image = Image.FromFile(Lsan); V9.Image = Image.FromFile(Lpue); F9.Text = "Dom. 11/Ago"; H9.Text = "18:50 hrs";
            }
            else if (condicion == "A5")
            {
                D.Image = Image.FromFile(Ltij);
                L1.Image = Image.FromFile(Lpue); V1.Image = Image.FromFile(Lpac); F1.Text = "Vie. 16/Ago"; H1.Text = "19:00 hrs";
                L2.Image = Image.FromFile(Latl); V2.Image = Image.FromFile(Lcaz); F2.Text = "Vie. 16/Ago"; H2.Text = "21:00 hrs";
                L3.Image = Image.FromFile(Lsal); V3.Image = Image.FromFile(Ltig); F3.Text = "Sáb. 17/Ago"; H3.Text = "17:00 hrs";
                L4.Image = Image.FromFile(Lleo); V4.Image = Image.FromFile(Lgua); F4.Text = "Sáb. 17/Ago"; H4.Text = "19:00 hrs";
                L5.Image = Image.FromFile(Lame); V5.Image = Image.FromFile(Lmon); F5.Text = "Sáb. 17/Ago"; H5.Text = "21:00 hrs";
                L6.Image = Image.FromFile(Lmty); V6.Image = Image.FromFile(Ltol); F6.Text = "Sáb. 17/Ago"; H6.Text = "21:00 hrs";
                L7.Image = Image.FromFile(Lpum); V7.Image = Image.FromFile(Lvrz); F7.Text = "Dom. 18/Ago"; H7.Text = "12:00 hrs";
                L8.Image = Image.FromFile(Lnec); V8.Image = Image.FromFile(Lsan); F8.Text = "Dom. 18/Ago"; H8.Text = "17:00 hrs";
                L9.Image = Image.FromFile(Ljua); V9.Image = Image.FromFile(Lqro); F9.Text = "Dom. 18/Ago"; H9.Text = "19:00 hrs";
            }
            else if (condicion == "A6")
            {
                D.Image = Image.FromFile(Ljua);
                L1.Image = Image.FromFile(Lvrz); V1.Image = Image.FromFile(Lsal); F1.Text = "Vie. 23/Ago"; H1.Text = "19:00 hrs";
                L2.Image = Image.FromFile(Lmon); V2.Image = Image.FromFile(Lpum); F2.Text = "Vie. 23/Ago"; H2.Text = "21:00 hrs";
                L3.Image = Image.FromFile(Lsan); V3.Image = Image.FromFile(Lmty); F3.Text = "Vie. 23/Ago"; H3.Text = "21:00 hrs";
                L4.Image = Image.FromFile(Lqro); V4.Image = Image.FromFile(Lleo); F4.Text = "Sáb. 24/Ago"; H4.Text = "17:00 hrs";
                L5.Image = Image.FromFile(Lpac); V5.Image = Image.FromFile(Latl); F5.Text = "Sáb. 24/Ago"; H5.Text = "19:00 hrs";
                L6.Image = Image.FromFile(Lcaz); V6.Image = Image.FromFile(Lpue); F6.Text = "Sáb. 24/Ago"; H6.Text = "19:00 hrs";
                L7.Image = Image.FromFile(Ltig); V7.Image = Image.FromFile(Lame); F7.Text = "Sáb. 24/Ago"; H7.Text = "21:00 hrs";
                L8.Image = Image.FromFile(Ltol); V8.Image = Image.FromFile(Ltij); F8.Text = "Dom. 25/Ago"; H8.Text = "12:00 hrs";
                L9.Image = Image.FromFile(Lgua); V9.Image = Image.FromFile(Lnec); F9.Text = "Dom. 25/Ago"; H9.Text = "17:00 hrs";
            }
            else if (condicion == "A7")
            {
                //Doble
                D.Image = Image.FromFile(Lgua);
                L1.Image = Image.FromFile(Lvrz); V1.Image = Image.FromFile(Lqro); F1.Text = "Mar. 27/Ago"; H1.Text = "19:00 hrs";
                L2.Image = Image.FromFile(Lsal); V2.Image = Image.FromFile(Lmon); F2.Text = "Mar. 27/Ago"; H2.Text = "19:00 hrs";
                L3.Image = Image.FromFile(Latl); V3.Image = Image.FromFile(Ltig); F3.Text = "Mar. 27/Ago"; H3.Text = "19:00 hrs";
                L4.Image = Image.FromFile(Lame); V4.Image = Image.FromFile(Lpac); F4.Text = "Mar. 27/Ago"; H4.Text = "21:00 hrs";
                L5.Image = Image.FromFile(Lleo); V5.Image = Image.FromFile(Lsan); F5.Text = "Mié. 28/Ago"; H5.Text = "19:00 hrs";
                L6.Image = Image.FromFile(Ltij); V6.Image = Image.FromFile(Lcaz); F6.Text = "Mié. 28/Ago"; H6.Text = "21:00 hrs";
                L7.Image = Image.FromFile(Lnec); V7.Image = Image.FromFile(Ltol); F7.Text = "Mié. 28/Ago"; H7.Text = "21:00 hrs";
                L8.Image = Image.FromFile(Lpue); V8.Image = Image.FromFile(Ljua); F8.Text = "Jue. 29/Ago"; H8.Text = "19:00 hrs";
                L9.Image = Image.FromFile(Lmty); V9.Image = Image.FromFile(Lpum); F9.Text = "Jue. 29/Ago"; H9.Text = "21:00 hrs";
            }
            else if (condicion == "A8")
            {
                D.Image = Image.FromFile(Lsan);
                L1.Image = Image.FromFile(Lmon); V1.Image = Image.FromFile(Lvrz); F1.Text = "Vie. 30/Ago"; H1.Text = "19:00 hrs";
                L2.Image = Image.FromFile(Latl); V2.Image = Image.FromFile(Lame); F2.Text = "Vie. 30/Ago"; H2.Text = "21:00 hrs";
                L3.Image = Image.FromFile(Lnec); V3.Image = Image.FromFile(Ltij); F3.Text = "Sáb. 31/Ago"; H3.Text = "17:00 hrs";
                L4.Image = Image.FromFile(Ltig); V4.Image = Image.FromFile(Lleo); F4.Text = "Sáb. 31/Ago"; H4.Text = "19:00 hrs";
                L5.Image = Image.FromFile(Lpac); V5.Image = Image.FromFile(Lsal); F5.Text = "Sáb. 31/Ago"; H5.Text = "19:00 hrs";
                L6.Image = Image.FromFile(Lcaz); V6.Image = Image.FromFile(Lgua); F6.Text = "Sáb. 31/Ago"; H6.Text = "21:00 hrs";
                L7.Image = Image.FromFile(Lpum); V7.Image = Image.FromFile(Ltol); F7.Text = "Dom. 01/Sep"; H7.Text = "12:00 hrs";
                L8.Image = Image.FromFile(Lqro); V8.Image = Image.FromFile(Lpue); F8.Text = "Dom. 01/Sep"; H8.Text = "17:00 hrs";
                L9.Image = Image.FromFile(Ljua); V9.Image = Image.FromFile(Lmty); F9.Text = "Dom. 01/Sep"; H9.Text = "19:00 hrs";
            }
            else if (condicion == "A9")
            {
                D.Image = Image.FromFile(Lqro);
                L1.Image = Image.FromFile(Lpue); V1.Image = Image.FromFile(Lsal); F1.Text = "Vie. 13/Sep"; H1.Text = "19:00 hrs";
                L2.Image = Image.FromFile(Lvrz); V2.Image = Image.FromFile(Lcaz); F2.Text = "Vie. 13/Sep"; H2.Text = "21:00 hrs";
                L3.Image = Image.FromFile(Ltij); V3.Image = Image.FromFile(Ltig); F3.Text = "Vie. 13/Sep"; H3.Text = "21:00 hrs";
                L4.Image = Image.FromFile(Lmty); V4.Image = Image.FromFile(Lnec); F4.Text = "Sáb. 14/Sep"; H4.Text = "17:00 hrs";
                L5.Image = Image.FromFile(Lleo); V5.Image = Image.FromFile(Ljua); F5.Text = "Sáb. 14/Sep"; H5.Text = "19:00 hrs";
                L6.Image = Image.FromFile(Lgua); V6.Image = Image.FromFile(Latl); F6.Text = "Sáb. 14/Sep"; H6.Text = "19:00 hrs";
                L7.Image = Image.FromFile(Ltol); V7.Image = Image.FromFile(Lmon); F7.Text = "Dom. 15/Sep"; H7.Text = "12:00 hrs";
                L8.Image = Image.FromFile(Lsan); V8.Image = Image.FromFile(Lpac); F8.Text = "Dom. 15/Sep"; H8.Text = "18:50 hrs";
                L9.Image = Image.FromFile(Lame); V9.Image = Image.FromFile(Lpum); F9.Text = "Dom. 15/Sep"; H9.Text = "20:00 hrs";
            }
            else if (condicion == "A10")
            {
                D.Image = Image.FromFile(Ltig);
                L1.Image = Image.FromFile(Lmon); V1.Image = Image.FromFile(Lgua); F1.Text = "Vie. 20/Sep"; H1.Text = "19:00 hrs";
                L2.Image = Image.FromFile(Latl); V2.Image = Image.FromFile(Ltol); F2.Text = "Vie. 20/Sep"; H2.Text = "21:00 hrs";
                L3.Image = Image.FromFile(Lsal); V3.Image = Image.FromFile(Lsan); F3.Text = "Sáb. 21/Sep"; H3.Text = "17:00 hrs";
                L4.Image = Image.FromFile(Lnec); V4.Image = Image.FromFile(Lleo); F4.Text = "Sáb. 21/Sep"; H4.Text = "17:00 hrs";
                L5.Image = Image.FromFile(Lmty); V5.Image = Image.FromFile(Lpue); F5.Text = "Sáb. 21/Sep"; H5.Text = "17:00 hrs";
                L6.Image = Image.FromFile(Lpac); V6.Image = Image.FromFile(Ltij); F6.Text = "Sáb. 21/Sep"; H6.Text = "19:00 hrs";
                L7.Image = Image.FromFile(Lame); V7.Image = Image.FromFile(Lqro); F7.Text = "Sáb. 21/Sep"; H7.Text = "21:00 hrs";
                L8.Image = Image.FromFile(Lpum); V8.Image = Image.FromFile(Lcaz); F8.Text = "Dom. 22/Sep"; H8.Text = "12:00 hrs";
                L9.Image = Image.FromFile(Ljua); V9.Image = Image.FromFile(Lvrz); F9.Text = "Dom. 22/Sep"; H9.Text = "19:00 hrs";
            }
            else if (condicion == "A11")
            {
                //Doble
                D.Image = Image.FromFile(Lpum);
                L1.Image = Image.FromFile(Lqro); V1.Image = Image.FromFile(Lnec); F1.Text = "Mar. 24/Sep"; H1.Text = "19:00 hrs";
                L2.Image = Image.FromFile(Ltig); V2.Image = Image.FromFile(Lpue); F2.Text = "Mar. 24/Sep"; H2.Text = "19:00 hrs";
                L3.Image = Image.FromFile(Lgua); V3.Image = Image.FromFile(Lpac); F3.Text = "Mar. 24/Sep"; H3.Text = "21:00 hrs";
                L4.Image = Image.FromFile(Lleo); V4.Image = Image.FromFile(Latl); F4.Text = "Mar. 24/Sep"; H4.Text = "21:00 hrs";
                L5.Image = Image.FromFile(Ljua); V5.Image = Image.FromFile(Lame); F5.Text = "Mié. 25/Sep"; H5.Text = "19:00 hrs";
                L6.Image = Image.FromFile(Lsan); V6.Image = Image.FromFile(Lvrz); F6.Text = "Mié. 25/Sep"; H6.Text = "19:00 hrs";
                L7.Image = Image.FromFile(Ltij); V7.Image = Image.FromFile(Lmon); F7.Text = "Mié. 25/Sep"; H7.Text = "21:00 hrs";
                L8.Image = Image.FromFile(Lcaz); V8.Image = Image.FromFile(Lmty); F8.Text = "Mié. 25/Sep"; H8.Text = "21:00 hrs";
                L9.Image = Image.FromFile(Ltol); V9.Image = Image.FromFile(Lsal); F9.Text = "Jue. 26/Sep"; H9.Text = "20:00 hrs";
            }
            else if (condicion == "A12")
            {
                D.Image = Image.FromFile(Lmon);
                L1.Image = Image.FromFile(Lpue); V1.Image = Image.FromFile(Lleo); F1.Text = "Vie. 27/Sep"; H1.Text = "19:00 hrs";
                L2.Image = Image.FromFile(Latl); V2.Image = Image.FromFile(Lqro); F2.Text = "Vie. 27/Sep"; H2.Text = "21:00 hrs";
                L3.Image = Image.FromFile(Lpac); V3.Image = Image.FromFile(Lcaz); F3.Text = "Sáb. 28/Sep"; H3.Text = "17:00 hrs";
                L4.Image = Image.FromFile(Lmty); V4.Image = Image.FromFile(Ltig); F4.Text = "Sáb. 28/Sep"; H4.Text = "19:00 hrs";
                L5.Image = Image.FromFile(Lnec); V5.Image = Image.FromFile(Ljua); F5.Text = "Sáb. 28/Sep"; H5.Text = "19:00 hrs";
                L6.Image = Image.FromFile(Lame); V6.Image = Image.FromFile(Lgua); F6.Text = "Sáb. 28/Sep"; H6.Text = "21:00 hrs";
                L7.Image = Image.FromFile(Lpum); V7.Image = Image.FromFile(Lsan); F7.Text = "Dom. 29/Sep"; H7.Text = "12:00 hrs";
                L8.Image = Image.FromFile(Lsal); V8.Image = Image.FromFile(Ltij); F8.Text = "Dom. 29/Sep"; H8.Text = "17:00 hrs";
                L9.Image = Image.FromFile(Lvrz); V9.Image = Image.FromFile(Ltol); F9.Text = "Dom. 29/Sep"; H9.Text = "19:00 hrs";
            }
            else if (condicion == "A13")
            {
                D.Image = Image.FromFile(Lpac);
                L1.Image = Image.FromFile(Lmon); V1.Image = Image.FromFile(Lnec); F1.Text = "Vie. 04/Oct"; H1.Text = "21:00 hrs";
                L2.Image = Image.FromFile(Ltij); V2.Image = Image.FromFile(Latl); F2.Text = "Vie. 04/Oct"; H2.Text = "21:00 hrs";
                L3.Image = Image.FromFile(Lleo); V3.Image = Image.FromFile(Lvrz); F3.Text = "Sáb. 05/Oct"; H3.Text = "17:00 hrs";
                L4.Image = Image.FromFile(Lcaz); V4.Image = Image.FromFile(Lame); F4.Text = "Sáb. 05/Oct"; H4.Text = "19:00 hrs";
                L5.Image = Image.FromFile(Ltig); V5.Image = Image.FromFile(Lsan); F5.Text = "Sáb. 05/Oct"; H5.Text = "21:00 hrs";
                L6.Image = Image.FromFile(Lgua); V6.Image = Image.FromFile(Lpum); F6.Text = "Sáb. 05/Oct"; H6.Text = "21:00 hrs";
                L7.Image = Image.FromFile(Ltol); V7.Image = Image.FromFile(Lpue); F7.Text = "Dom. 06/Oct"; H7.Text = "12:00 hrs";
                L8.Image = Image.FromFile(Ljua); V8.Image = Image.FromFile(Lsal); F8.Text = "Dom. 06/Oct"; H8.Text = "19:00 hrs";
                L9.Image = Image.FromFile(Lqro); V9.Image = Image.FromFile(Lmty); F9.Text = "Dom. 06/Oct"; H9.Text = "20:00 hrs";
            }
            else if (condicion == "A14")
            {
                D.Image = Image.FromFile(Ltol);
                L1.Image = Image.FromFile(Lpue); V1.Image = Image.FromFile(Latl); F1.Text = "Vie. 18/Oct"; H1.Text = "19:00 hrs";
                L2.Image = Image.FromFile(Lvrz); V2.Image = Image.FromFile(Ltig); F2.Text = "Vie. 18/Oct"; H2.Text = "21:00 hrs";
                L3.Image = Image.FromFile(Lsan); V3.Image = Image.FromFile(Ltij); F3.Text = "Vie. 18/Oct"; H3.Text = "21:00 hrs";
                L4.Image = Image.FromFile(Lcaz); V4.Image = Image.FromFile(Lmon); F4.Text = "Sáb. 19/Oct"; H4.Text = "17:00 hrs";
                L5.Image = Image.FromFile(Lpac); V5.Image = Image.FromFile(Ljua); F5.Text = "Sáb. 19/Oct"; H5.Text = "19:00 hrs";
                L6.Image = Image.FromFile(Lnec); V6.Image = Image.FromFile(Lame); F6.Text = "Sáb. 19/Oct"; H6.Text = "21:00 hrs";
                L7.Image = Image.FromFile(Lpum); V7.Image = Image.FromFile(Lleo); F7.Text = "Dom. 20/Oct"; H7.Text = "12:00 hrs";
                L8.Image = Image.FromFile(Lsal); V8.Image = Image.FromFile(Lqro); F8.Text = "Dom. 20/Oct"; H8.Text = "17:00 hrs";
                L9.Image = Image.FromFile(Lmty); V9.Image = Image.FromFile(Lgua); F9.Text = "Dom. 20/Oct"; H9.Text = "18:50 hrs";
            }
            else if (condicion == "A15")
            {
                D.Image = Image.FromFile(Lmty);
                L1.Image = Image.FromFile(Lmon); V1.Image = Image.FromFile(Lsan); F1.Text = "Vie. 25/Ago"; H1.Text = "19:00 hrs";
                L2.Image = Image.FromFile(Latl); V2.Image = Image.FromFile(Lnec); F2.Text = "Vie. 25/Ago"; H2.Text = "21:00 hrs";
                L3.Image = Image.FromFile(Ltij); V3.Image = Image.FromFile(Lvrz); F3.Text = "Vie. 25/Ago"; H3.Text = "21:00 hrs";
                L4.Image = Image.FromFile(Lqro); V4.Image = Image.FromFile(Lpum); F4.Text = "Sáb. 26/Ago"; H4.Text = "17:00 hrs";
                L5.Image = Image.FromFile(Lame); V5.Image = Image.FromFile(Lpue); F5.Text = "Sáb. 26/Ago"; H5.Text = "19:00 hrs";
                L6.Image = Image.FromFile(Lleo); V6.Image = Image.FromFile(Lsal); F6.Text = "Sáb. 26/Ago"; H6.Text = "19:00 hrs";
                L7.Image = Image.FromFile(Ltig); V7.Image = Image.FromFile(Lcaz); F7.Text = "Sáb. 26/Ago"; H7.Text = "21:00 hrs";
                L8.Image = Image.FromFile(Ltol); V8.Image = Image.FromFile(Lpac); F8.Text = "Dom. 27/Ago"; H8.Text = "12:00 hrs";
                L9.Image = Image.FromFile(Ljua); V9.Image = Image.FromFile(Lgua); F9.Text = "Dom. 27/Ago"; H9.Text = "19:00 hrs";
            }
            else if (condicion == "A16")
            {
                //Doble
                D.Image = Image.FromFile(Lnec);
                L1.Image = Image.FromFile(Lsan); V1.Image = Image.FromFile(Lqro); F1.Text = "Mar. 29/Oct"; H1.Text = "19:00 hrs";
                L2.Image = Image.FromFile(Lvrz); V2.Image = Image.FromFile(Lpue); F2.Text = "Mar. 29/Oct"; H2.Text = "19:00 hrs";
                L3.Image = Image.FromFile(Lsal); V3.Image = Image.FromFile(Lame); F3.Text = "Mar. 29/Oct"; H3.Text = "19:00 hrs";
                L4.Image = Image.FromFile(Lpum); V4.Image = Image.FromFile(Latl); F4.Text = "Mar. 29/Oct"; H4.Text = "21:00 hrs";
                L5.Image = Image.FromFile(Lpac); V5.Image = Image.FromFile(Lmty); F5.Text = "Mié. 30/Oct"; H5.Text = "19:00 hrs";
                L6.Image = Image.FromFile(Lgua); V6.Image = Image.FromFile(Ltij); F6.Text = "Mié. 30/Oct"; H6.Text = "21:00 hrs";
                L7.Image = Image.FromFile(Ltig); V7.Image = Image.FromFile(Ltol); F7.Text = "Mié. 30/Oct"; H7.Text = "21:00 hrs";
                L8.Image = Image.FromFile(Lmon); V8.Image = Image.FromFile(Ljua); F8.Text = "Jue. 31/Oct"; H8.Text = "19:00 hrs";
                L9.Image = Image.FromFile(Lcaz); V9.Image = Image.FromFile(Lleo); F9.Text = "Jue. 31/Oct"; H9.Text = "21:00 hrs";
            }
            else if (condicion == "A17")
            {
                D.Image = Image.FromFile(Lcaz);
                L1.Image = Image.FromFile(Lpue); V1.Image = Image.FromFile(Lpum); F1.Text = "Vie. 01/Nov"; H1.Text = "19:00 hrs";
                L2.Image = Image.FromFile(Latl); V2.Image = Image.FromFile(Lsal); F2.Text = "Vie. 01/Nov"; H2.Text = "21:00 hrs";
                L3.Image = Image.FromFile(Lqro); V3.Image = Image.FromFile(Ltig); F3.Text = "Sáb. 04/Nov"; H3.Text = "17:00 hrs";
                L4.Image = Image.FromFile(Lame); V4.Image = Image.FromFile(Lsan); F4.Text = "Sáb. 04/Nov"; H4.Text = "19:00 hrs";
                L5.Image = Image.FromFile(Lmty); V5.Image = Image.FromFile(Lvrz); F5.Text = "Sáb. 04/Nov"; H5.Text = "19:00 hrs";
                L6.Image = Image.FromFile(Lnec); V6.Image = Image.FromFile(Lpac); F6.Text = "Sáb. 04/Nov"; H6.Text = "21:00 hrs";
                L7.Image = Image.FromFile(Ltol); V7.Image = Image.FromFile(Lgua); F7.Text = "Dom. 03/Nov"; H7.Text = "12:00 hrs";
                L8.Image = Image.FromFile(Ljua); V8.Image = Image.FromFile(Ltij); F8.Text = "Dom. 03/Nov"; H8.Text = "19:00 hrs";
                L9.Image = Image.FromFile(Lleo); V9.Image = Image.FromFile(Lmon); F9.Text = "Dom. 03/Nov"; H9.Text = "20:00 hrs";
            }
            else if (condicion == "A18")
            {
                D.Image = Image.FromFile(Latl);
                L1.Image = Image.FromFile(Lmon); V1.Image = Image.FromFile(Lpue); F1.Text = "Vie. 08/Nov"; H1.Text = "19:00 hrs";
                L2.Image = Image.FromFile(Lvrz); V2.Image = Image.FromFile(Lame); F2.Text = "Vie. 08/Nov"; H2.Text = "21:00 hrs";
                L3.Image = Image.FromFile(Ltij); V3.Image = Image.FromFile(Lmty); F3.Text = "Vie. 08/Nov"; H3.Text = "21:00 hrs";
                L4.Image = Image.FromFile(Lsal); V4.Image = Image.FromFile(Lnec); F4.Text = "Sáb. 09/Nov"; H4.Text = "17:00 hrs";
                L5.Image = Image.FromFile(Ltig); V5.Image = Image.FromFile(Lpac); F5.Text = "Sáb. 09/Nov"; H5.Text = "19:00 hrs";
                L6.Image = Image.FromFile(Lgua); V6.Image = Image.FromFile(Lqro); F6.Text = "Sáb. 09/Nov"; H6.Text = "21:00 hrs";
                L7.Image = Image.FromFile(Lleo); V7.Image = Image.FromFile(Ltol); F7.Text = "Sáb. 09/Nov"; H7.Text = "21:00 hrs";
                L8.Image = Image.FromFile(Lpum); V8.Image = Image.FromFile(Ljua); F8.Text = "Dom. 10/Nov"; H8.Text = "12:00 hrs";
                L9.Image = Image.FromFile(Lsan); V9.Image = Image.FromFile(Lcaz); F9.Text = "Dom. 10/Nov"; H9.Text = "18:50 hrs";
            }
            else if (condicion == "A19")
            {
                D.Image = Image.FromFile(Lame);
                L1.Image = Image.FromFile(Lpue); V1.Image = Image.FromFile(Lnec); F1.Text = "Vie. 22/Nov"; H1.Text = "19:00 hrs";
                L2.Image = Image.FromFile(Ltij); V2.Image = Image.FromFile(Lleo); F2.Text = "Vie. 22/Nov"; H2.Text = "21:00 hrs";
                L3.Image = Image.FromFile(Lqro); V3.Image = Image.FromFile(Lmon); F3.Text = "Sáb. 23/Nov"; H3.Text = "17:00 hrs";
                L4.Image = Image.FromFile(Lcaz); V4.Image = Image.FromFile(Lsal); F4.Text = "Sáb. 23/Nov"; H4.Text = "19:00 hrs";
                L5.Image = Image.FromFile(Lmty); V5.Image = Image.FromFile(Latl); F5.Text = "Sáb. 23/Nov"; H5.Text = "19:00 hrs";
                L6.Image = Image.FromFile(Lpac); V6.Image = Image.FromFile(Lpum); F6.Text = "Sáb. 23/Nov"; H6.Text = "21:00 hrs";
                L7.Image = Image.FromFile(Lgua); V7.Image = Image.FromFile(Lvrz); F7.Text = "Sáb. 23/Nov"; H7.Text = "21:00 hrs";
                L8.Image = Image.FromFile(Ltol); V8.Image = Image.FromFile(Lsan); F8.Text = "Dom. 24/Nov"; H8.Text = "12:00 hrs";
                L9.Image = Image.FromFile(Ljua); V9.Image = Image.FromFile(Ltig); F9.Text = "Dom. 24/Nov"; H9.Text = "19:00 hrs";
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
    }
}
