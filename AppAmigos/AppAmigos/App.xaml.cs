namespace AppAmigos
{
    using AppAmigos.Data;
    using AppAmigos.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Xamarin.Forms;
    public partial class App : Application
	{
        private static FriendDatabase database;

        public static FriendDatabase Database
        {
            get
            {
                if(database==null)
                {
                    database = new FriendDataBase(DependencyService.Get<IFileHelper>().GetLocalFilePath("friendsdb.db3"));
                }
                return database;
            }
        }
        
        public App ()
		{
			InitializeComponent();

			MainPage = new AppAmigos.MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
