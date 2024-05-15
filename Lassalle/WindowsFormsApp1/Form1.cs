using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.VariantTypes;
using QSACTIVEXLib;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool conn_flag = false; 
        //QSWrapperClass QSecs  = new QSWrapperClass();
        QSWrapper QSecs = new QSACTIVEXLib.QSWrapper();
        public Form1()
        {
            InitializeComponent();
            HSMS hsms = new HSMS();
            hsms.Active = true;
            hsms.Device = 0;
            hsms.IP = "127.0.0.1";
            hsms.Port = 5000;
            hsms.T3 = 45;
            hsms.T5 = 10;
            hsms.T6 = 5;
            hsms.T7 = 10;
            hsms.T8 = 5;
            propertyGrid1.SelectedObject = hsms;
        }
        public class HSMS
        {
            public bool Active { get; set; }
            public string IP {  get; set; }
            public int Port { get; set; }
            public int Device { get; set; }
            public int T3 { get; set; }
            public int T5 { get; set; }
            public int T6 { get; set; }
            public int T7 { get; set; }
            public int T8 { get; set; }
        }
        public class SECS1
        {
            public bool Host { get; set; }
            public bool FlowControl { get; set; }
            public int Device { get; set; }
            public int Port { get; set; }
            public int BaudRate { get; set; }
            public int T1 { get; set; }
            public int T2 { get; set; }
            public int T3 { get; set; }
            public int T4 { get; set; }
            public int Retry { get; set; }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            HSMS hsms = new HSMS();
            hsms.Active = true;
            hsms.Device = 0;
            hsms.IP = "127.0.0.1";
            hsms.Port = 5000;
            hsms.T3 = 45;
            hsms.T5 = 10;
            hsms.T6 = 5;
            hsms.T7 = 10;
            hsms.T8 = 5;
            propertyGrid1.SelectedObject = hsms;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SECS1 secs1 = new SECS1();
            secs1.Host = true;
            secs1.BaudRate = 9600;
            secs1.Device = 0;
            secs1.Port = 2;
            secs1.FlowControl = true;
            secs1.T1 = 1;
            secs1.T2 = 3;
            secs1.T3 = 10;
            secs1.T4 = 10;
            secs1.Retry = 3;
            propertyGrid1.SelectedObject = secs1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //QSecs.HSMS_Connect_Mode = QSACTIVEXLib.HSMS_COMM_MODE.HSMS_PASSIVE_MODE;
            //QSecs.lDeviceID = 0;
            //QSecs.lLinkTestPeriod = 60;
            //QSecs.lLogEnable = 1;
            //QSecs.lFlowControlEnable = 0;
            //QSecs.nLocalPort = 5000;
            //QSecs.nRemotePort = 5000;
            //QSecs.szLocalIP = "127.0.0.1";
            //QSecs.szRemoteIP = "127.0.0.1";
            //QSecs.T3 = 10;
            //QSecs.T5 = 5;
            //QSecs.T6 = 5;
            //QSecs.T7 = 5;
            //QSecs.T8 = 5;
            //QSecs.Initialize();
            //QSecs.Start();
            //int system = 0;
            //QSecs.SendSECSIIMessage(1,1 ,1, system, null);
            if (!conn_flag)
            {
                conn_flag = true;
                var obj = propertyGrid1.SelectedObject;
                if (radioButton1.Checked)
                {
                    HSMS hsms = obj as HSMS;
                    QSecs.lCOMM_Mode = QSACTIVEXLib.COMMMODE.HSMS_MODE;
                    QSecs.lDeviceID = hsms.Device;
                    QSecs.HSMS_Connect_Mode = hsms.Active == false ? HSMS_COMM_MODE.HSMS_PASSIVE_MODE : HSMS_COMM_MODE.HSMS_ACTIVE_MODE;
                    QSecs.szLocalIP = hsms.IP == string.Empty ? "127.0.0.1" : hsms.IP;
                    QSecs.szRemoteIP = hsms.IP == string.Empty ? "127.0.0.1" : hsms.IP;
                    QSecs.nLocalPort = hsms.Port;
                    QSecs.nRemotePort = hsms.Port;
                    QSecs.T3 = hsms.T3;
                    QSecs.T5 = hsms.T5;
                    QSecs.T6 = hsms.T6;
                    QSecs.T7 = hsms.T7;
                    QSecs.T8 = hsms.T8;
                    QSecs.Initialize();
                    QSecs.Start();
                }
                else if (radioButton2.Checked)
                {
                    SECS1 secs = obj as SECS1;
                    QSecs.lCOMM_Mode = QSACTIVEXLib.COMMMODE.HSMS_MODE;
                    QSecs.SECS_Connect_Mode = secs.Host==true ? SECS_COMM_MODE.SECS_HOST_MODE : SECS_COMM_MODE.SECS_EQUIP_MODE;
                    QSecs.lFlowControlEnable = secs.FlowControl==true ? 1 : 0;
                    QSecs.lCOMPort = secs.Port;
                    QSecs.RTY = secs.Retry;
                    QSecs.lDeviceID = secs.Device;
                    QSecs.T1 = secs.T1;
                    QSecs.T2 = secs.T2;
                    QSecs.T3 = secs.T3;
                    QSecs.T4 = secs.T4;
                    QSecs.lBaudRate = secs.BaudRate;
                    QSecs.Initialize();
                    QSecs.Start();
                }
                else
                {
                    MessageBox.Show("Please Check radioButton Checked.");
                }
            }
        }
        public void send_test()
        {
            object OutputRawData = new object();
            object te = new object();
            long temp = 1;
            string temp_s = "S";
            bool temp_b = true;
            int ret = 3;
            te = temp_s;
            QSecs.DataItemOut(OutputRawData, "EQ_ABC".Length, QSACTIVEXLib.SECSII_DATA_TYPE.ASCII_TYPE, "EQ_ABC");
            QSecs.DataItemOut(OutputRawData, "1.0001".Length, QSACTIVEXLib.SECSII_DATA_TYPE.ASCII_TYPE, "1.0001");
            QSecs.SendSECSIIMessage(6, 11, 1, ret, OutputRawData);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            send_test();
            //QSecs.Stop();
            //if (conn_flag)
            //{
            //    conn_flag = false;
            //}
        }
    }
}
