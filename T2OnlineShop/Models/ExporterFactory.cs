using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace T2OnlineShop.Models
{
    public class ExporterFactory
    {
        public enum ExporterTypes { Csv, Json };

        public static Exporter create(ExporterTypes c)
        {
            if (c == ExporterTypes.Csv)
                return new CSVExporter();
            else
                return new JSONExporter();
        }
    }
}