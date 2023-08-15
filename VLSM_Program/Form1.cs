using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VLSM_Program
{
    public partial class Form1 : Form
    {
        private List<VLAN> vlanList;
        private Address majorAddress;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void SetMajorNetwork_Click(object sender, EventArgs e)
        {
            SetMajorNetwork();
        }
        private void AddVLAN_Click(object sender, EventArgs e)
        {
            AddVLAN();
        }

        private void SetMajorNetwork()
        {
            string[] majorOctets = txt_MajorAddress.Text.Split('.');

            majorAddress = new Address(Int32.Parse(majorOctets[0]), Int32.Parse(majorOctets[1]), Int32.Parse(majorOctets[2]), Int32.Parse(majorOctets[3]));

            majorAddress.EvaluateAddress();

            lbl_MajorAddress.Text = majorAddress.GetString();
         
            UpdateDisplay();
        }

        private void AddVLAN()
        {
# region Check inputs
            //Name exists
            if (txt_VLANName.Text == string.Empty || txt_VLANName.Text == "Enter VLAN Name") 
            {
                //The VLAN name is either missing or is left as the default.
                MessageBox.Show("Please enter a VLAN name.");
                txt_VLANName.Text = "Enter VLAN Name";
                return;
            }

            //The name does not already exist.
            if(vlanList != null && vlanList.Count > 0)
            {
                foreach (VLAN item in vlanList)
                {
                    if(item.vlanName == txt_VLANName.Text)
                    {
                        MessageBox.Show("A VLAN with this name already exists.");
                        return;
                    }
                }
            }

            //mask is a number
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_VLANHosts.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txt_VLANHosts.Text = txt_VLANHosts.Text = string.Empty;
                return;
            }

            //TODO: host count is at least 4 and less than 65534 (2^2 to 2^16)
            if(Int32.Parse(txt_VLANHosts.Text) < 4 || Int32.Parse(txt_VLANHosts.Text) > 65534)
            {
                MessageBox.Show("Please enter a host range between 4 and 65534.");
                return;
            }
            #endregion

            UpdateVlanList();
            UpdateDisplay();
        }

        private void UpdateVlanList()
        {
            //Check vlanList exists, and create if needed
            if (vlanList == null)
                vlanList = new List<VLAN>();

            //add new vlan to list
            vlanList.Add(new VLAN(txt_VLANName.Text, Int32.Parse(txt_VLANHosts.Text)));

            //Sort list by host size
            vlanList = vlanList.OrderBy(o => o.hosts).Reverse().ToList();
        }

        private void UpdateDisplay()
        {
            if(vlanList == null)
                vlanList = new List<VLAN>();

            lst_VLANName.Items.Clear();
            foreach (VLAN vlan in vlanList)
                lst_VLANName.Items.Add(vlan.vlanName);

            lst_SubnetMask.Items.Clear();
            foreach (VLAN vlan in vlanList)
                lst_SubnetMask.Items.Add("/" + vlan.subnetMask);
            
            lst_Netmask.Items.Clear();
            foreach (VLAN vlan in vlanList)
                lst_Netmask.Items.Add(vlan.netmask.GetString());

            for (int i = 0; i < vlanList.Count; i++)
            {
                if (majorAddress == null)
                    SetMajorNetwork();

                if (i == 0)
                    vlanList[i].UpdateSubnetAddress(majorAddress);
                else
                    vlanList[i].UpdateSubnetAddress(vlanList[i - 1].broadcastAddress);
            }

            lst_SubnetAddress.Items.Clear();
            foreach (VLAN vlan in vlanList)
                lst_SubnetAddress.Items.Add(vlan.subnetAddress.GetString());

            lst_BroadcastAddress.Items.Clear();
            foreach (VLAN vlan in vlanList)
                lst_BroadcastAddress.Items.Add(vlan.broadcastAddress.GetString());
        }

        private void DeleteSelectedVLAN(object sender, EventArgs e)
        {
            vlanList.RemoveAt(lst_VLANName.SelectedIndex);
            vlanList = vlanList.OrderBy(o => o.hosts).ToList();

            UpdateDisplay();
        }

        private void UpdateSelectedIndex(object sender, EventArgs e)
        {
            ListBox origin = sender as ListBox;
            lst_VLANName.SelectedIndex = origin.SelectedIndex;
            lst_SubnetMask.SelectedIndex = origin.SelectedIndex;
            lst_Netmask.SelectedIndex = origin.SelectedIndex;
            lst_SubnetAddress.SelectedIndex = origin.SelectedIndex;
            lst_BroadcastAddress.SelectedIndex = origin.SelectedIndex;
        }
    }

    public class VLAN
    {
        public string vlanName;
        public int hosts;
        public int closestPowerOf2;
        public int amountToAdd;
        public int subnetMask;
        public Address netmask;
        public Address subnetAddress;
        public Address broadcastAddress;

        public VLAN(string _vlanName, int _hosts)
        {
            vlanName = _vlanName;
            hosts = _hosts;
            closestPowerOf2= GetPowerOf2(hosts + 2);
            subnetMask = 32 - closestPowerOf2;

            UpdateSubnetMask(amountToAdd);
        }

        public void UpdateSubnetMask(int valueToAdd)
        {
            netmask = new Address();

            netmask.fourthOctet += valueToAdd;

            netmask.EvaluateAddress();

            netmask.firstOctet = 255 - netmask.firstOctet;
            netmask.secondOctet = 255 - netmask.secondOctet;
            netmask.thirdOctet = 255 - netmask.thirdOctet;
            netmask.fourthOctet = 255 - netmask.fourthOctet;
        }

        //gets passed in the broadcastAddress of the previous vlan, or the major address if none exist.
        public void UpdateSubnetAddress(Address newAddress)
        {
            subnetAddress = new Address(newAddress.firstOctet, newAddress.secondOctet, newAddress.thirdOctet, newAddress.fourthOctet);
            subnetAddress.AddToAddress(1);

            UpdateBroadcastAddress(subnetAddress);
        }

        private void UpdateBroadcastAddress(Address newAddress)
        {
            broadcastAddress = new Address(newAddress.firstOctet, newAddress.secondOctet, newAddress.thirdOctet, newAddress.fourthOctet);
            broadcastAddress.AddToAddress(amountToAdd);
        }

        private int GetPowerOf2(int hosts)
        {
            int power = 0;
            amountToAdd = 0;

            while (amountToAdd < hosts)
            {
                power++;
                amountToAdd = (int)Math.Pow(2, power);
            }

            return power;
        }
    }

    public class Address
    {
        public int firstOctet;
        public int secondOctet;
        public int thirdOctet;
        public int fourthOctet;

        public Address(int _firstOctet = 0, int _secondOctet = 0, int _thirdOctet = 0, int _fourthOctet = 0)
        {
            firstOctet = _firstOctet;
            secondOctet = _secondOctet;
            thirdOctet = _thirdOctet;
            fourthOctet = _fourthOctet;
        }

        public void AddToAddress(int valueToAdd)
        {
            fourthOctet += valueToAdd;
            EvaluateAddress();
        }

        public void EvaluateAddress()
        {
            while (fourthOctet > 255)
            {
                fourthOctet -= 256;
                thirdOctet += 1;
            }

            while (thirdOctet > 255)
            {
                thirdOctet -= 256;
                secondOctet += 1;
            }

            while (secondOctet > 255)
            {
                secondOctet -= 256;
                firstOctet += 1;
            }
        }

        public string GetString()
        {
            return firstOctet.ToString() + "." + secondOctet.ToString() + "." + thirdOctet.ToString() + "." + fourthOctet.ToString();
        }
    }
}
