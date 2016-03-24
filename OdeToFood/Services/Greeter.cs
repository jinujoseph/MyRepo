using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace OdeToFood.Services
{
    public interface IGreeter
    {
        string GetGreeting();
    }
    public class Greeter : IGreeter
    {
        private string _greetings;

        public Greeter(IConfiguration configuration)
        {
            _greetings = configuration["greetingMsg"];
        }
        public string GetGreeting()
        {
            return _greetings;
        }
    }
}
