using AspNet.TODO.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.TODO.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            TodoRepository repository = new TodoRepository();
            repository.Create();
            return View(repository.TodoList);
        }
    }
}
