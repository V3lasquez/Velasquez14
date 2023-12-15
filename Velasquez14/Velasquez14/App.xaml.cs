using System;
using Velasquez14.DataContext;
using Velasquez14.Interfaces;
using Velasquez14.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Velasquez14
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            GetContext().Database.EnsureCreated();
            MainPage = new CompraView();
        }
        public static AppDbContext GetContext()
        {
            string DbPath = DependencyService.Get<IConfigDataBase>().GetFullPath("efCore.db");

            return new AppDbContext(DbPath);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
