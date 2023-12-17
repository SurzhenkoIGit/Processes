using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace AsyncMath
{
    public partial class Form1 : Form
    {
        object _lockGUI = new object();
        public Form1()
        {
            InitializeComponent();

            cmb_operator.Items.AddRange(new string[] { "+", "-", "*", "/" });
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            string str = txb_int1.Text + " " + cmb_operator.SelectedItem.ToString() + " " + txb_int2.Text;
            txb_int1.Text = (int.Parse(txb_int2.Text) + 1).ToString();
            txb_int2.Text = (int.Parse(txb_int1.Text) - 2).ToString();
            if (cmb_operator.SelectedIndex == (cmb_operator.Items.Count - 1))
                cmb_operator.SelectedIndex = 0;
            else
                cmb_operator.SelectedIndex = cmb_operator.SelectedIndex + 1;

            lock (_lockGUI)
            {
                int i = lb_CurTasks.Items.Add(str);
            }
            //var item = lb_CurTasks.Items[i];
                Process process = new Process();
                process.StartInfo.FileName = "MathOperations.exe";
                process.StartInfo.Arguments = str;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
                Task t = new Task(() =>
                {
                    process.Start();
                    string inParams = process.StartInfo.Arguments;
                    string strRes = process.StandardOutput.ReadLine();
                    string res = strRes;
                    
                    lock (_lockGUI)
                    {
                        lb_Results.Invoke((Action)(() => { lb_Results.Items.Add(res); }));
                        //Thread.Sleep(new Random(DateTime.Now.Millisecond).Next() % 10000 + 1000);
                        lb_CurTasks.Invoke((Action)(() => { lb_CurTasks.Items.Remove(str); }));
                    }
                    
                    process.WaitForExit();
                    process.Close();
                    process.Dispose();
                });
                t.Start();
        }
    }
}
