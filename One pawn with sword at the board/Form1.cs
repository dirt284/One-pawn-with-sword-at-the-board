namespace One_pawn_with_sword_at_the_board
{


    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ця кнопка нагадує вам, що треба відволіктися від життя і просто відпочити.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int events = rnd.Next(1, 101);
            if (events <= 25)
            {
                listBox1.Items.Add("Ви знайшли магазин мандрівника. Чому б не заглянути туди?");
                Form2 shopForm = new Form2();
                shopForm.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Щоб не різати вам очі я прибрав фон. Не переживайте, найближчим часом я зроблю і додам його!");
        }
    }
}
