namespace CISESPORT
{
    public partial class FormInfo : Form
    {
        private Player _newPlayer;
        public FormInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string lastname = tbLastName.Text;
            string studentID = tbID.Text;
            string email = tbEmail.Text;
            string phone = tbNumberPhone.Text;
            string displayname = tbNameInGame.Text;
            string major = tbMajor.Text;
            int iAge = 0;

            try
            {
                string age = tbAge.Text;
                iAge = Int32.Parse(age);
            }
            catch (FormatException ex)
            {
                // Do something if have some exception
                MessageBox.Show("คุณใส่ข้อมูลไม่ถูกต้อง");
                return;
            }

            _newPlayer = new Player(name, lastname, studentID, major, displayname, email, phone, iAge);
            this.DialogResult = DialogResult.OK;
        }
        public Player getPlayer() { return _newPlayer; }
    }
}