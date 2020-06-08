using Lands.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lands.Infrastructure
{
    public class InstanceLocator
    {

        public MainViewModel Main { get; set; }

        //constructor
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }


    }
}
