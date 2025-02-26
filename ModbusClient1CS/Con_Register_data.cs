using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModbusClientCS
{
    public class Con_Register_data
    {
        public int transaction_id { get; set; }
        public int function_code { get; set; }
        public int start_address { get; set; }
        public int register_num { get; set; }

        public string recipe_name {get; set; }
        public int chamber_temp { get; set; }
        public int chamber_press { get; set; }
        public int chamber_flow { get; set; }
        public int gas_O3 { get; set; }
        public int gas_N2 { get; set; }
        public int gas_ZrO2 { get; set; }
        public int gas_HfO2 { get; set; }
        public int gas_H2O2 { get; set; }
        public int gas_TMA { get; set; }

        public int wafer_size { get; set; }
        public int wafer_loading { get; set; }  // 0: single, 1: batch
        public int wafer_flat_area { get; set; }
        public int wafer_amount {  get; set; }
        public int rf_power {  get; set; }
        public int plasma_forward {  get; set; }
        public int plasma_reflected { get; set; }



        public Con_Register_data() { }

        public Con_Register_data(int rfpower, int plasmaforward, int plasmareflected) 
        {
            rf_power = rfpower;
            plasma_forward = plasmaforward;
            plasma_reflected = plasmareflected;
        }

        public Con_Register_data(int wafersize, int waferloading, int wflatarea, int waferamount)
        {
            wafer_size      = wafersize;
            wafer_loading   = waferloading;
            wafer_flat_area = wflatarea;
            wafer_amount = waferamount;
        }

        public Con_Register_data(string recipename, int ctemp, int cpress, int cflow, int gO3, int gN2, int gZrO2, int gHfO2,int gH2O2, int gTMA,int wsize, int wloading, int wfa,int wa)
        {
            recipe_name = recipename;
            chamber_temp = ctemp;
            chamber_press = cpress;
            chamber_flow = cflow;

            gas_O3 = gO3;
            gas_N2 = gN2;
            gas_ZrO2= gZrO2;
            gas_HfO2 = gHfO2;
            gas_H2O2 = gH2O2;
            gas_TMA = gTMA;


            wafer_size = wsize;
            wafer_loading = wloading;
            wafer_flat_area = wfa;
            wafer_amount = wa;
        }

        public Con_Register_data(int code_0, int code_1, int code_2, int code_3, int code_4, int code_5, int code_6, int code_7, int code_8)
        {
            chamber_temp = code_0;
            chamber_press = code_1;
            chamber_flow = code_2;

            gas_O3 = code_3;
            gas_N2 = code_4;
            gas_ZrO2 = code_5;
            gas_HfO2 = code_6;
            gas_H2O2 = code_7;
            gas_TMA = code_8;
        }

        public Con_Register_data(int code_0, int code_1, int code_2, int code_3, int code_4, int code_5, int code_6, int code_7, int code_8, int code_9, int code_10, int code_11,int code_12, int code_13, int code_14, int code_15)
        {
            chamber_temp = code_0;
            chamber_press = code_1;
            chamber_flow = code_2;

            gas_O3 = code_3;
            gas_N2 = code_4;
            gas_ZrO2 = code_5;
            gas_HfO2 = code_6;
            gas_H2O2 = code_7;
            gas_TMA = code_8;

            wafer_size = code_9;
            wafer_loading = code_10;
            wafer_flat_area = code_11;
            wafer_amount = code_12;

            rf_power = code_13;
            plasma_forward = code_14;
            plasma_reflected = code_15;
        }

        public Con_Register_data(int id, int functioncode, int startaddress, int registernum, int code_0, int code_1, int code_2, int code_3, int code_4, int code_5, int code_6, int code_7, int code_8, int code_9, int code_10, int code_11, int code_12)
        {
            transaction_id = id;
            function_code = functioncode;
            start_address = startaddress;
            register_num = registernum;

            chamber_temp = code_0;
            chamber_press = code_1;
            chamber_flow = code_2;

            gas_O3 = code_3;
            gas_N2 = code_4;
            gas_ZrO2 = code_5;
            gas_HfO2 = code_6;
            gas_H2O2 = code_7;
            gas_TMA = code_8;

            wafer_size = code_9;
            wafer_loading = code_10;
            wafer_flat_area = code_11;
            wafer_amount = code_12;

        }


    }
}
