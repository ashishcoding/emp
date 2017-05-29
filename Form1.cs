using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;





namespace Employee_Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string _constr = "Data source=localhost;port=3306;username=linkjet;password=100200";
            MySqlConnection _con = new MySqlConnection(_constr);
            DataTable _table = new DataTable();
            MySqlDataAdapter _adp = new MySqlDataAdapter("select emp_id, emp_name, emp_salary, emp_post from employee.emp", _con);
            _adp.Fill(_table);
            dataGridView1.DataSource = _table;



        }
