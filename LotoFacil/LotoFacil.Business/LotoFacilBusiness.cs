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

            List<GameResult> resultList = new List<GameResult>();

            List<Ten> tenList = Ten.CreateTenList();

            resultList.Add(repository.GetResultGame());

            int lastNumberGame = resultList.FirstOrDefault().GameNumber;

            for (int i = lastNumberGame - 9; i < lastNumberGame; i++)
            {
                resultList.Add(repository.GetResultGame(i));
            }

            OrderResults(tenList, resultList);

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

        private void OrderResults(List<Ten> tenList, List<GameResult> gameResultList)
        {
            foreach (var result in gameResultList)
            {
                foreach (var ten in result.TenList)
                {
                    tenList.FirstOrDefault(d => d.Number == ten).Qty++;
                }
            }

            tenList.OrderByDescending(t => t.Qty);
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
