﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lands.ViewModels
{
    public class MainViewModel
    {
        #region ViewModels

        public LoginViewModel Login
        { get; set; }

        public LandsViewModel Lands
        { get; set; }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }
        #endregion

        #region Singleton

        public static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }

            return instance;
        }
        #endregion
    }
}
