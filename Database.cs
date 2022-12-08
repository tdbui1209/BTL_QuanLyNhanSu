using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanyNhanSu
{
    class Database
    {
        public static void Execute(string strCommand, Dictionary<string, object> parameters)
        {
            //Bước 1: Tạo chuỗi kết nối
            string strConnection = @"Data Source=(localdb)\MSSqlLocalDb;Initial Catalog=BTL_QuanLyNhanSu;Integrated Security=True;";
            //string strConnection = @"server=.\SQLEXPRESS;database=QuanLyNhanSu;integrated security=true;";
            //Bước 2: Tạo ra kết nối dựa trên chuỗi và mở kết nối
            SqlConnection connection = new SqlConnection(strConnection);
            connection.Open();
            //Bước 3: Tạo ra câu lệnh dựa trên chuỗi lệnh và biến kết nối
            SqlCommand command = new SqlCommand(strCommand, connection);
            //Add tham số cho câu lệnh
            foreach (string key in parameters.Keys)
                command.Parameters.Add(new SqlParameter(key, parameters[key]));
            //Bước 4: Thực thi câu lệnh
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static DataTable Query(string strQuery, Dictionary<string, object> parameters)
        {
            //Thực hiện câu lệnh truy vấn trên
            //Bước 1: Tạo chuỗi kết nối
            string strConnection = @"Data Source=(localdb)\MSSqlLocalDb;Initial Catalog=BTL_QuanLyNhanSu;Integrated Security=True;";
            //Bước 2: Tạo ra kết nối dựa trên chuỗi và mở kết nối
            SqlConnection connection = new SqlConnection(strConnection);
            connection.Open();
            //Bước 3: Tạo ra câu lệnh dựa trên chuỗi lệnh và biến kết nối
            SqlCommand command = new SqlCommand(strQuery, connection);
            //Add tham số cho câu lệnh
            foreach (string key in parameters.Keys)
                command.Parameters.Add(new SqlParameter(key, parameters[key]));
            //Bước 4: Tạo ra bộ điền dữ liệu SQLDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            //Bước 5: Tạo ra đối tượng bảng dữ liệu và điền dữ liệu vào
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }
    }
}
