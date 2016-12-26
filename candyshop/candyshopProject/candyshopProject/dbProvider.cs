using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public class dbProvider
{
    private string Connect = "Database=candyshop;Data Source=192.168.56.1;User Id=root;Password=admin";
    public string ReadOneValueFromDB(string sqlQueryText) // чтение данных по запросу
    {
        return "";
    }

    public void WriteToDB(string sqlQueryText) // запись данных по запросу
    {

    }
    
    public void loadTable(DataGridView dataGridView, string tableName)
    {
        try
        {
            MySqlConnection myConnection = new MySqlConnection(Connect);
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter("SELECT id_product, name_product, code_category, expiration_date, cost_price, price, weight FROM products p;", myConnection);
            DataSet myDataSet = new DataSet();
            myDataAdapter.Fill(myDataSet, tableName);
            dataGridView.DataSource = myDataSet.Tables[0];
        }
        catch (System.Exception ex)
        {
            MessageBox.Show("Произошла ошибка загрузки");
        }
    }
    
    public void updateTable(DataGridView dataGridView, string tableName)
    {
        MySqlConnection myConnection = new MySqlConnection(Connect);
        MySqlDataAdapter myDataAdapter = new MySqlDataAdapter("SELECT id_product, name_product, code_category, expiration_date,cost_price,price,weight FROM products p; " , myConnection);
        DataSet myDataSet = new DataSet();
        myDataAdapter.Fill(myDataSet, tableName);
        //dataGridView.DataSource = myDataSet.Tables[0];
        try
        {
            MySqlCommandBuilder myCommandBuilder = new MySqlCommandBuilder(myDataAdapter);
            myDataAdapter.Update(myDataSet, tableName);
        }
        catch (System.Exception ex)        {
           MessageBox.Show("Произошла ошибка");
        }
        dataGridView.Update();
    }

    public void AddRecord(DataGridView dataGridView, string tableName)
    {
        MySqlConnection myConnection = new MySqlConnection(Connect);
        string query = "INSERT INTO products (id_product, name_product, code_category, expiration_date,cost_price,price,weight) VALUES (";
        query = query + dataGridView.Rows[dataGridView.RowCount - 2].Cells[0].Value + ",";
        query = query + '\u0022' + dataGridView.Rows[dataGridView.RowCount - 2].Cells[1].Value + '\u0022' + ",";
        query = query + dataGridView.Rows[dataGridView.RowCount - 2].Cells[2].Value + ",";
        query = query + dataGridView.Rows[dataGridView.RowCount - 2].Cells[3].Value + ",";
        query = query + dataGridView.Rows[dataGridView.RowCount - 2].Cells[4].Value + ",";
        query = query + dataGridView.Rows[dataGridView.RowCount - 2].Cells[5].Value + ",";
        query = query + dataGridView.Rows[dataGridView.RowCount - 2].Cells[6].Value + ");";
        MySqlDataAdapter myDataAdapter = new MySqlDataAdapter(query, myConnection);
        DataSet myDataSet = new DataSet();
        myDataAdapter.Fill(myDataSet, tableName);
        //dataGridView.DataSource = myDataSet.Tables[0]; 
        //try
        //{
        //    MySqlCommandBuilder myCommandBuilder = new MySqlCommandBuilder(myDataAdapter);
        //    myDataAdapter.Update(myDataSet, tableName);
        //}
        //catch (System.Exception ex)
        //{
        //    MessageBox.Show("Произошла ошибка");
        //}
        //dataGridView.Update(); 
    }
    
    public dbProvider()
    {
    }

    }
