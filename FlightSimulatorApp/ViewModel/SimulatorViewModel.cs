using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;  
using System.Collections.Generic;  
using System.ComponentModel;  
using System.Drawing;  
using System.Runtime.CompilerServices;  

namespace FlightSimulatorApp.ViewModel
{
    class SimulatorViewModel : INotifyPropertyChanged
    {
        string VM_Rudder;
        string VM_Elevator;
        string VM_Aileron;
        string VM_Throttle;
        string VM_IndicatedHeading;

        public event PropertyChangedEventHandler PropertyChanged;
        // Elevator "/controls/flight/elevator"
        // Aileron "/controls/flight/aileron"
        // Throttle "/controls/engines/engine/throttle"
        // indicated-heading-deg  "/instrumentation/heading-indicator/indicated-heading-deg" 
        // gps_indicated-vertical-speed "/instrumentation/gps/indicated-vertical-speed"
        // gps_indicated-ground-speed-kt "/instrumentation/gps/indicated-ground-speed-kt"
        // airspeed-indicator_indicated-speed-kt "/instrumentation/airspeed-indicator/indicated-speed-kt"
        // gps_indicated-altitude_ft "/instrumentation/gps/indicated-altitude-ft"
        // attitude-indicator_internal-roll-deg  "/instrumentation/attitude-indicator/internal-roll-deg"
        // attitude-indicator_internal-pitch-deg  "/instrumentation/attitude-indicator/internal-pitch-deg"
        // altimeter_indicated-altitude-ft  "/instrumentation/altimeter/indicated-altitude-ft"

    }
}
