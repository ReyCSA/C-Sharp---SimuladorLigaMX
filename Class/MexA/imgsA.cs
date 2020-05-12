using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador.Class.MexA
{
    class imgsA
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

        public imgsA()
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
        }
        #endregion

        public void logos(string condicion, PictureBox L1, PictureBox L2, PictureBox L3, PictureBox L4, PictureBox L5, PictureBox L6, PictureBox L7, PictureBox V1, PictureBox V2, PictureBox V3, PictureBox V4, PictureBox V5, PictureBox V6, PictureBox V7, Label F1, Label F2, Label F3, Label F4, Label F5, Label F6, Label F7, Label H1, Label H2, Label H3, Label H4, Label H5, Label H6, Label H7)
        {
            #region Logos
            if (condicion == "A1")
            {
                L1.Image = Image.FromFile(Lcel); V1.Image = Image.FromFile(Lzac); F1.Text = "Jue. 01/Ago"; H1.Text = "20:30 hrs";
                L2.Image = Image.FromFile(Luae); V2.Image = Image.FromFile(Lcor); F2.Text = "Vie. 02/Ago"; H2.Text = "17:00 hrs";
                L3.Image = Image.FromFile(Ltam); V3.Image = Image.FromFile(Ldor); F3.Text = "Vie. 02/Ago"; H3.Text = "19:00 hrs";
                L4.Image = Image.FromFile(Latl); V4.Image = Image.FromFile(Lmin); F4.Text = "Vie. 02/Ago"; H4.Text = "20:00 hrs";
                L5.Image = Image.FromFile(Llor); V5.Image = Image.FromFile(Lven); F5.Text = "Sáb. 03/Ago"; H5.Text = "17:00 hrs";
                L6.Image = Image.FromFile(Lcaf); V6.Image = Image.FromFile(Lcim); F6.Text = "Sáb. 03/Ago"; H6.Text = "19:00 hrs";
                L7.Image = Image.FromFile(Lale); V7.Image = Image.FromFile(Ludg); F7.Text = "Dom. 04/Ago"; H7.Text = "12:00 hrs";
            }
            else if (condicion == "A2")
            {
                L1.Image = Image.FromFile(Lcim); V1.Image = Image.FromFile(Lale); F1.Text = "Jue. 08/Ago"; H1.Text = "21:00 hrs";
                L2.Image = Image.FromFile(Lmin); V2.Image = Image.FromFile(Ltam); F2.Text = "Vie. 09/Ago"; H2.Text = "19:00 hrs";
                L3.Image = Image.FromFile(Lcor); V3.Image = Image.FromFile(Latl); F3.Text = "Vie. 09/Ago"; H3.Text = "20:08 hrs";
                L4.Image = Image.FromFile(Lzac); V4.Image = Image.FromFile(Llor); F4.Text = "Sáb. 10/Ago"; H4.Text = "17:00 hrs";
                L5.Image = Image.FromFile(Lven); V5.Image = Image.FromFile(Luae); F5.Text = "Sáb. 10/Ago"; H5.Text = "19:00 hrs";
                L6.Image = Image.FromFile(Ldor); V6.Image = Image.FromFile(Lcel); F6.Text = "Sáb. 10/Ago"; H6.Text = "21:00 hrs";
                L7.Image = Image.FromFile(Ludg); V7.Image = Image.FromFile(Lcaf); F7.Text = "Dom. 11/Ago"; H7.Text = "12:00 hrs";
            }
            else if (condicion == "A3")
            {
                L1.Image = Image.FromFile(Ltam); V1.Image = Image.FromFile(Lcor); F1.Text = "Jue. 15/Ago"; H1.Text = "20:30 hrs";
                L2.Image = Image.FromFile(Luae); V2.Image = Image.FromFile(Ldor); F2.Text = "Vie. 16/Ago"; H2.Text = "17:00 hrs";
                L3.Image = Image.FromFile(Lven); V3.Image = Image.FromFile(Ludg); F3.Text = "Vie. 16/Ago"; H3.Text = "19:00 hrs";
                L4.Image = Image.FromFile(Lzac); V4.Image = Image.FromFile(Lmin); F4.Text = "Sáb. 17/Ago"; H4.Text = "17:00 hrs";
                L5.Image = Image.FromFile(Lcaf); V5.Image = Image.FromFile(Latl); F5.Text = "Sáb. 17/Ago"; H5.Text = "19:00 hrs";
                L6.Image = Image.FromFile(Lcel); V6.Image = Image.FromFile(Lcim); F6.Text = "Dom. 18/Ago"; H6.Text = "12:00 hrs";
                L7.Image = Image.FromFile(Llor); V7.Image = Image.FromFile(Lale); F7.Text = "Dom. 18/Ago"; H7.Text = "17:00 hrs";
            }
            else if (condicion == "A4")
            {
                L1.Image = Image.FromFile(Ludg); V1.Image = Image.FromFile(Lzac); F1.Text = "Jue. 22/Ago"; H1.Text = "20:30 hrs";
                L2.Image = Image.FromFile(Lmin); V2.Image = Image.FromFile(Lcel); F2.Text = "Vie. 23/Ago"; H2.Text = "19:00 hrs";
                L3.Image = Image.FromFile(Lcor); V3.Image = Image.FromFile(Llor); F3.Text = "Vie. 23/Ago"; H3.Text = "20:08 hrs";
                L4.Image = Image.FromFile(Lale); V4.Image = Image.FromFile(Lcaf); F4.Text = "Sáb. 24/Ago"; H4.Text = "17:00 hrs";
                L5.Image = Image.FromFile(Latl); V5.Image = Image.FromFile(Luae); F5.Text = "Sáb. 24/Ago"; H5.Text = "19:00 hrs";
                L6.Image = Image.FromFile(Ldor); V6.Image = Image.FromFile(Lven); F6.Text = "Sáb. 24/Ago"; H6.Text = "21:00 hrs";
                L7.Image = Image.FromFile(Lcim); V7.Image = Image.FromFile(Ltam); F7.Text = "Dom. 25/Ago"; H7.Text = "21:00 hrs";
            }
            else if (condicion == "A5")
            {
                L1.Image = Image.FromFile(Luae); V1.Image = Image.FromFile(Lale); F1.Text = "Vie. 30/Ago"; H1.Text = "17:00 hrs";
                L2.Image = Image.FromFile(Ltam); V2.Image = Image.FromFile(Lcaf); F2.Text = "Vie. 30/Ago"; H2.Text = "19:00 hrs";
                L3.Image = Image.FromFile(Lven); V3.Image = Image.FromFile(Lmin); F3.Text = "Vie. 30/Ago"; H3.Text = "21:00 hrs";
                L4.Image = Image.FromFile(Llor); V4.Image = Image.FromFile(Lcim); F4.Text = "Sáb. 31/Ago"; H4.Text = "17:00 hrs";
                L5.Image = Image.FromFile(Lzac); V5.Image = Image.FromFile(Latl); F5.Text = "Sáb. 31/Ago"; H5.Text = "19:00 hrs";
                L6.Image = Image.FromFile(Ldor); V6.Image = Image.FromFile(Ludg); F6.Text = "Sáb. 31/Ago"; H6.Text = "21:00 hrs";
                L7.Image = Image.FromFile(Lcel); V7.Image = Image.FromFile(Lcor); F7.Text = "Dom. 01/Sep"; H7.Text = "12:00 hrs";
            }
            else if (condicion == "A6")
            {
                L1.Image = Image.FromFile(Latl); V1.Image = Image.FromFile(Ltam); F1.Text = "Jue. 12/Sep"; H1.Text = "20:30 hrs";
                L2.Image = Image.FromFile(Lmin); V2.Image = Image.FromFile(Luae); F2.Text = "Vie. 13/Sep"; H2.Text = "19:00 hrs";
                L3.Image = Image.FromFile(Lcor); V3.Image = Image.FromFile(Ldor); F3.Text = "Vie. 13/Sep"; H3.Text = "20:08 hrs";
                L4.Image = Image.FromFile(Lale); V4.Image = Image.FromFile(Lzac); F4.Text = "Sáb. 14/Sep"; H4.Text = "17:00 hrs";
                L5.Image = Image.FromFile(Lcaf); V5.Image = Image.FromFile(Llor); F5.Text = "Sáb. 14/Sep"; H5.Text = "19:00 hrs";
                L6.Image = Image.FromFile(Lcim); V6.Image = Image.FromFile(Lven); F6.Text = "Sáb. 14/Sep"; H6.Text = "21:00 hrs";
                L7.Image = Image.FromFile(Ludg); V7.Image = Image.FromFile(Lcel); F7.Text = "Dom. 15/Sep"; H7.Text = "12:00 hrs";
            }
            else if (condicion == "A7")
            {
                L1.Image = Image.FromFile(Ldor); V1.Image = Image.FromFile(Lcaf); F1.Text = "Jue. 19/Sep"; H1.Text = "21:00 hrs";
                L2.Image = Image.FromFile(Llor); V2.Image = Image.FromFile(Latl); F2.Text = "Vie. 20/Sep"; H2.Text = "17:00 hrs";
                L3.Image = Image.FromFile(Ltam); V3.Image = Image.FromFile(Ludg); F3.Text = "Vie. 20/Sep"; H3.Text = "19:00 hrs";
                L4.Image = Image.FromFile(Lven); V4.Image = Image.FromFile(Lale); F4.Text = "Vie. 20/Sep"; H4.Text = "21:00 hrs";
                L5.Image = Image.FromFile(Lzac); V5.Image = Image.FromFile(Lcor); F5.Text = "Sáb. 21/Sep"; H5.Text = "17:00 hrs";
                L6.Image = Image.FromFile(Lcim); V6.Image = Image.FromFile(Lmin); F6.Text = "Sáb. 21/Sep"; H6.Text = "21:00 hrs";
                L7.Image = Image.FromFile(Lcel); V7.Image = Image.FromFile(Luae); F7.Text = "Dom. 22/Sep"; H7.Text = "17:00 hrs";
            }
            else if (condicion == "A8")
            {
                L1.Image = Image.FromFile(Luae); V1.Image = Image.FromFile(Llor); F1.Text = "Vie. 27/Sep"; H1.Text = "17:00 hrs";
                L2.Image = Image.FromFile(Lmin); V2.Image = Image.FromFile(Lcaf); F2.Text = "Vie. 27/Sep"; H2.Text = "19:00 hrs";
                L3.Image = Image.FromFile(Latl); V3.Image = Image.FromFile(Ludg); F3.Text = "Vie. 27/Sep"; H3.Text = "21:00 hrs";
                L4.Image = Image.FromFile(Lale); V4.Image = Image.FromFile(Ltam); F4.Text = "Sáb. 28/Sep"; H4.Text = "17:00 hrs";
                L5.Image = Image.FromFile(Lcor); V5.Image = Image.FromFile(Lcim); F5.Text = "Sáb. 28/Sep"; H5.Text = "19:00 hrs";
                L6.Image = Image.FromFile(Ldor); V6.Image = Image.FromFile(Lzac); F6.Text = "Sáb. 28/Sep"; H6.Text = "21:00 hrs";
                L7.Image = Image.FromFile(Lcel); V7.Image = Image.FromFile(Lven); F7.Text = "Dom. 29/Sep"; H7.Text = "12:00 hrs";
            }
            else if (condicion == "A9")
            {
                L1.Image = Image.FromFile(Lzac); V1.Image = Image.FromFile(Lven); F1.Text = "Jue. 03/Oct"; H1.Text = "20:30 hrs";
                L2.Image = Image.FromFile(Ltam); V2.Image = Image.FromFile(Lcel); F2.Text = "Vie. 04/Oct"; H2.Text = "19:00 hrs";
                L3.Image = Image.FromFile(Lcaf); V3.Image = Image.FromFile(Lcor); F3.Text = "Vie. 04/Oct"; H3.Text = "21:00 hrs";
                L4.Image = Image.FromFile(Llor); V4.Image = Image.FromFile(Lmin); F4.Text = "Sáb. 05/Oct"; H4.Text = "17:00 hrs";
                L5.Image = Image.FromFile(Ludg); V5.Image = Image.FromFile(Luae); F5.Text = "Dom. 06/Oct"; H5.Text = "12:00 hrs";
                L6.Image = Image.FromFile(Latl); V6.Image = Image.FromFile(Lale); F6.Text = "Dom. 06/Oct"; H6.Text = "19:00 hrs";
                L7.Image = Image.FromFile(Lcim); V7.Image = Image.FromFile(Ldor); F7.Text = "Dom. 06/Oct"; H7.Text = "21:00 hrs";
            }
            else if (condicion == "A10")
            {
                L1.Image = Image.FromFile(Ldor); V1.Image = Image.FromFile(Latl); F1.Text = "Jue. 17/Oct"; H1.Text = "21:00 hrs";
                L2.Image = Image.FromFile(Luae); V2.Image = Image.FromFile(Lcaf); F2.Text = "Vie. 18/Oct"; H2.Text = "17:00 hrs";
                L3.Image = Image.FromFile(Lmin); V3.Image = Image.FromFile(Ludg); F3.Text = "Vie. 18/Oct"; H3.Text = "19:00 hrs";
                L4.Image = Image.FromFile(Lven); V4.Image = Image.FromFile(Ltam); F4.Text = "Vie. 18/Oct"; H4.Text = "21:00 hrs";
                L5.Image = Image.FromFile(Lzac); V5.Image = Image.FromFile(Lcim); F5.Text = "Sáb. 19/Oct"; H5.Text = "17:00 hrs";
                L6.Image = Image.FromFile(Lcor); V6.Image = Image.FromFile(Lale); F6.Text = "Sáb. 19/Oct"; H6.Text = "19:00 hrs";
                L7.Image = Image.FromFile(Lcel); V7.Image = Image.FromFile(Llor); F7.Text = "Dom. 20/Oct"; H7.Text = "12:00 hrs";
            }
            else if (condicion == "A11")
            {
                L1.Image = Image.FromFile(Latl); V1.Image = Image.FromFile(Lcel); F1.Text = "Jue. 24/Oct"; H1.Text = "20:30 hrs";
                L2.Image = Image.FromFile(Lale); V2.Image = Image.FromFile(Lmin); F2.Text = "Vie. 25/Oct"; H2.Text = "20:00 hrs";
                L3.Image = Image.FromFile(Llor); V3.Image = Image.FromFile(Ldor); F3.Text = "Sáb. 26/Oct"; H3.Text = "17:00 hrs";
                L4.Image = Image.FromFile(Lcaf); V4.Image = Image.FromFile(Lven); F4.Text = "Sáb. 26/Oct"; H4.Text = "19:00 hrs";
                L5.Image = Image.FromFile(Lcim); V5.Image = Image.FromFile(Luae); F5.Text = "Sáb. 26/Oct"; H5.Text = "21:00 hrs";
                L6.Image = Image.FromFile(Ludg); V6.Image = Image.FromFile(Lcor); F6.Text = "Dom. 27/Oct"; H6.Text = "12:00 hrs";
                L7.Image = Image.FromFile(Ltam); V7.Image = Image.FromFile(Lzac); F7.Text = "Dom. 27/Oct"; H7.Text = "19:00 hrs";
            }
            else if (condicion == "A12")
            {
                L1.Image = Image.FromFile(Llor); V1.Image = Image.FromFile(Ltam); F1.Text = "Vie. 01/Nov"; H1.Text = "17:00 hrs";
                L2.Image = Image.FromFile(Lcor); V2.Image = Image.FromFile(Lmin); F2.Text = "Vie. 01/Nov"; H2.Text = "20:08 hrs";
                L3.Image = Image.FromFile(Lven); V3.Image = Image.FromFile(Latl); F3.Text = "Vie. 01/Nov"; H3.Text = "21:00 hrs";
                L4.Image = Image.FromFile(Lcel); V4.Image = Image.FromFile(Lcaf); F4.Text = "Sáb. 02/Nov"; H4.Text = "17:00 hrs";
                L5.Image = Image.FromFile(Ldor); V5.Image = Image.FromFile(Lale); F5.Text = "Sáb. 02/Nov"; H5.Text = "21:00 hrs";
                L6.Image = Image.FromFile(Lcim); V6.Image = Image.FromFile(Ludg); F6.Text = "Sáb. 02/Nov"; H6.Text = "21:00 hrs";
                L7.Image = Image.FromFile(Lzac); V7.Image = Image.FromFile(Luae); F7.Text = "Dom. 03/Nov"; H7.Text = "16:30 hrs";
            }
            else if (condicion == "A13")
            {
                L1.Image = Image.FromFile(Lmin); V1.Image = Image.FromFile(Ldor); F1.Text = "Jue. 07/Nov"; H1.Text = "20:30 hrs";
                L2.Image = Image.FromFile(Luae); V2.Image = Image.FromFile(Ltam); F2.Text = "Vie. 08/Nov"; H2.Text = "17:00 hrs";
                L3.Image = Image.FromFile(Latl); V3.Image = Image.FromFile(Lcim); F3.Text = "Vie. 08/Nov"; H3.Text = "19:00 hrs";
                L4.Image = Image.FromFile(Lcor); V4.Image = Image.FromFile(Lven); F4.Text = "Vie. 08/Nov"; H4.Text = "21:00 hrs";
                L5.Image = Image.FromFile(Lale); V5.Image = Image.FromFile(Lcel); F5.Text = "Sáb. 09/Nov"; H5.Text = "18:00 hrs";
                L6.Image = Image.FromFile(Lcaf); V6.Image = Image.FromFile(Lzac); F6.Text = "Sáb. 09/Nov"; H6.Text = "20:00 hrs";
                L7.Image = Image.FromFile(Ludg); V7.Image = Image.FromFile(Llor); F7.Text = "Dom. 10/Nov"; H7.Text = "12:00 hrs";
            }
            #endregion
        }
    }
}
