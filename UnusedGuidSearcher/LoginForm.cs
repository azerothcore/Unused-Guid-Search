using System;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using UnusedGuidSearcher.Properties;

namespace UnusedGuidSearcher
{
    public partial class LoginForm : Form
    {
        private string _username;
        private string _password;
        private string _database;
        private string _port;
        private string _host;
        private string _pipe;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void IsPipeCheckboxChecked()
        {
            if (IsUsingNamedPipeCheckbox.Checked == true)
            {
                PortBox.Enabled = false;
                PipeBox.Enabled = true;
                PortBox.Text = string.Empty; // clear the string
                PortBox.Text = "-1"; // sets port to -1 for a named pipe
            }

            if (IsUsingNamedPipeCheckbox.Checked == false)
            {
                PortBox.Enabled = true;
                PipeBox.Enabled = false;
                PortBox.Text = string.Empty; //clear the string
                PortBox.Text = Settings.Default.Port; // saved setting

                // this sets the default port again if someone used a named pipe and didn't have a value before that in the portbox box.
                if (PortBox.Text == "-1")
                    PortBox.Text = "3306";
            }
        }

        private void LoginFormLoad(object sender, EventArgs e)
        {
            UserBox.Text = Settings.Default.User;
            PasswordBox.Text = Settings.Default.Password;
            DBBox.Text = Settings.Default.DB;
            HostBox.Text = Settings.Default.Host;
            PipeBox.Text = Settings.Default.Pipe;
            PortBox.Text = Settings.Default.Port;

            // sets the checkbox for a piped connection if the user has it saved in the settings
            IsPipeCheckboxChecked();
        }

        private void SaveSettings()
        {
            _username = UserBox.Text;
            _password = PasswordBox.Text;
            _port = PortBox.Text;
            _database = DBBox.Text;
            _host = HostBox.Text;
            _pipe = PipeBox.Text;

            Settings.Default.User = _username;
            Settings.Default.Password = _password;
            Settings.Default.DB = _database;
            Settings.Default.Host = _host;
            Settings.Default.Pipe = _pipe;
            Settings.Default.Port = _port;
            Settings.Default.Save();
        }

        private String _connectionString
        {
            get
            {
                if (PortBox.Text == "-1")
                    //Server=localhost;Pipe={0};UserID={1};Password={2};Database={3};CharacterSet=utf8;ConnectionTimeout=5;ConnectionProtocol=Pipe;
                    return String.Format("SERVER={0};PIPE={1};UID={2};PASSWORD={3};DATABASE={4};ConnectionProtocol=Pipe;", _host, _pipe, _username, _password, _database);

                return String.Format("SERVER={0};PORT={1};DATABASE={2};UID={3};PASSWORD={4};", _host, _port, _database, _username, _password);
            }
        }

        private void StartMainForm()
        {
            Application.Run(new MainForm(_connectionString));
        }

        private bool TestConnection()
        {
            MySqlConnection connection = null;
            var result = true;

            try
            {
                connection = new MySqlConnection(_connectionString);
                connection.Open();
            }
            catch (MySqlException ex)
            {
                // ReSharper disable LocalizableElement
                MessageBox.Show(ex.Message, "Could not connect.", MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                // ReSharper restore LocalizableElement
                result = false;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }

            return result;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            IsPipeCheckboxChecked();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            SaveSettings();

            if (!TestConnection())
                return;

            Close();
            new Thread(StartMainForm).Start();
        }
    }
}
