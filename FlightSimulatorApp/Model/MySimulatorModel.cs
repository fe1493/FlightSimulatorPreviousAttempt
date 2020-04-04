﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlightSimulatorApp.Model
{
    public class MySimulatorModel : ISimulatorModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        MyTelnetClient telnetClient = new MyTelnetClient();
        volatile Boolean stop;
        public void connect(string ip, int port)
        {
            telnetClient.connect(ip, port);
            stop = false;
        }
        public void disconnect()
        {
            stop = true;
            telnetClient.disconnect();
        }
        public void start()
        {
            new Thread(delegate ()
            {
                while (!stop)
                {
                    // update the variables from the simluator
                    telnetClient.write("get /instrumentation/heading-indicator/indicated-heading-deg");
                    Indicated_heading_deg = telnetClient.read();
                    telnetClient.write("get /instrumentation/gps/indicated-vertical-speed");
                    Gps_indicated_vertical_speed = telnetClient.read();
                    telnetClient.write("get /instrumentation/gps/indicated-ground-speed-kt");
                    gps_indicated_ground_speed_kt = telnetClient.read();
                    telnetClient.write("get /instrumentation/airspeed-indicator/indicated-speed-kt");
                    Airspeed_indicator_indicated_speed_kt = telnetClient.read();
                    telnetClient.write("get /instrumentation/gps/indicated-altitude-ft");
                    Gps_indicated_altitude_ft = telnetClient.read();
                    telnetClient.write("get /instrumentation/attitude-indicator/internal-roll-deg");
                    Attitude_indicator_internal_roll_deg = telnetClient.read();
                    telnetClient.write("get /instrumentation/attitude-indicator/internal-pitch-deg");
                    Attitude_indicator_internal_pitch_deg = telnetClient.read();
                    telnetClient.write("get /instrumentation/altimeter/indicated-altitude-ft");
                    Altimeter_indicated_altitude_ft = telnetClient.read();
                    // read the data in 4HZ
                    Thread.Sleep(250);
                }
            }).Start();
        }

        public void NotifyPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
        // the property implementation
        // all the variables from the plane
        private string indicated_heading_deg;
        private string gps_indicated_vertical_speed;
        private string gps_indicated_ground_speed_kt;
        private string airspeed_indicator_indicated_speed_kt;
        private string gps_indicated_altitude_ft;
        private string attitude_indicator_internal_roll_deg;
        private string attitude_indicator_internal_pitch_deg;
        private string altimeter_indicated_altitude_ft;
        public string Indicated_heading_deg
        {
            get { return indicated_heading_deg; }
            set
            {
                indicated_heading_deg = value;
                NotifyPropertyChanged("Indicated_heading_deg");
            }
        }
        public string Gps_indicated_vertical_speed
        {
            get { return gps_indicated_vertical_speed; }
            set
            {
                gps_indicated_vertical_speed = value;
                NotifyPropertyChanged("Gps_indicated_vertical_speed");
            }
        }
        public string Gps_indicated_ground_speed_kt
        {
            get { return gps_indicated_ground_speed_kt; }
            set
            {
                gps_indicated_ground_speed_kt = value;
                NotifyPropertyChanged("Gps_indicated_ground_speed_kt");
            }
        }
        public string Airspeed_indicator_indicated_speed_kt
        {
            get { return airspeed_indicator_indicated_speed_kt; }
            set
            {
                airspeed_indicator_indicated_speed_kt = value;
                NotifyPropertyChanged("Airspeed_indicator_indicated_speed_kt");
            }
        }
        public string Gps_indicated_altitude_ft
        {
            get { return gps_indicated_altitude_ft; }
            set
            {
                gps_indicated_altitude_ft = value;
                NotifyPropertyChanged("Gps_indicated_altitude_ft");
            }
        }
        public string Attitude_indicator_internal_roll_deg
        {
            get { return attitude_indicator_internal_roll_deg; }
            set
            {
                attitude_indicator_internal_roll_deg = value;
                NotifyPropertyChanged("Attitude_indicator_internal_roll_deg");
            }
        }
        public string Attitude_indicator_internal_pitch_deg
        {
            get { return attitude_indicator_internal_pitch_deg; }
            set
            {
                attitude_indicator_internal_pitch_deg = value;
                NotifyPropertyChanged("Attitude_indicator_internal_pitch_deg");
            }
        }
        public string Altimeter_indicated_altitude_ft
        {
            get { return altimeter_indicated_altitude_ft; }
            set
            {
                altimeter_indicated_altitude_ft = value;
                NotifyPropertyChanged("Altimeter_indicated_altitude_ft");
            }
        }
        public void setThrottle(string s)
        {
            string toSend = "set" + "/controls/engines/current-engine/throttle" + s;
            telnetClient.write(toSend);
        }
        public void setRudder(string s)
        {
            string toSend = "set" + "/controls/flight/rudder" + s;
            telnetClient.write(toSend);
        }
        public void setElevator(string s)
        {
            string toSend = "set" + "/controls/flight/elevator" + s;
            telnetClient.write(toSend);
        }
        public void setAileron(string s)
        {
            string toSend = "set" + "/controls/flight/aileron" + s;
            telnetClient.write(toSend);
        }
    }
}
