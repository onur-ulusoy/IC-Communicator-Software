﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Devices.Bluetooth.Advertisement;
using Windows.Foundation;

namespace Bluetooth_Interface
{
    public partial class Form1 : Form
    {
        private BluetoothLEAdvertisementWatcher watcher = null;
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

            watcher = new BluetoothLEAdvertisementWatcher();
            watcher.ScanningMode = BluetoothLEScanningMode.Active;
            watcher.Received += OnAdvertisementReceived;

            watcher.SignalStrengthFilter.OutOfRangeTimeout = TimeSpan.FromMilliseconds(1000);
            watcher.SignalStrengthFilter.SamplingInterval = TimeSpan.FromMilliseconds(500);

            watcher.Start();
        }

        string nameBuffer = "";
        string devName = "";
        string devID = "";
        private void OnAdvertisementReceived(BluetoothLEAdvertisementWatcher sender, BluetoothLEAdvertisementReceivedEventArgs args)
        {
            nameBuffer = args.Advertisement.LocalName;

            if (nameBuffer != string.Empty)
            {
                devName = nameBuffer;
                devID = args.BluetoothAddress.ToString();

                string[] devInfo = { devName, devID };
                ListViewItem device = new ListViewItem(devInfo);
                
                DevicesList.Items.Add(device);

            }
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
