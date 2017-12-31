using MongoDb.Entidades;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDb
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var settings = new MongoClientSettings()
                {
                    ServerSelectionTimeout = new TimeSpan(0, 0, 5),
                    Server = new MongoServerAddress("localhost", 27017)
                };

                var client = new MongoClient(settings);

                var database = client.GetDatabase("teste");

                var colecao = database.GetCollection<Cliente>("clientes");

                //Select(colecao);

                //Delete(colecao);

                Insert(colecao);

                //Update(colecao);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private static void Select(IMongoCollection<usuario> colecao)
        {
            var filtro = Builders<usuario>.Filter.Empty;

            var usuarios = colecao.Find(filtro).ToList();

            foreach (var item in usuarios)
            {
                Console.WriteLine("Usuario: " + item.nome);
            }

            Console.ReadLine();
        }

        private static void Delete(IMongoCollection<usuario> colecao)
        {
            var filtro = Builders<usuario>.Filter.Eq(u => u.nome, "Nicholas");

            colecao.DeleteOne(filtro);
        }

        private static void Update(IMongoCollection<usuario> colecao)
        {
            var filtro = Builders<usuario>.Filter.Eq(u => u.nome, "Nicholas");

            var alteracao = Builders<usuario>.Update.Set(u => u.nome, "Nichola2");

            colecao.UpdateOne(filtro, alteracao);
        }

        private static void Insert(IMongoCollection<usuario> colecao)
        {
            var usuario = new usuario()
            {
                nome = "Nicholas",
                senha = "123456"
            };

            colecao.InsertOne(usuario);
        }

        private static void Insert(IMongoCollection<Cliente> colecao)
        {
            var cliente = new Cliente()
            {
                email = "giovana@bla.com",
                nome = "Giovana",
                senha = "123456",
                dataNascimento = new DateTime(1993, 12, 10),
                sexo = Sexo.Feminino,
                telefone = "213213213",
                cartoes = new List<Cartao>()
                {
                    new Cartao()
                    {
                        numero = "21321321321321",
                        bandeira = Bandeira.Master,
                        anoValidade = "2019",
                        mesValidade = "12",
                        nome = "NICHOLAS M GIUDICE",
                        CCV = "213"
                    }
                }
            };

            colecao.InsertOne(cliente);
        }
    }
}
