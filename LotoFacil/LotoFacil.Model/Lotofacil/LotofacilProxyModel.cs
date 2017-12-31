using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotoFacil.Model.Lotofacil
{
    public class LotofacilProxyModel
    {
        public int numero { get; set; }
        public string data { get; set; }
        public List<int> sorteio { get; set; }
        public List<int> ganhadores { get; set; }
        public List<double> rateio { get; set; }
        public string acumulado { get; set; }
        public int valor_acumulado { get; set; }
        public List<List<string>> cidades { get; set; }
        public int proximo_estimativa { get; set; }
        public string proximo_data { get; set; }
    }
}
