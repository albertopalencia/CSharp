using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDb
{
    public class usuario
    {
        public ObjectId _id { get; set; }

        public string nome { get; set; }

        public string senha { get; set; }
    }
}
