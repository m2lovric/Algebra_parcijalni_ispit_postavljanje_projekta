using AspNet.TODO.Models;

namespace AspNet.TODO.Repository
{
    public class TodoRepository
    {
        public List<Todo> TodoList;

        public void Create()
        {
            TodoList = new List<Todo>() 
            { 
                new Todo() { Id=1, Title="Napravi parcijalni", isDone=true },
                new Todo() { Id=2, Title="Zamijeni gume na autu", isDone=false },
                new Todo() { Id=3, Title="Kupi namirnice za ručak", isDone=false },
                new Todo() { Id=4, Title="Šišanje u 15h", isDone=false },
                new Todo() { Id=5, Title="Pročitaj knjigu", isDone=false },
            };  
        }
    }
}
