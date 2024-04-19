using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp1.Services
{
    public class MyService : IService
    {
        public string Write()
        {
            return "This method worked successfully";
        }
    }
}
