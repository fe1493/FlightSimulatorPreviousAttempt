using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FlightSimulatorApp.Model
{
    interface ISimulatorModel : INotifyPropertyChanged
    {
        void connect(string ip, int port);
        void disconnect();
        void start();

        string Rudder { set; get; }
        string Elevator { set; get; }
        string Aileron { set; get; }
        string Throttle { set; get; }
        string Indicated_heading_deg { set; get; }
        string Gps_indicated_vertical_speed { set; get; }
        string Gps_indicated_ground_speed_kt { set; get; }
        string Airspeed_indicator_indicated_speed_kt { set; get; }
        string Gps_indicated_altitude_ft { set; get; }
        string Attitude_indicator_internal_roll_deg { set; get; }
        string Attitude_indicator_internal_pitch_deg { set; get; }
        string Altimeter_indicated_altitude_ft { set; get; }
        //  "/controls/flight/elevator"
        //  "/controls/flight/aileron"
        //  "/controls/engines/engine/throttle"
        //   "/instrumentation/heading-indicator/indicated-heading-deg" 
        //  "/instrumentation/gps/indicated-vertical-speed"
        //  "/instrumentation/gps/indicated-ground-speed-kt"
        //  "/instrumentation/airspeed-indicator/indicated-speed-kt"
        //  "/instrumentation/gps/indicated-altitude-ft"
        //   "/instrumentation/attitude-indicator/internal-roll-deg"
        //   "/instrumentation/attitude-indicator/internal-pitch-deg"
        //   "/instrumentation/altimeter/indicated-altitude-ft"
    }
}
