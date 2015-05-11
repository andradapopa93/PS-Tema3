using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;
using System.IO;
using System.Data.Entity;

namespace T2OnlineShop.Models
{
    public class CSVExporter : Exporter
    {
        public string export(DbSet<Product> Products)
        {
            var myExport = new CsvExport();

            foreach (Product p in Products)
            {
                myExport.AddRow();
                myExport["Product ID"] = p.ProductId;
                myExport["Product name"] = p.name;
                myExport["Product type"] = p.type;
                myExport["Product price"] = p.price;
            }

            myExport.ExportToFile("C:\\Users\\Andrada\\Documents\\Visual Studio 2012\\Projects\\T2OnlineShop\\T2OnlineShop\\App_Data\\Products.csv");

            return "Produsele din baza de date au fost exportate cu succes in formatul CSV!";
        }
    }
        
}