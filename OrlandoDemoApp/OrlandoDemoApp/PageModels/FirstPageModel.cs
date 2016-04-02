using OrlandoDemoApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OrlandoDemoApp.PageModels
{
    class FirstPageModel : FreshMvvm.FreshBasePageModel
    {
        private ITextService textService;

        public FirstPageModel(ITextService service)
        {
            textService = service;
        }

        public string MainText
        {
            get
            {
                return textService.WelcomeText;
            }
        }

        public Command NavigateToSecondPage
        {
            get
            {
                return new Command(async () =>
                {
                    await CoreMethods.PushPageModel<SecondPageModel>();
                });
            }
        }
    }
}
