using FreshMvvm;
using OrlandoDemoApp.PageModels;
using OrlandoDemoApp.Pages;
using OrlandoDemoApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace OrlandoDemoApp
{
    public class App : Application
    {
        public App()
        {
            FreshIOC.Container.Register<ITextService, TextService>();
            // The root page of your application
            var firstPage= FreshMvvm.FreshPageModelResolver.ResolvePageModel<FirstPageModel>();
            var navConatiner = new  FreshMvvm.FreshNavigationContainer(firstPage);
            MainPage = navConatiner;
            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
