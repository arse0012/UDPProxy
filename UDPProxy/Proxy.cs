using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using ModelLib;

namespace UDPProxy
{
    public class Proxy
    {
        public Proxy()
        {
            
        }
        public async void Start()
        {
            while (true)
            {
                UdpClient obj = new UdpClient(10100);
                
            }
        }
    }
}
