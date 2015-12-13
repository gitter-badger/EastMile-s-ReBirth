using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EastMile_s_ReBirth
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void StartSrv_Click(object sender, EventArgs e)
        {
            try {
                Login.Server.Start(LoginIP, LoginPort, Console, UserList);
                LoginIP.Enabled = false;
                LoginPort.Enabled = false;
                StartSrv.Enabled = false;
                StopSrv.Enabled = true;
            }
            catch (Exception ex)
            {
                
            }
        }

        private void StopSrv_Click(object sender, EventArgs e)
        {
            try {
                Login.Server.Stop(Console);
                LoginIP.Enabled = true;
                LoginPort.Enabled = true;
                StartSrv.Enabled = true;
                StopSrv.Enabled = false;
            }
            catch (Exception ex)
            {

            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Console.Clear();
        }
    }
}
