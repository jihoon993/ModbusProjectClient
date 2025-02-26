using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModbusClientCS
{
    public partial class Thread_Setting : Form
    {
        public Thread_Setting()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Load += Thread_Setting_Load;
        }

        private async void Thread_Setting_Load(object sender, EventArgs e)
        {
            await Task.Delay(8000);
            this.Close();
        }
    }
}
