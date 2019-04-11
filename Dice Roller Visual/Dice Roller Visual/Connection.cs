using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Dice_Roller_Visual
{
    public partial class Connection : Component
    {
        public Connection()
        {
            InitializeComponent();
            Socket s = new Socket(AddressFamily.InterNetwork,SocketType.Dgram, ProtocolType.Udp);



        }

        public Connection(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
