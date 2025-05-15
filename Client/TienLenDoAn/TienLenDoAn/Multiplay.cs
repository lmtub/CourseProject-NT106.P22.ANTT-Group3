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


namespace TienLenDoAn
{
    public partial class Multiplay : Form
    {
        private string User1ID = "111"; // ID của user nằm bên trái giao diện Form
        private string User2ID = "111"; // ID của user nằm bên trên giao diện Form
        private string User3ID = "111"; // ID của user nằm bên phải giao diện Form
        private string IPAdd; // gán IP lấy từ Form3 (Form Create Room and Join Room)
        private TcpClient client;
        private IPEndPoint serverIP; // địa chỉ IP của server
        private StreamReader sr;  // dùng để đọc
        private StreamWriter sw;  // dùng để viết 
        private Packet this_client_info;   // packet chứa thông tin của client 
        private List<Card> PlayedCard = new List<Card>();
        private bool roomOwner; // khi tạo phòng thì roomOwner = true, ngược lại = false
        private int remaintime = 100; // thời gian đếm ngược 
        private bool iswinner = false;  // khi thắng thì iswinner = true 
        private Player _Player = new Player(); // khởi tạo đối tương Player
        private bool PlayerOnTurn = false; // khi đến lượt thì PlayerOnTurn = true, ngược lại = false
        private List<Card> PreMoveCards = new List<Card>();
        public Multiplay(string Code, string RoomID, string Username, byte[] Avatar, string IP, bool RoomOwner)
        {
            roomOwner = RoomOwner;
            IPAdd = IP;
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            {
                if (Code == "1")
                {
                    textBox2.Text = "Room ID: " + RoomID; // trường hợp người dùng ấy Join Room 
                }
                this_client_info = new Packet();
                this_client_info.Code = Code;
                this_client_info.RoomID = RoomID;
                this_client_info.Username = Username;
                this_client_info.ArrayByte = Avatar;
                
            }

            if (!RoomOwner) bTxDeal.Visible = false; //Nếu không phải chủ phòng thì không có button Deal
            You.Text = Username;
            
        }
        private void button1_Click(object sender, EventArgs e) // Nút deal
        {
            if (User1.Text != "")
            {
                this_client_info.Code = "2";  // gán code = "2"

                _Player.PlayerCard.Clear(); // xóa các lá bài từ ván trước
                PreMoveCards.Clear();   //


                bTxDeal.Visible = false; // Nút deal   
                PlayerOnTurn = false;
            }
            else MessageBox.Show("The room currently has only one player. Dealing cards is not possible. Please wait for more players to join.",
                        "Notification",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            client = new TcpClient(); // tạo TCP client
            serverIP = new IPEndPoint(IPAddress.Parse(IPAdd), 9999);
            client.Connect(serverIP);
            NetworkStream ns = client.GetStream();
            sr = new StreamReader(ns);
            sw = new StreamWriter(ns);

            panelMess.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }
        private void tmrPlayer_Tick(object sender, EventArgs e) // hàm xử lý thời gian đến ngược
        {
           
        }
        private void Choseobj_Click(object sender, EventArgs e) // hàm thêm sự kiện click các lá bài
        {
            Card card = sender as Card;
            if (card.Choose)
            {
                this._Player.ChoseCard.Remove(card); // hủy chọn
            }
            else
            {
                this._Player.ChoseCard.Add(card); // chọn
            }
            if (this.PlayerOnTurn)
            {
                if (this._Player.DoCheck(this.PreMoveCards)) // kiểm tra xem bài có đánh đc không 
                {
                    this.cmdPlay.Enabled = true;
                }
                else
                {
                    this.cmdPlay.Enabled = false;
                }
            }
            if (this._Player.ChoseCard.Count != 0)  // kiểm tra có đang chọn bài không để ẩn hiện Unchose
            {
                this.cmdUnChose.Enabled = true;
            }
            else
            {
                this.cmdUnChose.Enabled = false;
            }
            card.Toggle(); // ảnh lá bài khi được chọn 
        }
        private void cmdSkip_Click(object sender, EventArgs e)
        {
            this.tmrPlayer.Stop();    // dừng đếm ngược thời gian
            this.lblStatus.Text = "Wait for your turn...";  // hiển thị lên label 
            this.pbrRemainTime.Visible = false;    // ẩn đồng hồ thời gian
            this.pbxClock.Visible = false;
            this.PreMoveCards.Clear();
            this.PlayerOnTurn = false;       //
            this.cmdPlay.Enabled = false;    // ẩncác button Play, Chose, Skip 
            this.cmdUnChose.Enabled = false;
            this.cmdSkip.Enabled = false;
            this_client_info.Code = "5";        }
        private void cmdPlay_Click(object sender, EventArgs e)
        {
            this.lblStatus.Text = "Wait for your turn...";    // hiển thị lên label 
            this.pbrRemainTime.Visible = false;                // ẩn đồng hồ thời gian
            this.pbxClock.Visible = false;
            this.PlayerOnTurn = false;                         // để enable button Play
            this.PreMoveCards.Clear();
            this.PreMoveCards.AddRange(this._Player.ChoseCard);
            for (int i = 0; i < this._Player.ChoseCard.Count; i++)
            {
                this._Player.PlayerCard.Remove(this._Player.ChoseCard[i]);
            }
            this._Player.ChoseCard.Clear();
            this.cmdPlay.Enabled = false;              //
            this.cmdUnChose.Enabled = false;
            this.cmdSkip.Enabled = false;
            this.pbxClock.Visible = false;
            if (this._Player.PlayerCard.Count == 0)
            {
                this_client_info.Code = "6";
            }
            else
            {
                this.tmrPlayer.Stop();
                this_client_info.Code = "4";
            }
        }
        private void anh1_Click(object sender, EventArgs e) // hàm xử lý khi click vào avatar (hiển thị textbox để gửi message)
        {
            if (panelMess.Visible)
            {
                panelMess.Visible = false;
            }
            else
            {
                panelMess.Visible = true;
            }
        }
        private void btnSend_Click(object sender, EventArgs e) // button Send message
        {
            if (!string.IsNullOrEmpty(richTextBoxMess.Text))
            {
                this_client_info.Code = "7";
                this_client_info.ArrayByte = Encoding.UTF8.GetBytes(richTextBoxMess.Text);

                richTextBoxMess.Text = string.Empty;
                panelMess.Visible = false;
            }
        }
        private void button1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e) // button Exit
        {
            if (bTxDeal.Visible == false)
            {
                this_client_info.Code = "10";
            }
            else
            {
                this_client_info.Code = "11";
            }
            client.Close();
            this.Close();
        }
        private void cmdUnChose_Click(object sender, EventArgs e)
        {
           
        }
        private void pbxClock_Click(object sender, EventArgs e)
        {

        }
        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
        private void pbrRemainTime_Click(object sender, EventArgs e)
        {

        }
        private void tmrDownRight_Tick(object sender, EventArgs e)
        {

        }
        private void pbxOpponent_Click(object sender, EventArgs e)
        {

        }
    }
}
