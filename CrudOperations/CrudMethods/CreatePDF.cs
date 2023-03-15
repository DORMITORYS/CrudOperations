using CrudOperations.ApplicationDbContext;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tables.Models;

namespace CrudOperations.CrudMethods
{
    public class CreatePDF
    {
        public CreatePDF()
        {
            Console.Write("Enter your id: ");
            int id = int.Parse(Console.ReadLine());
            AppDbContext appDbContext = new AppDbContext();
            PdfDocument document = new PdfDocument();
            var yourCertificates = (from Result in appDbContext.Results
                                    where Result.Candidates.CandidateID == id
                                    select Result).ToList<Result>();
            //PdfPage page = document.AddPage();
            foreach (var certificate in yourCertificates)
            {
                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XFont font = new XFont("Verdana", 6, XFontStyle.Bold);
                gfx.DrawString(certificate.ToString(), font, XBrushes.Black,
                new XRect(0, 0, page.Width, page.Height), XStringFormats.TopLeft);
                string filename = "Certificates.pdf";
                document.Save(filename);
                Process.Start(filename);
            }
            appDbContext.Dispose();
        }
    }
}
