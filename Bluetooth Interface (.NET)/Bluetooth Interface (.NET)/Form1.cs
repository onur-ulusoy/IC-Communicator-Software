using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bluetooth_Interface__.NET_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        #region Ble Connection

        private void BLE_StartScanner()
        {
            
        }


        #endregion

        private void deviceList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stopScan_Click(object sender, EventArgs e)
        {

        }

        private void startScan_Click(object sender, EventArgs e)
        {

        }

        private void connect_Click(object sender, EventArgs e)
        {

        }

        private void disconnect_Click(object sender, EventArgs e)
        {

        }
    }
}
