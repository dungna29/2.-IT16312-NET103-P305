using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_1_0_TaoWinformBangCode
{
    class Form1 : Form//Kế thừa lớp cha Form
    {
        //Tạo control
        private Button btnClick;//1 Lớp đối tượng nút bấm
        private Label lblName;

        //Contructor
        public Form1()
        {
            //1. Cấu hình form này
            this.Size = new Size(900, 300);

            //2. Thêm Label vào form
            lblName = new Label();//Khởi tạo lớp đối tượng
            lblName.Width = 300;
            lblName.Text = "Chào các bạn lại phải học Dungna C#3";//Gán giá trị cho label
            lblName.Location = new Point(100, 100);//Set vị trí của label
            this.Controls.Add(lblName);

            //3. Thêm Button vào form
            btnClick = new Button();
            btnClick.Text = "Click vào đây";
            btnClick.Location = new Point(200, 200);
            this.Controls.Add(btnClick);
        }

        public static void Main(string[] arg)
        {
            Application.Run(new Form1());
        }

    }
}
