using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Top3SachMuon
{
    public partial class Form1 : Form
    {
        Provider pr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            pr = new Provider();
            string querry = "select* from Book where MASA in(select top 3 masa from Borrow group by masa order by sum(SOLUONG) desc)";
            string querry1 = "select top 3 masa,sum(SOLUONG) soluong from Borrow group by masa order by sum(SOLUONG) desc";
            dataGridView1.DataSource = pr.ExecuteQuery(querry);
         
            dt= pr.ExecuteQuery(querry1);
            chartSach.ChartAreas["ChartArea1"].AxisX.Title = "Mã Sách";
            chartSach.ChartAreas["ChartArea1"].AxisY.Title = "Số Lượng Sách Được Mượn";
            chartSach.Series["Sách"]["DrawingStyle"] = "Cylinder";
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                chartSach.Series["Sách"].Points.AddXY(dt.Rows[i]["masa"], dt.Rows[i]["soluong"]);
                chartSach.Series["Sách"].Points[i].Label = dt.Rows[i]["soluong"].ToString();
            }
        }
    }
}
