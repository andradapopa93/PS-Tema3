using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;

// pentru a rezolva acest task am instalat Json.NET conform: https://www.nuget.org/packages/newtonsoft.json/
// si am serializat dupa modelul: http://www.newtonsoft.com/json/help/html/SerializeWithJsonSerializerToFile.htm

namespace T2OnlineShop.Models
{
    public class JSONExporter : Exporter
    {
        public string export(DbSet<Product> p)
        {
            File.WriteAllText("C:\\Users\\Andrada\\Documents\\Visual Studio 2012\\Projects\\T2OnlineShop\\T2OnlineShop\\App_Data\\Products.json", JsonConvert.SerializeObject(p));
            
            return "Produsele din baza de date au fost exportate cu succes in formatul JSON!";
        }
    }
}