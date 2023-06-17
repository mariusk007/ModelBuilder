using Microsoft.Data.SqlClient;
using System.Text;

namespace ModelBuilder
{
    public partial class FrmMain : Form
    {
        public string? ConnectionString;

        public FrmMain()
        {
            InitializeComponent();

            if (!string.IsNullOrEmpty(ConnectionString)) return;

            var frm = new FrmConnect(this);
            frm.ShowDialog();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (ConnectionString != null)
            {
                var text = ReadDatabase(ConnectionString, txtTableName.Text);

                txtResults.Text = text;
            }

            MessageBox.Show(@"Done");
        }

        public string ReadDatabase(string connection, string tableName)
        {
            var sb = new StringBuilder();

            using SqlConnection sqlConn = new(connection);
            using SqlCommand sqlCommand = new()
            {
                Connection = sqlConn
            };

            const string commandText = @"SELECT 
                                          	COLUMN_NAME,
                                        	DATA_TYPE
                                        FROM
                                        	INFORMATION_SCHEMA.COLUMNS
                                        WHERE 
                                        	TABLE_NAME = '{0}'";

            sqlCommand.CommandText = string.Format(commandText, tableName);
            sqlConn.Open();

            var sr = sqlCommand.ExecuteReader();

            while (sr.Read())
            {
                var row = string.Empty;

                var dataType = !Convert.IsDBNull(sr["DATA_TYPE"]) ? sr["DATA_TYPE"].ToString() : string.Empty;
                var columnName = !Convert.IsDBNull(sr["COLUMN_NAME"]) ? sr["COLUMN_NAME"].ToString() : string.Empty;

                switch (dataType?.ToLower())
                {
                    case "int":
                        row = $"public {"int"} {columnName} {{ get; set; }}";
                        break;
                    case "datetime":
                        row = $"public {"DateTime"} {columnName} {{ get; set; }}";
                        break;
                    case "float":
                        row = $"public {"float"} {columnName} {{ get; set; }}";
                        break;
                    case "nvarchar":
                        row = $"public {"string"} {columnName} {{ get; set; }}";
                        break;
                    case "smallint":
                        row = $"public {"Int16"} {columnName} {{ get; set; }}";
                        break;
                    case "tinyint":
                        row = $"public {"byte"} {columnName} {{ get; set; }}";
                        break;
                    case "varbinary":
                        row = $"public {"byte[]"} {columnName} {{ get; set; }}";
                        break;
                    default:
                        row = $"public {"string"} {columnName} {{ get; set; }}";
                        break;
                }

                sb.AppendLine(row);
            }

            sqlConn.Close();

            return sb.ToString();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            var frm = new FrmConnect(this);
            frm.ShowDialog();
        }
    }
}