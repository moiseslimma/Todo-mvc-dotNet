using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Todo.Contexts;
using Todo.Models;

namespace Todo.Controllers
{
    public class TodoController : Controller
    {
        private readonly TodosContext _context;

        public TodoController(TodosContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            @ViewData["Title"] = "Lista de Tarefas";
            var todos = _context.Todos.ToList();
            return View(todos);
        }
        
        public IActionResult Create()
        {
            @ViewData["Title"] = "Nova Tarefa";
            return View("Form");
        }
        [HttpPost]
        public IActionResult Create(Todos todo)
        {
            if(ModelState.IsValid)
            {
                todo.CreatedAt = DateTime.Now;
                _context.Todos.Add(todo);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            @ViewData["Title"] = "Nova Tarefa";
            return View("Form", todo);
        }
        public IActionResult Edit(int id)
        {
            var todo = _context.Todos.Find(id);
            if (todo is null)
            {
                return NotFound();
            }
            @ViewData["Title"] = "Editar Tarefa";
            return View("Form", todo);
        }

        [HttpPost]
        public IActionResult Edit(Todos todo)
        {
            if(ModelState.IsValid)
            {
                _context.Todos.Update(todo);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Title"] = "Editar tarefa";
            return View("Form", todo);
        }
        public IActionResult Delete(int id)
        {
            var todo = _context.Todos.Find(id);
            if (todo is null)
            {
                return NotFound();
            }
            @ViewData["Title"] = "Excluir Tarefa";
            return View(todo);
        }
        
        [HttpPost]
        public IActionResult Delete(Todos todo)
        {
            _context.Todos.Remove(todo);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));;
        }
        public IActionResult Finish(int id)
        {
            var todo = _context.Todos.Find(id);
            if (todo is null)
            {
                return NotFound();
            }
            todo.Finish();
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}