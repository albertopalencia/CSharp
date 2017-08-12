using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotoFacil.Model.Lotofacil
{
    public class Ten
    {
        public int Qty { get; set; }
        public int Number { get; set; }

        public static List<Ten> CreateTenList()
        {
            var result = new List<Ten>();

            for (int i = 1; i < 26; i++)
            {
                result.Add(new Ten()
                {
                    Number = i,
                    Qty = 0
                });
            }

            return result;
        }
    }
}
