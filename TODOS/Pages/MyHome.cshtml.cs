using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TODOS.Pages
{
    public class Info{

        public string Message;
    }
    public class MyHomeModel : PageModel
    {
        public Info info { get; private set; } = new Info();
       

        public void OnPost(string Message)
        {
            info = new Info()
            {
                Message = Message,
            };
        }
        public void OnGet(string message)
        {
            Info info = new Info()
            {
                Message = message,
            };
        }
    }
}

