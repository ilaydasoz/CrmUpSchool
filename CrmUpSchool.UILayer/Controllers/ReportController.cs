using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;
using CrmUpSchool.DataAccessLayer.Concrete;
using CrmUpSchool.UILayer.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

namespace CrmUpSchool.UILayer.Controllers
{
    [AllowAnonymous]
    public class ReportController : Controller
    {
        //static excel List
        public IActionResult ReportList()
        {
            return View();
        }

        public IActionResult ExcelStatic()
        {
            ExcelPackage excelPackage = new ExcelPackage();
            var workSheet = excelPackage.Workbook.Worksheets.Add("Page 1");
            workSheet.Cells[1, 1].Value = "Employee ID";
            workSheet.Cells[1, 2].Value = "Employee Name";
            workSheet.Cells[1, 2].Value = "Employee Surname";

            workSheet.Cells[2, 1].Value = "0001";
            workSheet.Cells[2, 2].Value = "Ally";
            workSheet.Cells[2, 3].Value = "Connor";

            workSheet.Cells[3, 1].Value = "0002";
            workSheet.Cells[3, 2].Value = "Jacob";
            workSheet.Cells[3, 3].Value = "Rott";

            var bytes = excelPackage.GetAsByteArray();
            return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "employees.xlsx");

        }

        public List<CustomerViewModel> CustomerList()
        {
            List<CustomerViewModel> customerViewModels = new List<CustomerViewModel>();
            using (var context = new Context())
            {
                customerViewModels = context.Customers.Select(x => new CustomerViewModel
                {
                    Mail = x.CustomerMail,
                    Name = x.CustomerName,
                    Surname = x.CustomerSurname,
                    Phone = x.CustomerPhone
                }).ToList();
            }

            return customerViewModels;
        }

        public IActionResult DynamicExcel()
        {
            using(var workBook = new XLWorkbook) //workbook acilan excel dosyasi
            {
                var workSheet = workBook.Worksheets.Add("Customer List"); // worksheet calistigimiz excel sayfasi
                workSheet.Cell(1, 1).Value = "E-mail";
                workSheet.Cell(1, 2).Value = "Customer Name";
                workSheet.Cell(1, 3).Value = "Customer Surname";
                workSheet.Cell(1, 4).Value = "Customer Phone Number";

                int rowCount = 2;
                foreach(var item in CustomerList())
                {
                    workSheet.Cell(rowCount, 1).Value = item.Mail;
                    workSheet.Cell(rowCount, 2).Value = item.Name;
                    workSheet.Cell(rowCount, 3).Value = item.Surname;
                    workSheet.Cell(rowCount, 4).Value = item.Phone;
                    rowCount++;
                }
                using(var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "customer_list.xlsx");
                }
            }
        }

        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "Customer.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();
            Paragraph paragraph = new Paragraph("Akbank & Up School Asp.Net Full Stack .Net Core Backend Proje");
            document.Add(paragraph);
            document.Close();
            return File("/PdfReports/Customer.pdf","application/pdf","Customer.pdf"); //indirilebilir dosya formatinda olmasi icin file return etmelidir

        }

    }
}
