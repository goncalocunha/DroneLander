﻿using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DroneLander
{
	public partial class App : Application
	{

        public static MainViewModel ViewModel { get; set; }
        
        public App ()
		{
			InitializeComponent();//sadfvbf

            MainPage = new NavigationPage(new DroneLander.MainPage());
        }

        protected override void OnStart ()
		{
            // Handle when your app starts
            AppCenter.Start("android=0a0a6d67-69bd-4092-b59b-b88ae4ad5843;" + "uwp={Your UWP App secret here};" +
                   "ios={Your iOS App secret here}",
                   typeof(Analytics), typeof(Crashes));
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
