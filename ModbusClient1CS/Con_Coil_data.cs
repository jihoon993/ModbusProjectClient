using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModbusClientCS
{
    internal class Con_Coil_data
    {
        public int transaction_id { get; set; }
        public int function_code { get; set; }
        public int start_address { get; set; }

        public bool valve_O3 { get; set; }
        public bool valve_N2 { get; set; }
        public bool valve_dry_pump { get; set; }
        public bool stop {  get; set; }



        public Con_Coil_data() { }

        public Con_Coil_data(bool valveO3, bool valveN2, bool valvedrypump, bool _stop)
        {
            valve_O3 = valveO3;
            valve_N2 = valveN2;
            valve_dry_pump = valvedrypump;
            stop = _stop;
        }

        public Con_Coil_data(int id, int functioncode, int startaddress, bool valveO3, bool valveN2, bool valvedrypump, bool _stop)
        {
            transaction_id = id;
            function_code = functioncode;
            start_address = startaddress;
            valve_O3 = valveO3;
            valve_N2 = valveN2;
            valve_dry_pump = valvedrypump;
            stop = _stop;

        }

    }
}
