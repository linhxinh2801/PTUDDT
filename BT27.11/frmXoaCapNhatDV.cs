using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BT27._11
{
    public partial class frmXoaCapNhatDV : Form
    {
        private void frmXoaCapNhatDV_Load(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void InitValues()
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true;";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID, Name FROM Category";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            // mở kết nối
            conn.Open();

            // Lấy dữ liệu từ csdl đưa vào DataTable
            adapter.Fill(ds, "Category");

            // Hiển thị nhóm món ăn
            cbbLoaiDV.DataSource = ds.Tables["Category"];
            cbbLoaiDV.DisplayMember = "Name";
            cbbLoaiDV.ValueMember = "ID";

            // đóng kết nối và giải phóng bộ nhớ
            conn.Close();
            conn.Dispose();
        }
        private void ResetText()
        {
            cbbLoaiDV.ResetText();
            txtDonGia.ResetText();
            txtGhiChu.ResetText();
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=.; database RestaurantManagement; Integrated Security = true; ";
                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE ThemXoaSua_LoaiDV @id OUTPUT, @ten,0";

                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@hd", SqlDbType.Int);

                cmd.Parameters["@id"].Direction = ParameterDirection.Output;

                // Truyền giá trị vào thủ tục qua tham số
                cmd.Parameters["@id"].Value = txtMaDV.Text;
                cmd.Parameters["@ten"].Value = txtTenMatHang.Text;
                cmd.Parameters["@hd"].Value = cbbLoaiDV.SelectedValue;

                // mở kết nối
                conn.Open();
                int numRowAffected = cmd.ExecuteNonQuery();

                // Thông báo kết quả
                if (numRowAffected > 0)
                {
                    string foodID = cmd.Parameters["@id"].Value.ToString();

                    MessageBox.Show("Successfully adding new food, Food ID = " + foodID, "Message");

                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Adding food failed");
                }

                // đóng kết nối
                conn.Close();
                conn.Dispose();
            }

            // Bắt lỗi SQL và các lỗi khác
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "SQL Eccor");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }
        public void DisplayDichVuInfo(DataRowView rowView)
        {
            try
            {
                txtMaDV.Text = rowView["ID"].ToString();
                txtTenMatHang.Text = rowView["Name"].ToString();
                cbbLoaiDV.Text = rowView["Unit"].ToString();

                cbbLoaiDV.SelectedIndex = -1;

                // chọn nhóm món ăn tương ứng
                for (int index = 0; index < cbbLoaiDV.Items.Count; index++)
                {
                    DataRowView cat = cbbLoaiDV.Items[index] as DataRowView;
                    if (cat["ID"].ToString() == rowView["DichVuID"].ToString())
                    {
                        cbbLoaiDV.SelectedIndex = index;
                        break;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
                this.Close();
            }
        }
        //Nhấp đôi chuột vào nút btnCancel để xử lý việc thoát khỏi Form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Nhấp đôi chuột vào nút btnUpdateFood để xử lý hàm cập nhật thông tin món ăn
        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=.; database = Restaurant Management; Integrated Security = true;";
                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE UpdateFood @id, @name, @unit, @foodCategoryID, @price, @notes";

                // Thêm tham số vào đối tượng Command

                cmd.Parameters.Update("@id", SqlDbType.NVarChar, 100);
                cmd.Parameters.Update("@ten", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Update("@hd", SqlDbType.Int);

                cmd.Parameters["@id"].Direction = ParameterDirection.Output;

                // Truyền giá trị vào thủ tục qua tham số
                cmd.Parameters["@id"].Value = txtMaDV.Text;
                cmd.Parameters["@ten"].Value = txtTenMatHang.Text;
                cmd.Parameters["@hd"].Value = cbbLoaiDV.SelectedValue;

                //mở kết nối.
                conn.Open();

                int numRowAffected = cmd.ExecuteNonQuery();

                // Thông báo kết quả
                if (numRowAffected > 0)
                {
                    MessageBox.Show("Successfully updating food", "Message");

                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Updating food failed");
                }

                // đóng kết nối
                conn.Close();
            }
            //Truyền giá trị vào thủ tục qua tham số
            cmd.Parameters.Update("@id", SqlDbType.NVarChar, 100);
            cmd.Parameters.Update("@ten", SqlDbType.NVarChar, 1000);
            cmd.Parameters.Update("@hd", SqlDbType.Int);

            //mở kết nối.
            conn.Open();

            int numRowAffected = cmd.ExecuteNonQuery();

            // Thông báo kết quả
            if (numRowAffected > 0)
            {
                MessageBox.Show("Successfully updating food", "Message");

                this.ResetText();
            }
            else
            {
                MessageBox.Show("Updating food failed");
            }

            // đóng kết nối
            conn.Close();
        }
    }
}
        
