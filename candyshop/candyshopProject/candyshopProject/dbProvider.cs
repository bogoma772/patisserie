using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;


/**
 * 
 */
public class dbProvider
{
    //private string nameDB; // поле для хранения имени БД(пока не ясно надо ли)


    public string ReadOneValueFromDB(string sqlQueryText) // чтение данных по запросу
    {
        return "";
    }

    public void WriteToDB(string sqlQueryText) // запись данных по запросу
    {

    }

    /**
                 * 
                 * 
                 */
    public void loadTable( DataGridView dataGridView, string tableName)
    {

        // реализация есть, надо вставить НАДО ПОПРАВИТЬ
        string Connect = "Database=candyshop;Data Source=192.168.56.1;User Id=root;Password=admin";
        //Переменная Connect - это строка подключения в которой:
        //БАЗА - Имя базы в MySQL
        //ХОСТ - Имя или IP-адрес сервера (если локально то можно и localhost)
        //ПОЛЬЗОВАТЕЛЬ - Имя пользователя MySQL
        //ПАРОЛЬ - говорит само за себя - пароль пользователя БД MySQL
        //Начало!!!!
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
            myConnection.Close(); //Обязательно закрываем соединение!



        }
    }


    public void mysqlQuery(DataGridView dataGridView, string sqltext)
    {

        // реализация есть, надо вставить НАДО ПОПРАВИТЬ
        string Connect = "Database=candyshop;Data Source=192.168.56.1;User Id=root;Password=admin";
        //Переменная Connect - это строка подключения в которой:
        //БАЗА - Имя базы в MySQL
        //ХОСТ - Имя или IP-адрес сервера (если локально то можно и localhost)
        //ПОЛЬЗОВАТЕЛЬ - Имя пользователя MySQL
        //ПАРОЛЬ - говорит само за себя - пароль пользователя БД MySQL
        //Начало!!!!
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
            myConnection.Close(); //Обязательно закрываем соединение!



        }
    }


    public dbProvider()
    { // конструктор, в нем соединение с БД
       
    }



    }
