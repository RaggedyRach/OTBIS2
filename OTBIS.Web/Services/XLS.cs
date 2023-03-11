using ClosedXML.Excel;
using OTBIS.Web.Models.ReportObjects;

namespace OTBIS.Web.Services
{
    public class XLS
    {

        public byte[] Edition(TransByDate[] data)
        {
            var wb = new XLWorkbook();

            wb.Properties.Author = "Rachael McKeown";
            wb.Properties.Title = "Report Download";
            wb.Properties.Subject = "OTBIS Report";

            var ws = wb.Worksheets.Add("Download");
            
            ws.Cell(1, 1).Value = "date";
            ws.Cell(1, 2).Value = "count";
            ws.Cell(1, 3).Value = "net";
            ws.Cell(1, 4).Value = "vat";
            ws.Cell(1, 5).Value = "gross";
            ws.Cell(1, 6).Value = "sale amount";
            ws.Cell(1, 7).Value = "discount";


            for (int row = 1; row < data.Length; row++)
            {
                ws.Cell(row + 1, 1).Value = data[row].TransDate;
                ws.Cell(row + 1, 2).Value = data[row].TransCount;
                ws.Cell(row + 1, 3).Value = data[row].Net_Value;
                ws.Cell(row + 1, 4).Value = data[row].Vat_Value;
                ws.Cell(row + 1, 5).Value = data[row].Gross_Value;
                ws.Cell(row + 1, 6).Value = data[row].Gross_Sale_Value;
                ws.Cell(row + 1, 7).Value = data[row].Discount_Value;
            }

            MemoryStream XLSStream = new();
            wb.SaveAs(XLSStream);

            return XLSStream.ToArray();

        }
        public byte[] EditionMonth(TransByMonth[] data)
        {
            var wb = new XLWorkbook();

            wb.Properties.Author = "Rachael McKeown";
            wb.Properties.Title = "Report Download";
            wb.Properties.Subject = "OTBIS Report";

            var ws = wb.Worksheets.Add("Download");

            ws.Cell(1, 1).Value = "Month";
            ws.Cell(1, 2).Value = "count";
            ws.Cell(1, 3).Value = "net";
            ws.Cell(1, 4).Value = "vat";
            ws.Cell(1, 5).Value = "gross";
            ws.Cell(1, 6).Value = "sale amount";
            ws.Cell(1, 7).Value = "discount";


            for (int row = 1; row < data.Length; row++)
            {
                ws.Cell(row + 1, 1).Value = data[row].Month;
                ws.Cell(row + 1, 2).Value = data[row].TransCount;
                ws.Cell(row + 1, 3).Value = data[row].Net_Value;
                ws.Cell(row + 1, 4).Value = data[row].Vat_Value;
                ws.Cell(row + 1, 5).Value = data[row].Gross_Value;
                ws.Cell(row + 1, 6).Value = data[row].Gross_Sale_Value;
                ws.Cell(row + 1, 7).Value = data[row].Discount_Value;
            }

            MemoryStream XLSStream = new();
            wb.SaveAs(XLSStream);

            return XLSStream.ToArray();

        }
        public byte[] EditionDept(TransByDept[] data)
        {
            var wb = new XLWorkbook();

            wb.Properties.Author = "Rachael McKeown";
            wb.Properties.Title = "Report Download";
            wb.Properties.Subject = "OTBIS Report";

            var ws = wb.Worksheets.Add("Download");

            ws.Cell(1, 1).Value = "Id";
            ws.Cell(1, 2).Value = "department";
            ws.Cell(1, 3).Value = "count";
            ws.Cell(1, 4).Value = "net";
            ws.Cell(1, 5).Value = "vat";
            ws.Cell(1, 6).Value = "gross";
            ws.Cell(1, 7).Value = "sale amount";
            ws.Cell(1, 8).Value = "discount";


            for (int row = 1; row < data.Length; row++)
            {
                ws.Cell(row + 1, 1).Value = data[row].DepartmentId;
                ws.Cell(row + 1, 2).Value = data[row].Department;
                ws.Cell(row + 1, 3).Value = data[row].TransCount;
                ws.Cell(row + 1, 4).Value = data[row].Net_Value;
                ws.Cell(row + 1, 5).Value = data[row].Vat_Value;
                ws.Cell(row + 1, 6).Value = data[row].Gross_Value;
                ws.Cell(row + 1, 7).Value = data[row].Gross_Sale_Value;
                ws.Cell(row + 1, 8).Value = data[row].Discount_Value;
            }

            MemoryStream XLSStream = new();
            wb.SaveAs(XLSStream);

            return XLSStream.ToArray();

        }
        public byte[] EditionCat(TransByCat[] data)
        {
            var wb = new XLWorkbook();

            wb.Properties.Author = "Rachael McKeown";
            wb.Properties.Title = "Report Download";
            wb.Properties.Subject = "OTBIS Report";

            var ws = wb.Worksheets.Add("Download");

            ws.Cell(1, 1).Value = "category Id";
            ws.Cell(1, 2).Value = "category";
            ws.Cell(1, 3).Value = "count";
            ws.Cell(1, 4).Value = "net";
            ws.Cell(1, 5).Value = "vat";
            ws.Cell(1, 6).Value = "gross";
            ws.Cell(1, 7).Value = "sale amount";
            ws.Cell(1, 8).Value = "discount";


            for (int row = 1; row < data.Length; row++)
            {
                ws.Cell(row + 1, 1).Value = data[row].CategoryId;
                ws.Cell(row + 1, 2).Value = data[row].Category;
                ws.Cell(row + 1, 3).Value = data[row].TransCount;
                ws.Cell(row + 1, 4).Value = data[row].Net_Value;
                ws.Cell(row + 1, 5).Value = data[row].Vat_Value;
                ws.Cell(row + 1, 6).Value = data[row].Gross_Value;
                ws.Cell(row + 1, 7).Value = data[row].Gross_Sale_Value;
                ws.Cell(row + 1, 8).Value = data[row].Discount_Value;
            }

            MemoryStream XLSStream = new();
            wb.SaveAs(XLSStream);

            return XLSStream.ToArray();

        }


