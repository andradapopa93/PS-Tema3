using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2OnlineShop.Models
{
    public interface Exporter
    {
        string export(DbSet<Product> p);
    }
}
