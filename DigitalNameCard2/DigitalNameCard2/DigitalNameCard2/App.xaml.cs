using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DigitalNameCard2
{
	public partial class App : Application
	{

        static Services.DataAccess dbUtils;
        public static Services.DataAccess DbUtils
        {
            get
            {
                if (dbUtils == null)
                {
                    dbUtils = new Services.DataAccess();
                }
                return dbUtils;
            }
        }
        public App ()
		{
			InitializeComponent();

			MainPage = new DigitalNameCard2.MainPage();
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
