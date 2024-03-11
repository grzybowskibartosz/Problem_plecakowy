using Problem_plecakowy;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = num_of_items.Text;
            string Capacity = capacity.Text;
            string Seed = seedTextBox.Text;

            int n_int, Capacity_int, Seed_int;

            if (!int.TryParse(n, out n_int) || !int.TryParse(Capacity, out Capacity_int)|| !int.TryParse(Seed, out Seed_int))
            {
                MessageBox.Show("Wprowadü poprawne wartoúci liczbowe.", "B≥πd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Problem problem = new Problem(n_int, Seed_int);

            Result result = problem.Solve(Capacity_int);

            result_box.Text = result.ToString();
            Instance_box.Text = problem.ToString();
        }

        private void instance_Click(object sender, EventArgs e)
        {

        }
    }
}
