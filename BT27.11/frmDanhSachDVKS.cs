using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace BT27._11
{
    public partial class frmDanhSachDVKS : Form
    {
        public frmDanhSachDVKS()
        {
            InitializeComponent();
        }

        private void frmDanhSachDVKS_Load(object sender, EventArgs e)
        {
            this.LoadDichVu();
        }
        private void LoadDichVu()
        { 
            string connectionString = "server=.; database = QuanLyDichVuKhachSan; Integrated Security = true;";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID_LoaiDV, TenDV FROM DichVu";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            conn.Dispose();
            cbbLoaiDV.DataSource = dt;
            cbbLoaiDV.DisplayMember = "TenDV";
            cbbLoaiDV.ValueMember = "ID_LoaiDV";
            label.Text = dt.Rows.Count.ToString();
            lbl.Text = cbbLoaiDV.Text;
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            if (dt == null) return;
            string filterExpression = "Name like '%" + txtSearchByName.Text + "%'";
            string sortExpression = "Price DESC";
            DataViewRowState rowStateFilter = DataViewRowState.OriginalRows;
            DataView dataView = new DataView(dt, filterExpression, sortExpression, rowStateFilter);
            lvDanhSachDichVu.DataSource = dataView;
        }

        private void lvDanhSachDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
