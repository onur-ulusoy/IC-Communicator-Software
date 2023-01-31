
namespace Bluetooth_Interface
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.DevicesList = new System.Windows.Forms.ListView();
            this.StartScan = new System.Windows.Forms.Button();
            this.StopScan = new System.Windows.Forms.Button();
            this.Disconnect = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DevicesList
            // 
            this.DevicesList.HideSelection = false;
            this.DevicesList.Location = new System.Drawing.Point(12, 77);
            this.DevicesList.Name = "DevicesList";
            this.DevicesList.Size = new System.Drawing.Size(485, 229);
            this.DevicesList.TabIndex = 0;
            this.DevicesList.UseCompatibleStateImageBehavior = false;
            this.DevicesList.View = System.Windows.Forms.View.Details;
            this.DevicesList.SelectedIndexChanged += new System.EventHandler(this.DeviceListSelectedIndexChanged);
            // 
            // StartScan
            // 
            this.StartScan.Location = new System.Drawing.Point(12, 22);
            this.StartScan.Name = "StartScan";
            this.StartScan.Size = new System.Drawing.Size(113, 35);
            this.StartScan.TabIndex = 1;
            this.StartScan.Text = "Scan";
            this.StartScan.UseVisualStyleBackColor = true;
            this.StartScan.Click += new System.EventHandler(this.StartScanClick);
            // 
            // StopScan
            // 
            this.StopScan.Location = new System.Drawing.Point(131, 22);
            this.StopScan.Name = "StopScan";
            this.StopScan.Size = new System.Drawing.Size(113, 35);
            this.StopScan.TabIndex = 2;
            this.StopScan.Text = "Stop Scanning";
            this.StopScan.UseVisualStyleBackColor = true;
            this.StopScan.Click += new System.EventHandler(this.StopScanClick);
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(384, 22);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(113, 35);
            this.Disconnect.TabIndex = 3;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.DisconnectClick);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(265, 22);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(113, 35);
            this.Connect.TabIndex = 4;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.ConnectClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 325);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.Disconnect);
            this.Controls.Add(this.StopScan);
            this.Controls.Add(this.StartScan);
            this.Controls.Add(this.DevicesList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView DevicesList;
        private System.Windows.Forms.Button StartScan;
        private System.Windows.Forms.Button StopScan;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Button Connect;
    }
}