        public byte[] EditionSubCat(TransBySubCat[] data)
        {
            var wb = new XLWorkbook();

            wb.Properties.Author = "Rachael McKeown";
            wb.Properties.Title = "Report Download";
            wb.Properties.Subject = "OTBIS Report";

            var ws = wb.Worksheets.Add("Download");

            ws.Cell(1, 1).Value = "subcategory Id";
            ws.Cell(1, 2).Value = "subcategory";
            ws.Cell(1, 3).Value = "count";
            ws.Cell(1, 4).Value = "net";
            ws.Cell(1, 5).Value = "vat";
            ws.Cell(1, 6).Value = "gross";
            ws.Cell(1, 7).Value = "sale amount";
            ws.Cell(1, 8).Value = "discount";


            for (int row = 1; row < data.Length; row++)
            {
                ws.Cell(row + 1, 1).Value = data[row].SubCategoryId;
                ws.Cell(row + 1, 2).Value = data[row].SubCategory;
                ws.Cell(row + 1, 3).Value = data[row].TransCount;
                ws.Cell(row + 1, 4).Value = data[row].Net_Value;
                ws.Cell(row + 1, 5).Value = data[row].Vat_Value;
                ws.Cell(row + 1, 6).Value = data[row].Gross_Value;
                ws.Cell(row + 1, 7).Value = data[row].Gross_Sale_Value;
                ws.Cell(row + 1, 8).Value = data[row].Discount_Value;
            }

            MemoryStream XLSStream = new();
            wb.SaveAs(XLSStream);

            return XLSStream.ToArray();

        }

        public byte[] EditionItem(TransByItem[] data)
        {
            var wb = new XLWorkbook();

            wb.Properties.Author = "Rachael McKeown";
            wb.Properties.Title = "Report Download";
            wb.Properties.Subject = "OTBIS Report";

            var ws = wb.Worksheets.Add("Download");

            ws.Cell(1, 1).Value = "date";
            ws.Cell(1, 2).Value = "count";
            ws.Cell(1, 3).Value = "net";
            ws.Cell(1, 4).Value = "vat";
            ws.Cell(1, 5).Value = "gross";
            ws.Cell(1, 6).Value = "sale amount";
            ws.Cell(1, 7).Value = "discount";


            for (int row = 1; row < data.Length; row++)
            {
                ws.Cell(row + 1, 1).Value = data[row].ItemId;
                ws.Cell(row + 1, 2).Value = data[row].Item;
                ws.Cell(row + 1, 3).Value = data[row].TransCount;
                ws.Cell(row + 1, 4).Value = data[row].Net_Value;
                ws.Cell(row + 1, 5).Value = data[row].Vat_Value;
                ws.Cell(row + 1, 6).Value = data[row].Gross_Value;
                ws.Cell(row + 1, 7).Value = data[row].Gross_Sale_Value;
                ws.Cell(row + 1, 8).Value = data[row].Discount_Value;
            }

            MemoryStream XLSStream = new();
            wb.SaveAs(XLSStream);

            return XLSStream.ToArray();

        }
    }
}

