using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanyNhanSu.HeThong
{
    public partial class FormNhatKy : Form
    {
        public FormNhatKy()
        {
            InitializeComponent();
        }

        private void FormNhatKy_Load(object sender, EventArgs e)
        {
            string strQuery = "select * from dbo.ufLayNhatKy()";
            Dictionary<string, object> parameteres = new Dictionary<string, object>();
            // parameteres.Add("@nguoiSua", )
            dgv_NhatKy.DataSource = Database.Query(strQuery, parameteres);
        }
    }
}
