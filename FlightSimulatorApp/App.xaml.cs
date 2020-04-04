﻿using FlightSimulatorApp.Model;
using FlightSimulatorApp.ViewModel;
using FlightSimulatorApp.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FlightSimulatorApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public MainViewModel MainViewModel { get; internal set; }
        public void Application_Startup(object sender, StartupEventArgs e)
        {
            //initialize communication
            // TCPclient tcpclient = new...

            MySimulatorModel model = new MySimulatorModel();

            MainViewModel = new MainViewModel(model);

            // Create the startup window
            MainWindow wnd = new MainWindow();
            // Do stuff here, e.g. to the window
            wnd.Title = "FlightGear Simulator";
            // Show the window
            wnd.Show();
        }
    }
}
