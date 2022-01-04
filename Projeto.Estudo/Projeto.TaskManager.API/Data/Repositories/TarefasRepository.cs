using MongoDB.Driver;
using Projeto.TaskManager.API.Data.Configurations;
using Projeto.TaskManager.API.Models;
using System;
using System.Collections.Generic;
namespace Projeto.TaskManager.API.Data.Repositories
{
    public class TarefasRepository : ITarefasRepository
    {
        private readonly IMongoCollection<Tarefa> _tarefas;
        
        public TarefasRepository(IDataBaseConfig databaseConfig)
        {
            // acessando as configuraçoes de tarefas 
            var client = new MongoClient(databaseConfig.ConnectionString);
            var database = client.GetDatabase(databaseConfig.DataBaseName);

            _tarefas = database.GetCollection<Tarefa>("tarefas");

        }

        public void Adicionar(Tarefa tarefa)
        {
            _tarefas.InsertOne(tarefa);
        }

        public void Atualizar(string id, Tarefa tarefaAtualizada)
        {
            _tarefas.ReplaceOne(tarefa => tarefa.Id == id, tarefaAtualizada );
        }

        public IEnumerable<Tarefa> Buscar()
        {

            return _tarefas.Find(tarefa => true).ToList();            
        }

        public Tarefa Buscar(string id)
        {
            return _tarefas.Find(tarefa => tarefa.Id == id).FirstOrDefault();
        }

        public void Remover(string id)
        {
            _tarefas.DeleteOne(tarefa => tarefa.Id == id);
        }
    }
}
