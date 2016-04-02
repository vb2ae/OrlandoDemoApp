using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrlandoDemoApp.Services
{
    class TextService :ITextService
    {
        public string WelcomeText
        {
            get
            {
                return "Hello from Service";
            }
        }
    }
}
