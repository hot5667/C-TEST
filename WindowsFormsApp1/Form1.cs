using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string strip = string.Empty;
        int intPort = 250001;
        bool boolSever = false;
        TcpListener listener;
        Thread mainth = null;

        public Form1()
        {
            InitializeComponent();
        }
    }
}
