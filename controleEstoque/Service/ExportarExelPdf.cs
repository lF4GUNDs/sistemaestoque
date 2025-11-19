using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.InkML;
using Google.Protobuf.WellKnownTypes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySqlX.XDevAPI;
using OfficeOpenXml;
using Org.BouncyCastle.Bcpg.Sig;
using Excel = Microsoft.Office.Interop.Excel;

namespace controleEstoque.Service
{
    public class ExportarExelPdf
    {
        DateTime timestamp = DateTime.Now;

        public void ExportarPDF(DataGridView dgv, String descricao, String descricaoparasalval)
        {

            try
            {

                PdfPTable pdfTable = new PdfPTable(dgv.ColumnCount);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTable.DefaultCell.BorderWidth = 1;
                iTextSharp.text.Font font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 7);


                float[] columnWidths = new float[dgv.ColumnCount];
                float totalWidth = 100f;
                float singleColumnWidth = totalWidth / dgv.ColumnCount;

                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    columnWidths[i] = singleColumnWidth;
                }

                pdfTable.SetWidths(columnWidths);
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdfTable.AddCell(cell);
                }

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            pdfTable.AddCell(cell.Value.ToString());
                        }
                        else
                        {
                            pdfTable.AddCell("");
                        }
                    }
                }

                string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                string dataFormatada = timestamp.ToString("yyyy-MM-dd");
                using (FileStream stream = new FileStream(folderPath +"\\"+ descricaoparasalval + dataFormatada + ".pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);

                    var header = new Paragraph(descricao , new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 25));
                    header.Alignment = Element.ALIGN_CENTER;  
                    
                    var footer = new Paragraph($"Relátorio emitido em : {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8));
                    footer.Alignment = Element.ALIGN_RIGHT;                  

                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(header);
                    pdfDoc.Add(new Paragraph("\n\n"));
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Add(footer);
                    pdfDoc.Close();
                    stream.Close();
                }
                MessageBox.Show("Expotado com Sucesso em " + folderPath);
                string filePath = folderPath + "\\" + descricaoparasalval + dataFormatada + ".pdf";
                System.Diagnostics.Process.Start("cmd", $"/c start {filePath}");

            }
            catch (Exception ex)
            {
                MessageBox.Show("O correu um erro ao expotar o arquivo" + ex);

            }
        }
        public void SalvarExcel(DataGridView dgv, String descricao, String descricaoparasalval)
        {
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (var package = new OfficeOpenXml.ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add(descricao);

                    worksheet.Cells[1, 1].Value = descricao;

                    for (int i = 0; i < dgv.ColumnCount; i++)
                    {
                        worksheet.Cells[2, i + 1].Value = dgv.Columns[i].HeaderText;
                    }


                    for (int i = 0; i < dgv.RowCount; i++)
                    {
                        for (int j = 0; j < dgv.ColumnCount; j++)
                        {
                            worksheet.Cells[i + 3, j + 1].Value = dgv.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    string dataFormatada = timestamp.ToString("yyyy-MM-dd");
                    string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    string filePath = Path.Combine(folderPath + "\\" + descricaoparasalval + dataFormatada + ".xlsx");
                    File.WriteAllBytes(filePath, package.GetAsByteArray());

                    MessageBox.Show("Expotado com Sucesso em " + filePath);

                }

               

            }
            catch(Exception ex)
            {
                MessageBox.Show("O correu um erro ao expotar o arquivo" + ex);

            }
           
        }

    }
}

