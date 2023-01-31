using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bluetooth_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        #region Ble Connection

        private void StartScanner()
        {
            DevicesList.Items.Clear();

        }

        #endregion

        private void StartScanClick(object sender, EventArgs e)
        {
            StartScanner();
        }

        private void StopScanClick(object sender, EventArgs e)
        {

        }

        private void ConnectClick(object sender, EventArgs e)
        {

        }

        private void DisconnectClick(object sender, EventArgs e)
        {

        }

        private void DeviceListSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
