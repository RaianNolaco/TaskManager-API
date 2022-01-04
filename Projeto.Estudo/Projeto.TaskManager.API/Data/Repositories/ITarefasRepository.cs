using Projeto.TaskManager.API.Models;
using System;
using System.Collections.Generic;

namespace Projeto.TaskManager.API.Data.Repositories
{
    public interface ITarefasRepository
    {

        void Adicionar(Tarefa tarefa);

        void Atualizar(string id,Tarefa tarefaAtualizada);

        IEnumerable<Tarefa> Buscar();

        Tarefa Buscar(string id);

        void Remover(string id);


    }
}
