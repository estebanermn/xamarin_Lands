using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Lands.ViewModels
{
    public class MainViewModel
    {
        //ViewModel
        public LoginViewModel Login { get; set; }
        public LandsViewModel Lands { get; set; }

        //Constructor
        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }

        #region Singleton  
        private static MainViewModel instance;
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


