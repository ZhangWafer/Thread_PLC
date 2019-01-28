using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AxACTMULTILib;
using ACTMULTILib;

namespace Thread_PLC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void openUsb_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        //这里就是通过响应消息，来处理界面的显示工作
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch (e.ProgressPercentage)
            {
                case 1:
                    label1.Text = e.UserState.ToString();
                    break;
                case 2:
                    label2.Text = e.UserState.ToString();
                    break;
            }
        }

        //这里是后台工作完成后的消息处理，可以在这里进行后续的处理工作。

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("运算终于完成了");
        }

        //这里，就是后台进程开始工作时，调用工作函数的地方。你可以把你现有的处理函数写在这儿。

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           axActEasyIF1.

        }
    }
}
