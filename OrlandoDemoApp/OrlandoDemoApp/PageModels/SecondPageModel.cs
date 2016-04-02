using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrlandoDemoApp.PageModels
{
    class SecondPageModel : FreshMvvm.FreshBasePageModel
    {

        public string MainText
        {
            get
            {
                return "Hello from the second page";
            }
        }
    
    }
}
