using Lotofacil.Infrastructure;
using LotoFacil.Model.Lotofacil;
using Newtonsoft.Json;

namespace LotoFacil.Data
{
    public class LotoFacilRepository
    {
        private string url = @"https://confiraloterias.com.br/api/json/?loteria=lotofacil&token=HExddhWwRlbUViV";

        public GameResult GetResultGame(int? gameNumber = null)
        {
            ResultLotoFacil result = new ResultLotoFacil();

            if(gameNumber != null)
            {
                url += "&concurso=" + gameNumber;
            }

            string json = RequestHelper.HttpGet(url);

            result = JsonConvert.DeserializeObject<ResultLotoFacil>(json);

            return result.GameResult;
        }
    }
}
