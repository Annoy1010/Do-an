using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiaoDien.DAO;

namespace GiaoDien
{
    public partial class thongke : Form
    {
        public thongke()
        {
            InitializeComponent();
        }

        private void thongke_Load(object sender, EventArgs e)
        {
            /*chartSAM.Series["BDTK"].Points.AddXY("Tháng 1", 2);
            chartSAM.Series["BDTK"].Points.AddXY("Tháng 2", 3);
            chartSAM.Series["BDTK"].Points.AddXY("Tháng 3", 5);
            chartSAM.Series["BDTK"].Points.AddXY("Tháng 4", 1);*/
            DateTime date = new DateTime(2021,12,29);
        
            string query = string.Format("SELECT  YEAR(HANTRA) 'NAM',SUM(SOLUONG) 'SOLUONGS' FROM Borrow WHERE HANTRA < N'{0}' AND DATRA='False' GROUP BY  YEAR(HANTRA)", date);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            chartSAM.DataSource = data;
            chartSAM.ChartAreas["ChartArea1"].AxisX.Title = "Năm";
            chartSAM.ChartAreas["ChartArea1"].AxisY.Title = "Số sách";
            chartSAM.Series["BDTK"].XValueMember = "NAM" ;
            chartSAM.Series["BDTK"].YValueMembers = "SOLUONGS";
            
        }
    }
}
