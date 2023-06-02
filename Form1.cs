using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vjezba_10
{
    public partial class TechSpecs : Form
    {
        public TechSpecs()
        {
            InitializeComponent();
        }

        private void comboBoxKomponente_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();

            if (comboBoxKomponente.SelectedIndex == 0)
            {
                ManagementObjectSearcher infoProcesor = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
                foreach (ManagementObject info in infoProcesor.Get())
                {
                    foreach (PropertyData infoData in info.Properties)
                    {
                        if(infoData.Value != null) this.listBoxInfo.Items.Add(infoData.Name + ": " + infoData.Value);
                    }
                }
            }
            else if (comboBoxKomponente.SelectedIndex == 1)
            {
                ManagementObjectSearcher infoGraficka = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
                foreach (ManagementObject info in infoGraficka.Get())
                {
                    foreach (PropertyData infoData in info.Properties)
                    {
                        if (infoData.Value != null) this.listBoxInfo.Items.Add(infoData.Name + ": " + infoData.Value);
                    }
                }
            }
            else if (comboBoxKomponente.SelectedIndex == 2)
            {
                ManagementObjectSearcher infoRAM = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
                foreach (ManagementObject info in infoRAM.Get())
                {
                    foreach (PropertyData infoData in info.Properties)
                    {
                        if (infoData.Value != null) this.listBoxInfo.Items.Add(infoData.Name + ": " + infoData.Value);
                    }
                }
            }
            else if (comboBoxKomponente.SelectedIndex == 3)
            {
                ManagementObjectSearcher infoMemorija = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
                foreach (ManagementObject info in infoMemorija.Get())
                {
                    foreach (PropertyData infoData in info.Properties)
                    {
                        if (infoData.Value != null) this.listBoxInfo.Items.Add(infoData.Name + ": " + infoData.Value);
                    }
                }
            }
            else if (comboBoxKomponente.SelectedIndex == 4)
            {
                ManagementObjectSearcher infoMemorija = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter");
                foreach (ManagementObject info in infoMemorija.Get())
                {
                    foreach (PropertyData infoData in info.Properties)
                    {
                        if (infoData.Value != null) this.listBoxInfo.Items.Add(infoData.Name + ": " + infoData.Value);
                    }
                }
            }
        }
    }
}
