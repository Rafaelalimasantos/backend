using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using  _17_CRUD.Models;

namespace _17_CRUD.Controllers
{
    //criando a classe TarefaController e herdando seus metodos de Controller
    public class TarefaController : Controller
    {
        //criando um objeto _tarefas que armazenara uma lista de tarefas
        private static List<Tarefa> _tarefas = new List<Tarefa>();
        public IActionResult Index()
        {
            return View(_tarefas);
        }

        //criando o metodo GET para carregar a tela de Adicionar
        public IActionResult Adicionar()
        {
            return View();
        }
    
        [HttpPost]
        public IActionResult Adicionar(Tarefa novaTarefa)
        {
            //verificar o total de tarefas da lista e somando mais 1 para o ID
            novaTarefa.Id = _tarefas.Count + 1;
            //adicionando minha nova tarefa a minha lista
            _tarefas.Add(novaTarefa);
            //redirecionar para a pagina com a lista de tarefas
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int Id)
        {
            //estou buscando na minha lista a tarefa que desejo alterar
            Tarefa tarefaBD = _tarefas.FirstOrDefault(t => t.Id == Id);
            //verificando se encontrou a tarefa, se ela não e null
            if (tarefaBD == null)
                return NotFound();
            //Enviando para a View a tarefa encontrada que queremos alterar 
            return View(tarefaBD);
        }

        [HttpPost]
        public IActionResult Editar(Tarefa tarefaEditando)
        {
            //buscando tarefa da lista
            Tarefa tarefaDB = _tarefas.Find(t => t.Id == tarefaEditando.Id);
            //verificando se enontrou ela
            if (tarefaDB == null)
                return NotFound();

                //atualizando os dados da tarefa que ja esta na lista
                tarefaDB.Descricao = tarefaEditando.Descricao;
                tarefaDB.Concluida = tarefaEditando.Concluida;
                //redirecionando para a lista de tarefas
                return RedirectToAction("Index");
        }

        public IActionResult Deletar(int Id)
        {
            Tarefa tarefaBD = _tarefas.FirstOrDefault(t => t.Id == Id);
            if (tarefaBD == null)
                return NotFound();
            return View(tarefaBD);
        }

        [HttpPost]
         public IActionResult Deletar(Tarefa tarefaDeletando)
        {
            Tarefa tarefaDB = _tarefas.Find(t => t.Id == tarefaDeletando.Id);
            if (tarefaDB == null)
                return NotFound();

            _tarefas.Remove(tarefaDB);
           
            return RedirectToAction("Index");
        }


    }
}