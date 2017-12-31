using Lotofacil.Infrastructure;
using LotoFacil.Model.Lotofacil;
using Newtonsoft.Json;

namespace LotoFacil.Data
{
    public class LotoFacilRepository
    {
        private const string BASE_URL = @"https://www.lotodicas.com.br/api/lotofacil";

        public LotofacilProxyModel GetResultGame(int? gameNumber = null)
        {
            var url = BASE_URL;

            if (gameNumber != null)
            {
                url += "/" + gameNumber;
            }

            string json = RequestHelper.HttpGet(url);

            var result = JsonConvert.DeserializeObject<LotofacilProxyModel>(json);

            return result;
        }
    }
}
