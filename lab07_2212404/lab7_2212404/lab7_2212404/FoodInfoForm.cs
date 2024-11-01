﻿using System;
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

namespace lab7_2212404
{
    public partial class FoodInfoForm : Form
    {
        public FoodInfoForm()
        {
            InitializeComponent();
        }

        private void FoodInfoForm_Load(object sender, EventArgs e)
        {
            this.InitValues();
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
            cbbCatName.DataSource = ds.Tables["Category"];
            cbbCatName.DisplayMember = "Name";
            cbbCatName.ValueMember = "ID";

            // đóng kết nối và giải phóng bộ nhớ
            conn.Close();
            conn.Dispose();
        }
        //Bổ sung hàm sau để xóa dữ liệu trên các control của Form
        private void ResetText()
        {
            txtFoodID.ResetText();
            txtName.ResetText();
            txtNotes.ResetText();
            txtUnit.ResetText();
            cbbCatName.ResetText();
            nudPrice.ResetText();
        }
        //Nhấp đôi chuột vào nút btnAddFood để xử lý hàm thêm một món ăn mới
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=.; database RestaurantManagement; Integrated Security = true; ";
                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE InsertFood @id OUTPUT, @name, @unit, @foodCategoryID, @price, @notes";

                // Thêm tham số vào đối tượng Command
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@foodCategoryId", SqlDbType.Int);
                cmd.Parameters.Add("@price", SqlDbType.Int);
                cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

                cmd.Parameters["@id"].Direction = ParameterDirection.Output;

                // Truyền giá trị vào thủ tục qua tham số
                cmd.Parameters["@name"].Value = txtName.Text;
                cmd.Parameters["@unit"].Value = txtUnit.Text;
                cmd.Parameters["@foodCategoryId"].Value = cbbCatName.SelectedValue;
                cmd.Parameters["price"].Value = nudPrice.Value;
                cmd.Parameters["@notes"].Value = txtNotes.Text;

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
        // thêm hàm vào lớp FoodInfoForm
        public void DisplayFoodInfo(DataRowView rowView)
        {
            try
            {
                txtFoodID.Text = rowView["ID"].ToString();
                txtName.Text = rowView["Name"].ToString();
                txtUnit.Text = rowView["Unit"].ToString();
                txtNotes.Text = rowView["Notes"].ToString();
                nudPrice.Text = rowView["Price"].ToString();

                cbbCatName.SelectedIndex = -1;

                // chọn nhóm món ăn tương ứng
                for (int index = 0; index < cbbCatName.Items.Count; index++)
                {
                    DataRowView cat = cbbCatName.Items[index] as DataRowView;
                    if (cat["ID"].ToString() == rowView["FoodCategoryID"].ToString())
                    {
                        cbbCatName.SelectedIndex = index;
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
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@foodCategoryId", SqlDbType.Int);
                cmd.Parameters.Add("@price", SqlDbType.Int);
                cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

                //Truyền giá trị vào thủ tục qua tham số
                cmd.Parameters["@id"].Value = int.Parse(txtFoodID.Text);
                cmd.Parameters["@name"].Value = txtName.Text;
                cmd.Parameters["@unit"].Value = txtUnit.Text;
                cmd.Parameters["@foodCategoryId"].Value = cbbCatName.SelectedValue;
                cmd.Parameters["@price"].Value = nudPrice.Value;
                cmd.Parameters["@notes"].Value = txtNotes.Text;

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
    }
}

