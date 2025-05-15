using Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Newtonsoft.Json;
using System.Reflection;
using System.CodeDom.Compiler;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Runtime.CompilerServices;

namespace TienLenDoAn
{
    
    public partial class CreateOrJoin : Form
    {
        TcpClient client;
        IPEndPoint serverIP; // địa chỉ IP của server
        StreamReader sr;
        StreamWriter sw;
        Packet this_client_info = new Packet();
        
        public CreateOrJoin(string configPath)
        {
            InitializeComponent();
            
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        
        

         private void button1_Click(object sender, EventArgs e) // button Create New
        { 
            
        }

        private void button2_Click(object sender, EventArgs e) // button Join Room
        {
            

        }
        public bool IPv4IsValid(string ipv4) // hàm check IP
        {
            if (String.IsNullOrWhiteSpace(ipv4)) return false;

            string[] splitValues = ipv4.Split('.');
            if (splitValues.Length != 4) return false;

            byte posNum;
            return splitValues.All(i => byte.TryParse(i, out posNum));
        }
        private void button3_Click(object sender, EventArgs e) // button Start
        {
               
        }
        
        public static byte[] converterDemo(Image x) 
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }
        
        

        private void tbRoomID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbServerIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Application.OpenForms["Form1"].Close();
        }
    }
}
