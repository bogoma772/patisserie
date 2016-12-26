using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;


/**
 * 
 */
public class dbProvider
{
    //private string nameDB; // ���� ��� �������� ����� ��(���� �� ���� ���� ��)


    public string ReadOneValueFromDB(string sqlQueryText) // ������ ������ �� �������
    {
        return "";
    }

    public void WriteToDB(string sqlQueryText) // ������ ������ �� �������
    {

    }

    /**
                 * 
                 * 
                 */
    public void loadTable( DataGridView dataGridView, string tableName)
    {

        // ���������� ����, ���� �������� ���� ���������
        string Connect = "Database=candyshop;Data Source=192.168.56.1;User Id=root;Password=admin";
        //���������� Connect - ��� ������ ����������� � �������:
        //���� - ��� ���� � MySQL
        //���� - ��� ��� IP-����� ������� (���� �������� �� ����� � localhost)
        //������������ - ��� ������������ MySQL
        //������ - ������� ���� �� ���� - ������ ������������ �� MySQL
        //������!!!!
        BindingSource myBS = new BindingSource();
        using (MySqlConnection myConnection = new MySqlConnection(Connect))
        {
            myConnection.Open();
            // Start a local transaction 
            MySqlTransaction myTrans = myConnection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
            MySqlCommand myCommand = myConnection.CreateCommand();
            myCommand.CommandText = "select * from " + tableName;

            DataTable myDT = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();

            mySqlDataAdapter.SelectCommand = myCommand;


            mySqlDataAdapter.Fill(myDT);

            myBS.DataSource = myDT;

            
            dataGridView.DataSource = myBS;
            dataGridView.Visible = true;

            myCommand.Dispose();
            myTrans.Dispose();
            myConnection.Close(); //����������� ��������� ����������!



        }
    }


    public void mysqlQuery(DataGridView dataGridView, string sqltext)
    {

        // ���������� ����, ���� �������� ���� ���������
        string Connect = "Database=candyshop;Data Source=192.168.56.1;User Id=root;Password=admin";
        //���������� Connect - ��� ������ ����������� � �������:
        //���� - ��� ���� � MySQL
        //���� - ��� ��� IP-����� ������� (���� �������� �� ����� � localhost)
        //������������ - ��� ������������ MySQL
        //������ - ������� ���� �� ���� - ������ ������������ �� MySQL
        //������!!!!
        BindingSource myBS = new BindingSource();
        using (MySqlConnection myConnection = new MySqlConnection(Connect))
        {
            myConnection.Open();
            // Start a local transaction 
            MySqlTransaction myTrans = myConnection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
            MySqlCommand myCommand = myConnection.CreateCommand();
            myCommand.CommandText = sqltext;

            DataTable myDT = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();

            mySqlDataAdapter.SelectCommand = myCommand;


            mySqlDataAdapter.Fill(myDT);

            myBS.DataSource = myDT;


            dataGridView.DataSource = myBS;
            dataGridView.Visible = true;

            myCommand.Dispose();
            myTrans.Dispose();
            myConnection.Close(); //����������� ��������� ����������!



        }
    }


    public dbProvider()
    { // �����������, � ��� ���������� � ��
       
    }



    }
