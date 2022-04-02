namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CMBOP.Items.Clear();
            CMBOP.Items.Add("Sumar");
            CMBOP.Items.Add("Restar");
            LISTADVANCE.Items.Clear();
            LISTADVANCE.Items.Add("Multiplicacion");
            LISTADVANCE.Items.Add("Division");
            CMBOP.Enabled = false;
            LISTADVANCE.Enabled = false;
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, RES;
            n1= Convert.ToDouble(txtn1.Text);
            n2= Convert.ToDouble(txtn2.Text);
            if (CMBOP.Enabled)
            {
                if (CMBOP.SelectedItem.ToString() == "Sumar")
                {
                    RES = n1 + n2;
                    MessageBox.Show(RES.ToString());
                }
                if (CMBOP.SelectedItem.ToString() == "Restar")
                {
                    RES = n1 - n2;
                    MessageBox.Show(RES.ToString());
                }
            }
            if (LISTADVANCE.Enabled)
            {
                if (LISTADVANCE.SelectedItem.ToString() == "Multiplicacion")
                {
                    RES = n1 * n2;
                    MessageBox.Show(RES.ToString());
                }
                if (LISTADVANCE.SelectedItem.ToString() == "Division")
                {
                    RES = (n1 / n2);
                    MessageBox.Show(RES.ToString());
                }
            }
        }

        private void RBTN1_CheckedChanged(object sender, EventArgs e)
        {
            if (RBTN1.Checked)
            {
                CMBOP.Enabled = true;
            }
            else
            {
                CMBOP.Enabled=false;
            }
        }

        private void RBTN2_CheckedChanged(object sender, EventArgs e)
        {
            if (RBTN2.Checked)
            {
                LISTADVANCE.Enabled = true;
            }
            else
            {
                LISTADVANCE.Enabled=false;
            }
        }
    }
}