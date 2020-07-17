﻿using System;
using TestProject.Data;
using TestProject.Model;
using TestProject.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestProject
{
    public partial class App : Application
    {
        static TokenDatabaseController tokenDatabase;
        static UserDatabaseController userDatabase;
        static RestService restService;
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
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

        public static UserDatabaseController UserDatabase
        {
            get
            {
                if (userDatabase ==null)
                {
                    userDatabase = new UserDatabaseController();
                }
                return userDatabase;
            }

        }

        public static TokenDatabaseController TokenDatabase
        {
            get
            {
                if (tokenDatabase == null)
                {
                    tokenDatabase = new TokenDatabaseController();
                }
                return tokenDatabase;
            }

        }

        public static RestService RestService
        {
            get
            {
                if(restService ==null)
                {
                    restService = new RestService();
                }
                return restService;
            }
        }
    }
}
