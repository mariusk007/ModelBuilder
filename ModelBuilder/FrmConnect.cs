namespace ModelBuilder
{
    public partial class FrmConnect : Form
    {
        private readonly string _connectionString;

        private readonly FrmMain _parentForm;

        public FrmConnect(FrmMain parentForm)
        {
            _parentForm = parentForm;

            InitializeComponent();

            _connectionString =
                $@"Server={txtServer.Text};Database={txtDatabase.Text};User ID={txtUserID.Text};Password={txtPassword.Text};Trusted_Connection=False;Encrypt=False;MultipleActiveResultSets=true;Connect Timeout=30;";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            _parentForm.ConnectionString = _connectionString;
            Close();
        }
    }
}