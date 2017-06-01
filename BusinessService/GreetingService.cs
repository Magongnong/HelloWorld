using System.Linq;
using Infrstructure.DAL;

namespace BusinessService
{
    public class GreetingService : IGreetingService
    {
        private GreetingEntities _context = null;

        public GreetingService()
        {
            _context = new GreetingEntities();
        }

        public string GetHelloWorld()
        {
            var greeting = _context.Greetings
                            .Where(g => g.Name == "Hello World")
                            .Select(g => g.Name)
                            .FirstOrDefault();
            if (string.IsNullOrWhiteSpace(greeting))
                greeting = "Hello World";
            
            return greeting;
        }
    }
}
