using Microsoft.Data.SqlClient;
using System.Data;
namespace ADO_1
{
    public partial class Form1 : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=.\SQLSERVERD;Initial Catalog=c_sharp;Integrated Security=True;Trust Server Certificate=True;");
        SqlCommand command = new SqlCommand(); // select command
        SqlCommand insert = new SqlCommand();
        SqlCommand delete = new SqlCommand();
        SqlCommand update = new SqlCommand("update department set Dept_name = @name,Dept_Desc = @desc where Dept_Id = @id");




        SqlDataAdapter adabter = new SqlDataAdapter();

        DataSet ds = new DataSet();



        public Form1()
        {
            InitializeComponent();

            command.Connection = connection;
            command.CommandText = "select * from DEPARTMENT";

            insert.Connection = connection;
            insert.CommandText = "insert into DEPARTMENT(Dept_Id ,Dept_Name , Dept_Desc) VALUES(@id , @name , @desc)";
            SqlParameter _id = new SqlParameter("@id", SqlDbType.Int, 0, "Dept_Id");
            SqlParameter _name = new SqlParameter("@name", SqlDbType.VarChar, 0, "Dept_Name");
            SqlParameter _desc = new SqlParameter("@desc", SqlDbType.VarChar, 0, "Dept_Desc");
            SqlParameter[] parameters = new SqlParameter[] { _id, _name, _desc };
            insert.Parameters.AddRange(parameters);


            //important note -> the sqlparamtere object can only belong to one sqlcommand object

            delete.Connection = connection;
            delete.CommandText = "delete from DEPARTMENT where Dept_Id = @id";
            delete.Parameters.Add("@id", SqlDbType.Int, 0, "Dept_Id");



            update.Connection = connection;
            update.Parameters.Add("@id", SqlDbType.Int, 0, "Dept_Id");
            update.Parameters.Add("@name", SqlDbType.Int, 0, "Dept_Name");
            update.Parameters.Add("@desc", SqlDbType.Int, 0, "Dept_Desc");









        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adabter.SelectCommand = command;
            adabter.Fill(ds);
            ds.Tables[0].PrimaryKey = new[] { ds.Tables[0].Columns[0] };

            if (ShowData.Rows.Count != 0) // to make not overlap rows on each other
            {
                ds.Clear();
                adabter.Fill(ds);
            }

            ShowData.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adabter.InsertCommand = insert;

            DataRow new_row = ds.Tables[0].NewRow();
            new_row[0] = int.Parse(textBox1.Text);
            new_row[1] = textBox2.Text;
            new_row[2] = textBox3.Text;

            ds.Tables[0].Rows.Add(new_row);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            adabter.Update(ds);
            MessageBox.Show("Changes saved to Data Base!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adabter.DeleteCommand = delete;
            DataRow[] rows = ds.Tables[0].Select($"Dept_Id = {textBox1.Text}");
            rows[0].Delete();
            MessageBox.Show("deleted local!");
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            adabter.UpdateCommand = update;
            DataRow row = ds.Tables[0].Select($"Dept_Id = {textBox1.Text}")[0];
            row[1] = textBox2.Text;
            row[2] = textBox3.Text;
            MessageBox.Show("Updated Locally");
        }
    }
}
