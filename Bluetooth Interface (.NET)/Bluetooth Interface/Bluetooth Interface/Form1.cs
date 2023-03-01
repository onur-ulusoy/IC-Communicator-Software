using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Sockets;
using InTheHand.Net.Sockets;
using InTheHand.Net.Bluetooth;
using InTheHand.Net;

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

        private void StartScanClick(object sender, EventArgs e)
        {
            StartScan.Enabled = false;
            ScanTimer.Enabled = true;

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

        private bool isScanning = false;

        private void ScanTimerTick(object sender, EventArgs e)
        {
            if (!isScanning)
            {
                isScanning = true;
                Task.Run(async () =>
                {
                    BluetoothClient bc = new BluetoothClient();
                    BluetoothDeviceInfo[] devices = bc.DiscoverDevices().ToArray();

                    Console.WriteLine("Found {0} devices.", devices.Length);

                    DevicesList.Items.Clear();
                    foreach (BluetoothDeviceInfo device in devices)
                    {
                        Console.WriteLine("Device Name: {0}", device.DeviceName);
                        Console.WriteLine("Address: {0}", device.DeviceAddress);
                        Console.WriteLine("Class of Device: {0}", device.ClassOfDevice);
                        Console.WriteLine("");

                        string[] devInfo = { device.DeviceName,
                                         device.DeviceAddress.ToString() };

                        ListViewItem deviceLVI = new ListViewItem(devInfo);
                       
                        DevicesList.Items.Add(deviceLVI);
                    }

                    isScanning = false;
                });
            }
        }

    }
}
