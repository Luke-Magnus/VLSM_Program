namespace VLSM_Program
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_MajorAddress = new System.Windows.Forms.TextBox();
            this.btn_SetMajorNetwork = new System.Windows.Forms.Button();
            this.txt_VLANName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_VLANHosts = new System.Windows.Forms.TextBox();
            this.lbl_VLANName = new System.Windows.Forms.Label();
            this.lbl_SubnetMask = new System.Windows.Forms.Label();
            this.lbl_Netmask = new System.Windows.Forms.Label();
            this.lst_VLANName = new System.Windows.Forms.ListBox();
            this.lst_SubnetMask = new System.Windows.Forms.ListBox();
            this.lst_Netmask = new System.Windows.Forms.ListBox();
            this.lst_SubnetAddress = new System.Windows.Forms.ListBox();
            this.lbl_SubnetAddress = new System.Windows.Forms.Label();
            this.lst_BroadcastAddress = new System.Windows.Forms.ListBox();
            this.lbl_BroadcastAddress = new System.Windows.Forms.Label();
            this.btn_AddVLAN = new System.Windows.Forms.Button();
            this.lbl_MajorNetwork = new System.Windows.Forms.Label();
            this.lbl_MajorAddress = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_DeleteSelectedVLAN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_MajorAddress
            // 
            this.txt_MajorAddress.Location = new System.Drawing.Point(443, 7);
            this.txt_MajorAddress.Name = "txt_MajorAddress";
            this.txt_MajorAddress.Size = new System.Drawing.Size(93, 20);
            this.txt_MajorAddress.TabIndex = 0;
            this.txt_MajorAddress.Text = "0.0.0.0";
            // 
            // btn_SetMajorNetwork
            // 
            this.btn_SetMajorNetwork.Location = new System.Drawing.Point(334, 7);
            this.btn_SetMajorNetwork.Name = "btn_SetMajorNetwork";
            this.btn_SetMajorNetwork.Size = new System.Drawing.Size(103, 23);
            this.btn_SetMajorNetwork.TabIndex = 1;
            this.btn_SetMajorNetwork.Text = "Set Major Network";
            this.btn_SetMajorNetwork.UseVisualStyleBackColor = true;
            this.btn_SetMajorNetwork.Click += new System.EventHandler(this.SetMajorNetwork_Click);
            // 
            // txt_VLANName
            // 
            this.txt_VLANName.Location = new System.Drawing.Point(86, 7);
            this.txt_VLANName.Name = "txt_VLANName";
            this.txt_VLANName.Size = new System.Drawing.Size(100, 20);
            this.txt_VLANName.TabIndex = 2;
            this.txt_VLANName.Text = "Enter VLAN Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "VLAN Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hosts";
            // 
            // txt_VLANHosts
            // 
            this.txt_VLANHosts.Location = new System.Drawing.Point(86, 32);
            this.txt_VLANHosts.Name = "txt_VLANHosts";
            this.txt_VLANHosts.Size = new System.Drawing.Size(100, 20);
            this.txt_VLANHosts.TabIndex = 4;
            this.txt_VLANHosts.Text = "0";
            // 
            // lbl_VLANName
            // 
            this.lbl_VLANName.AutoSize = true;
            this.lbl_VLANName.Location = new System.Drawing.Point(6, 16);
            this.lbl_VLANName.Name = "lbl_VLANName";
            this.lbl_VLANName.Size = new System.Drawing.Size(66, 13);
            this.lbl_VLANName.TabIndex = 7;
            this.lbl_VLANName.Text = "VLAN Name";
            // 
            // lbl_SubnetMask
            // 
            this.lbl_SubnetMask.AutoSize = true;
            this.lbl_SubnetMask.Location = new System.Drawing.Point(160, 16);
            this.lbl_SubnetMask.Name = "lbl_SubnetMask";
            this.lbl_SubnetMask.Size = new System.Drawing.Size(70, 13);
            this.lbl_SubnetMask.TabIndex = 9;
            this.lbl_SubnetMask.Text = "Subnet Mask";
            // 
            // lbl_Netmask
            // 
            this.lbl_Netmask.AutoSize = true;
            this.lbl_Netmask.Location = new System.Drawing.Point(233, 16);
            this.lbl_Netmask.Name = "lbl_Netmask";
            this.lbl_Netmask.Size = new System.Drawing.Size(49, 13);
            this.lbl_Netmask.TabIndex = 11;
            this.lbl_Netmask.Text = "Netmask";
            // 
            // lst_VLANName
            // 
            this.lst_VLANName.FormattingEnabled = true;
            this.lst_VLANName.Location = new System.Drawing.Point(9, 32);
            this.lst_VLANName.Name = "lst_VLANName";
            this.lst_VLANName.Size = new System.Drawing.Size(148, 95);
            this.lst_VLANName.TabIndex = 12;
            this.lst_VLANName.SelectedIndexChanged += new System.EventHandler(this.UpdateSelectedIndex);
            // 
            // lst_SubnetMask
            // 
            this.lst_SubnetMask.FormattingEnabled = true;
            this.lst_SubnetMask.Location = new System.Drawing.Point(163, 32);
            this.lst_SubnetMask.Name = "lst_SubnetMask";
            this.lst_SubnetMask.Size = new System.Drawing.Size(66, 95);
            this.lst_SubnetMask.TabIndex = 13;
            // 
            // lst_Netmask
            // 
            this.lst_Netmask.FormattingEnabled = true;
            this.lst_Netmask.Location = new System.Drawing.Point(235, 32);
            this.lst_Netmask.Name = "lst_Netmask";
            this.lst_Netmask.Size = new System.Drawing.Size(92, 95);
            this.lst_Netmask.TabIndex = 14;
            // 
            // lst_SubnetAddress
            // 
            this.lst_SubnetAddress.FormattingEnabled = true;
            this.lst_SubnetAddress.Location = new System.Drawing.Point(333, 32);
            this.lst_SubnetAddress.Name = "lst_SubnetAddress";
            this.lst_SubnetAddress.Size = new System.Drawing.Size(92, 95);
            this.lst_SubnetAddress.TabIndex = 16;
            // 
            // lbl_SubnetAddress
            // 
            this.lbl_SubnetAddress.AutoSize = true;
            this.lbl_SubnetAddress.Location = new System.Drawing.Point(331, 16);
            this.lbl_SubnetAddress.Name = "lbl_SubnetAddress";
            this.lbl_SubnetAddress.Size = new System.Drawing.Size(82, 13);
            this.lbl_SubnetAddress.TabIndex = 15;
            this.lbl_SubnetAddress.Text = "Subnet Address";
            // 
            // lst_BroadcastAddress
            // 
            this.lst_BroadcastAddress.FormattingEnabled = true;
            this.lst_BroadcastAddress.Location = new System.Drawing.Point(431, 32);
            this.lst_BroadcastAddress.Name = "lst_BroadcastAddress";
            this.lst_BroadcastAddress.Size = new System.Drawing.Size(92, 95);
            this.lst_BroadcastAddress.TabIndex = 18;
            // 
            // lbl_BroadcastAddress
            // 
            this.lbl_BroadcastAddress.AutoSize = true;
            this.lbl_BroadcastAddress.Location = new System.Drawing.Point(429, 16);
            this.lbl_BroadcastAddress.Name = "lbl_BroadcastAddress";
            this.lbl_BroadcastAddress.Size = new System.Drawing.Size(96, 13);
            this.lbl_BroadcastAddress.TabIndex = 17;
            this.lbl_BroadcastAddress.Text = "Broadcast Address";
            // 
            // btn_AddVLAN
            // 
            this.btn_AddVLAN.Location = new System.Drawing.Point(192, 32);
            this.btn_AddVLAN.Name = "btn_AddVLAN";
            this.btn_AddVLAN.Size = new System.Drawing.Size(75, 23);
            this.btn_AddVLAN.TabIndex = 19;
            this.btn_AddVLAN.Text = "Add VLAN";
            this.btn_AddVLAN.UseVisualStyleBackColor = true;
            this.btn_AddVLAN.Click += new System.EventHandler(this.AddVLAN_Click);
            // 
            // lbl_MajorNetwork
            // 
            this.lbl_MajorNetwork.AutoSize = true;
            this.lbl_MajorNetwork.Location = new System.Drawing.Point(361, 33);
            this.lbl_MajorNetwork.Name = "lbl_MajorNetwork";
            this.lbl_MajorNetwork.Size = new System.Drawing.Size(79, 13);
            this.lbl_MajorNetwork.TabIndex = 20;
            this.lbl_MajorNetwork.Text = "Major Network:";
            // 
            // lbl_MajorAddress
            // 
            this.lbl_MajorAddress.AutoSize = true;
            this.lbl_MajorAddress.Location = new System.Drawing.Point(443, 34);
            this.lbl_MajorAddress.Name = "lbl_MajorAddress";
            this.lbl_MajorAddress.Size = new System.Drawing.Size(40, 13);
            this.lbl_MajorAddress.TabIndex = 21;
            this.lbl_MajorAddress.Text = "0.0.0.0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_VLANName);
            this.groupBox1.Controls.Add(this.lbl_SubnetMask);
            this.groupBox1.Controls.Add(this.lbl_Netmask);
            this.groupBox1.Controls.Add(this.lst_VLANName);
            this.groupBox1.Controls.Add(this.lst_BroadcastAddress);
            this.groupBox1.Controls.Add(this.lst_SubnetMask);
            this.groupBox1.Controls.Add(this.lbl_BroadcastAddress);
            this.groupBox1.Controls.Add(this.lst_Netmask);
            this.groupBox1.Controls.Add(this.lst_SubnetAddress);
            this.groupBox1.Controls.Add(this.lbl_SubnetAddress);
            this.groupBox1.Location = new System.Drawing.Point(17, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 134);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btn_DeleteSelectedVLAN
            // 
            this.btn_DeleteSelectedVLAN.Location = new System.Drawing.Point(26, 215);
            this.btn_DeleteSelectedVLAN.Name = "btn_DeleteSelectedVLAN";
            this.btn_DeleteSelectedVLAN.Size = new System.Drawing.Size(125, 23);
            this.btn_DeleteSelectedVLAN.TabIndex = 23;
            this.btn_DeleteSelectedVLAN.Text = "Delete Selected VLAN";
            this.btn_DeleteSelectedVLAN.UseVisualStyleBackColor = true;
            this.btn_DeleteSelectedVLAN.Click += new System.EventHandler(this.DeleteSelectedVLAN);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 260);
            this.Controls.Add(this.btn_DeleteSelectedVLAN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_MajorAddress);
            this.Controls.Add(this.lbl_MajorNetwork);
            this.Controls.Add(this.btn_AddVLAN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_VLANHosts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_VLANName);
            this.Controls.Add(this.btn_SetMajorNetwork);
            this.Controls.Add(this.txt_MajorAddress);
            this.Name = "Form1";
            this.Text = "Variable Length Subnet Mask Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MajorAddress;
        private System.Windows.Forms.Button btn_SetMajorNetwork;
        private System.Windows.Forms.TextBox txt_VLANName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_VLANHosts;
        private System.Windows.Forms.Label lbl_VLANName;
        private System.Windows.Forms.Label lbl_SubnetMask;
        private System.Windows.Forms.Label lbl_Netmask;
        private System.Windows.Forms.ListBox lst_VLANName;
        private System.Windows.Forms.ListBox lst_SubnetMask;
        private System.Windows.Forms.ListBox lst_Netmask;
        private System.Windows.Forms.ListBox lst_SubnetAddress;
        private System.Windows.Forms.Label lbl_SubnetAddress;
        private System.Windows.Forms.ListBox lst_BroadcastAddress;
        private System.Windows.Forms.Label lbl_BroadcastAddress;
        private System.Windows.Forms.Button btn_AddVLAN;
        private System.Windows.Forms.Label lbl_MajorNetwork;
        private System.Windows.Forms.Label lbl_MajorAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_DeleteSelectedVLAN;
    }
}

