using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPS
{
    public  class ExpatUser
    {       
        public event Action UserCreatedEvent;

        public void UserCreatedMethod()
        {
            Console.WriteLine("User Created Successfully!");
            UserCreatedEvent?.Invoke();          
        }

    }
}
