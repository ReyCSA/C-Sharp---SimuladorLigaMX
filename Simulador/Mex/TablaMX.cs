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

using System.IO;
using iTextSharp.text;
using iTextSharp.text.html;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;

namespace Simulador.Simulador.Mex
{
    public partial class TablaMX : Form
    {
        private string Lliga = "C:/APP Liga/Simulador/Simulador/img/Mex/LigaMX.png";

        TablaG OTabla = new TablaG();
        Partidos Opartido = new Partidos();

        public TablaMX()
        {
            InitializeComponent();
        }

        #region Combobox
        private void cmbJornada_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblJornada.Text = cmbJornada.SelectedItem.ToString();
        }

        private void cmbTorneo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTorneo.Text = cmbTorneo.SelectedItem.ToString();
        }
        #endregion

        private void Tabla_Load(object sender, EventArgs e)
        {
            pbLiga.Image = System.Drawing.Image.FromFile(Lliga);
            this.cmbTorneo.Items.Add("Apertura"); this.cmbTorneo.Items.Add("Clausura");
            for (int i = 1; i <= 19; i++) this.cmbJornada.Items.Add("Jornada " + i);

            OTabla.LoadImg(TG);
            Opartido.TablaJugada(TablaJ, cmbTorneo, cmbJornada);
        }

        #region Guardar Tablas
        private void button1_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(TG.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 80;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 0;

            //Adding Header row
            foreach (DataGridViewColumn column in TG.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                cell.Border = 0;
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in TG.Rows)
            {               
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }

            //Exporting to PDF C:\APP Liga\Simulador\Simulador\bin\Debug\Tablas
            if (lblTorneo.Text == "Torneo" || lblJornada.Text == "Jornada")
                MessageBox.Show("Seleccione Torneo y Jornada");
            else
            {
                string folderPath = "C:\\APP Liga\\Simulador\\Simulador\\bin\\Debug\\Tablas\\Mex\\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                using (FileStream stream = new FileStream(folderPath + lblTorneo.Text + " 2019 " + lblJornada.Text + ".pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);

                    Paragraph title = new Paragraph(string.Format(lblTorneo.Text + " 2019 " + lblJornada.Text), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.BOLD));
                    Paragraph salto = new Paragraph(string.Format("\n"));
                    title.Alignment = Element.ALIGN_CENTER;

                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(title);
                    pdfDoc.Add(salto);
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }

                MessageBox.Show(lblTorneo.Text + " 2019 " + lblJornada.Text + " Guardada Correctamente!");
            }
        }
        #endregion

        #region Consultar Tablas
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblTorneo.Text == "Torneo" || lblJornada.Text == "Jornada")
                    MessageBox.Show("Seleccione Torneo y Jornada");
                else
                    System.Diagnostics.Process.Start(@"C:\APP Liga\Simulador\Simulador\bin\Debug\Tablas\Mex\" + lblTorneo.Text + " 2019 " + lblJornada.Text + ".pdf");
            }catch
            {
                MessageBox.Show(lblTorneo.Text + " 2019 " + lblJornada.Text + " Aun no Jugada!");
            }
        }
        #endregion
    }
}
