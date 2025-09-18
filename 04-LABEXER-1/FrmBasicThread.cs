using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_LABEXER_1
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
        }
        private Thread ThreadA, ThreadB;

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before starting thread-");

            ThreadStart thread = new ThreadStart(new ThreadStart(MyThreadClass.Thread1));

            ThreadA = new Thread(thread);
            ThreadA.Name = "ThreadA";

            ThreadB = new Thread(thread);
            ThreadB.Name = "ThreadB";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            label1.Text = "-End of Thread-";
            Console.WriteLine("-End of Thread-");

        }

        }
    }

