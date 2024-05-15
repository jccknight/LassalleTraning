using QSACTIVEXLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WindowsFormsApp1
{
    internal class QSECS
    {
        private QSWrapper comQSWrapper = new QSWrapper();

        public QSECS() {
            Init();
        }
        public void Init()
        {
            comQSWrapper.HSMS_Connect_Mode = QSACTIVEXLib.HSMS_COMM_MODE.HSMS_ACTIVE_MODE;
            comQSWrapper.lCOMM_Mode = QSACTIVEXLib.COMMMODE.HSMS_MODE;
            comQSWrapper.lDeviceID = 0;
            comQSWrapper.lLinkTestPeriod = 60;
            comQSWrapper.lLogEnable = 1;
            comQSWrapper.lFlowControlEnable = 0;
            comQSWrapper.nLocalPort = 5000;
            comQSWrapper.nRemotePort = 5000;
            comQSWrapper.szLocalIP = "127.0.0.1";
            comQSWrapper.szRemoteIP = "127.0.0.1";
            comQSWrapper.T3 = 10;
            comQSWrapper.T5 = 5;
            comQSWrapper.T6 = 5;
            comQSWrapper.T7 = 5;
            comQSWrapper.T8 = 5;
            comQSWrapper.Initialize();

            comQSWrapper.QSEvent += QSEventHandler;
        }

        public void QSEventHandler(int lID, EVENT_ID lMsgID, int S, int F, int W_Bit, int ulSystemBytes, object RawData, object Head, string pEventText)
        {
            int lOffset = 0;
            int lLength = 0;
            int pLen = 0;
            SECSII_DATA_TYPE lItemType;
            Object pData = new Object();
            
            if (lMsgID == EVENT_ID.QS_EVENT_RECV_MSG)
            {
                Console.WriteLine("S"+S+"F"+F);
                if (RawData is Array arr)
                {
                    lLength = arr.Length;
                    while (lOffset< lLength)
                    {
                        lItemType = comQSWrapper.GetDataItemType(RawData, lOffset);
                        switch (lItemType)
                        {
                            case SECSII_DATA_TYPE.LIST_TYPE:
                                lOffset = comQSWrapper.DataItemIn(RawData, lOffset, QSACTIVEXLib.SECSII_DATA_TYPE.LIST_TYPE, out pLen, pData);
                                Console.WriteLine("<L[" + pLen + "] >");
                                break;
                            case SECSII_DATA_TYPE.ASCII_TYPE:
                                lOffset = comQSWrapper.DataItemIn(RawData, lOffset, QSACTIVEXLib.SECSII_DATA_TYPE.ASCII_TYPE, out pLen, pData);
                                Console.WriteLine(pData.GetType());
                                if (pData is Array)
                                {
                                    Console.WriteLine("<A[" + pLen + "] " + pData + ">");
                                }
                                break;
                            default: break;
                        }
                    }
                }
            }
        }
        public void Connection()
        {
            comQSWrapper.Start();
        }
        public void Disconnection()
        {
            comQSWrapper.Stop();
        }

        public void sendS1F1()
        {
            int SystemBytes = 0;
            comQSWrapper.SendSECSIIMessage(1, 1, 1, ref SystemBytes, null);
        }
        public void sendS1F3()
        {
            int SystemBytes = 0;
            comQSWrapper.SendSECSIIMessage(1, 1, 1, ref SystemBytes, null);
            Object pRowData = new object();
            int ILen=0;
            comQSWrapper.DataItemOut(pRowData, 2, QSACTIVEXLib.SECSII_DATA_TYPE.ASCII_TYPE, "Hi");

            //comQSWrapper.SendSECSIIMessage(9, 99, 0, SystemBytes, pRowData);
        }
    }
}
