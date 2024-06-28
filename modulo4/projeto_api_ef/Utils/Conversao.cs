using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_api_ef.Utils
{
    public class Conversao
    {
        public static DateTime DataSParaDateTime(string dataString) {
            string formato = "dd/MM/yyyy";
            try
            {
                DateTime data = DateTime.ParseExact(dataString, formato, CultureInfo.InvariantCulture);
                return data;
            }
            catch (FormatException)
            {
                throw new FormatException("Não foi possivel converter a data em texto para datetime");
            }
        }
    }
}