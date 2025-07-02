namespace P2_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = textBox1.Text;
            string lastname = textBox2.Text;
            string gender = radioButton1.Checked ? radioButton1.Text : radioButton2.Checked ? radioButton2.Text :
                "not selected";

            string languages = "";
            if (checkBox1.Checked)
             languages += checkBox1.Text;
            if (checkBox2.Checked)
                languages += checkBox2.Text;
            if (checkBox3.Checked)
                languages += checkBox3.Text;
            string email = textBox3.Text;
            string address = richTextBox1.Text;
            string state = comboBox1.Text;
            string zip = textBox4.Text;
            string cardtype = comboBox2.Text;

            string message = $"firstname: {firstname}\n" + $"lastname: {lastname}\n" +
                $"gender : {gender}\n" + $"languages : {languages}\n" + $"email :{email} \n" +
                $"address : {address} \n" + $"state : {state} \n" + $"zip : {zip} \n" + 
                $"cardtype : {cardtype} \n";
            ;

            MessageBox.Show(message, "Form submission details" , MessageBoxButtons.OK, MessageBoxIcon.Information );

        }
    }
}
