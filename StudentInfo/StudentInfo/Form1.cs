using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> List_NameSurname = new List<string>();
        List<string> List_StudentNo = new List<string>();
        List<string> List_Departement = new List<string>();
        int counter = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List_NameSurname.Add(txtName.Text);
            List_StudentNo.Add(txtNumber.Text);
            List_Departement.Add(txtDepartment.Text);
            counter++;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < counter; i++)
            {
                string deger = List_NameSurname[i] + " " + List_StudentNo[i] + " " + List_Departement[i];
                listBox1.Items.Add(deger);
                comboBox1.Items.Add(deger);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int sonuc = List_NameSurname.Where(ayse => ayse.Contains(txtSearch1.Text)).Count();
            MessageBox.Show(txtSearch1.Text + "The name you searched for is" + sonuc + " in list ");
        }
    }
}