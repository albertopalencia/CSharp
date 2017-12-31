using LotoFacil.Data;
using LotoFacil.Model.Lotofacil;
using System.Collections.Generic;
using System.Linq;
using System;

namespace LotoFacil.Business
{
    public class LotoFacilBusiness
    {
        public void teste()
        {
            LotoFacilRepository repository = new LotoFacilRepository();

            List<LotofacilProxyModel> resultList = new List<LotofacilProxyModel>();

            List<Ten> tenList = Ten.CreateTenList();

            resultList.Add(repository.GetResultGame());

            int lastNumberGame = resultList.FirstOrDefault().numero;

            for (int i = lastNumberGame - 9; i < lastNumberGame; i++)
            {
                resultList.Add(repository.GetResultGame(i));
            }

            OrderResults(ref tenList, resultList);

            var TenFixed = getTenFixe(tenList);

            var TenExcepet = getTenExcept(tenList);

        }

        private object getTenExcept(List<Ten> tenList)
        {
            var result = new List<int>();

            tenList.Reverse();

            foreach (var item in tenList.Take(2))
            {
                result.Add(item.Number);
            } 
            
            return result;
        }

        private void OrderResults(ref List<Ten> tenList, List<LotofacilProxyModel> gameResultList)
        {
            foreach (var result in gameResultList)
            {
                foreach (var ten in result.sorteio)
                {
                    tenList.FirstOrDefault(d => d.Number == ten).Qty++;
                }
            }

            tenList = tenList.OrderByDescending(t => t.Qty).ToList();
        }

        private List<int> getTenFixe(List<Ten> tenList)
        {
            var result = new List<int>();

            foreach (var item in tenList.Take(3))
            {
                result.Add(item.Number);
            }

            return result;
        }

    }
}
