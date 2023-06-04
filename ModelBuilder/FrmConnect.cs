using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelBuilder
{
    public partial class FrmConnect : Form
    {
        private readonly string _connectionString;

        private FrmMain parentForm;

        public FrmConnect(FrmMain pareForm)
        {
            parentForm = pareForm;


            InitializeComponent();



            _connectionString =
                $@"Server={txtServer.Text};Database={txtDatabase.Text};User ID={txtUserID.Text};Password={txtPassword.Text};Trusted_Connection=False;Encrypt=False;MultipleActiveResultSets=true;Connect Timeout=30;";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            parentForm.ConnectionString = _connectionString;
            Close();
        }
    }
}
