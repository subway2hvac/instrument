using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PCComm;
namespace PCComm
{
    public partial class frmMain : Form
    {
        CommunicationManager comm = new CommunicationManager();        
        string transType = string.Empty;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           LoadValues();
           SetDefaults();
           SetControlState();
            cmdClose.Visible = false;
        }

        private void cmdOpen_Click(object sender, EventArgs e)
        {
            comm.PortName = cboPort.Text;
            comm.Parity = cboParity.Text;
            comm.StopBits = cboStop.Text;
            comm.DataBits = cboData.Text;
            comm.BaudRate = cboBaud.Text;
            comm.DisplayWindow2 = richTextBox2;
            comm.DisplayWindow = rtbDisplay;
            
            comm.OpenPort();

            if (true == comm.isPortOpen)
            {
                cmdOpen.Enabled = false;
                cmdClose.Enabled = true;
                cmdSend.Enabled = true;
                txtSend.Enabled = true;
                cmdOpen.Visible = false;
                cmdClose.Visible = true;
                
            }
        }

        /// <summary>
        /// Method to initialize serial port
        /// values to standard defaults
        /// </summary>
        private void SetDefaults()
        {
            cboPort.SelectedIndex = 0;
            cboBaud.SelectedText = "9600";
            cboParity.SelectedIndex = 0;
            cboStop.SelectedIndex = 1;
            cboData.SelectedIndex = 1;
        }

        /// <summary>
        /// methos to load our serial
        /// port option values
        /// </summary>
        private void LoadValues()
        {
            comm.SetPortNameValues(cboPort);
            comm.SetParityValues(cboParity);
            comm.SetStopBitValues(cboStop);
        }

        /// <summary>
        /// method to set the state of controls
        /// when the form first loads
        /// </summary>
        private void SetControlState()
        {
          
            cmdSend.Enabled = false;
            cmdClose.Enabled = false;
        }

        private void cmdSend_Click(object sender, EventArgs e)
        {
            sendData();
        }

        private void sendData()
        {
            comm.WriteData(txtSend.Text.ToUpper());
            txtSend.SelectAll();
        }

      

        private void chkBoxEOL_CheckedChanged(object sender, EventArgs e)
        {
            comm.AutoEOL = chkBoxEOL.Checked;
        }

        private void txtSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x0D)
            {
                sendData();
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            comm.ClosePort();
            if (false == comm.isPortOpen)
            {
                cmdOpen.Enabled = true;
                cmdClose.Enabled = false;
                cmdSend.Enabled = false;
                txtSend.Enabled = false;
                cmdClose.Visible = false;
                cmdOpen.Visible = true;
            }
        }

    

        private void cboPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboBaud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
 
      

        private void label6_Click(object sender, EventArgs e)
        {
                
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rtbDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}