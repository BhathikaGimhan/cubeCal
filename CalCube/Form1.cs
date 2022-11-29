namespace CalCube
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Proccess1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                ProccessName.Text="";
                for (int a = 0; a <= 10; a++)
                {
                    var Number = a;
                    var Squares = Math.Pow(a, 2);
                    var Cube = Math.Pow(a, 3);
                    dataGridView1.Rows.Add(Number, Squares, Cube);

                }
                ProccessName.Text = "Proccess 1";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Proccess2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                ProccessName.Text = "";

                for (int a = 0; a <= 10; a++)
                {
                    var Number = a;
                    var Squares =(Number * Number);
                    var Cube = (Number * Number * Number);
                    dataGridView1.Rows.Add(Number, Squares, Cube);
                }
                ProccessName.Text = "Proccess 2";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}