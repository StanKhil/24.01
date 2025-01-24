namespace _24._01
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<int> sec  = new List<int> {0, 0, 0, 0, 0};
        public Form1()
        {
            InitializeComponent();
        }

        private async void Start_Click(object sender, EventArgs e)
        {
            await Task.WhenAll(Horse1Move(), Horse2Move(), Horse3Move(), Horse4Move(), Horse5Move());
            Horse1.Value = Horse2.Value = Horse3.Value = Horse4.Value = Horse5.Value = 0;

            string raceResults = $"Horse1: {sec[0] / 10.0} sec\n" +
                                 $"Horse2: {sec[1] / 10.0} sec\n" +
                                 $"Horse3: {sec[2] / 10.0} sec\n" +
                                 $"Horse4: {sec[3] / 10.0} sec\n" +
                                 $"Horse5: {sec[4] / 10.0} sec";

            result.Text = raceResults;
            result.Visible = true;
        }

        private async Task Horse1Move()
        {
            while(Horse1.Value < Horse1.Maximum)
            {
                int speed = random.Next(1, 5);
                if (Horse1.Value + speed > Horse1.Maximum)
                {
                    Horse1.Value = Horse1.Maximum;
                    break;
                }
                Horse1.Value += speed;
                sec[0]++;
                await Task.Delay(100);
            }
        }
        private async Task Horse2Move()
        {
            while (Horse2.Value < Horse2.Maximum)
            {
                int speed = random.Next(1, 5);
                if (Horse2.Value + speed > Horse2.Maximum)
                {
                    Horse2.Value = Horse2.Maximum;
                    break;
                }
                Horse2.Value += speed;
                sec[1]++;
                await Task.Delay(100);
            }
        }
        private async Task Horse3Move()
        {
            while (Horse3.Value < Horse3.Maximum)
            {
                int speed = random.Next(1, 5);
                if (Horse3.Value + speed > Horse3.Maximum)
                {
                    Horse3.Value = Horse3.Maximum;
                    break;
                }
                Horse3.Value += speed;
                sec[2]++;
                await Task.Delay(100);
            }
        }
        private async Task Horse4Move()
        {
            while (Horse4.Value < Horse4.Maximum)
            {
                int speed = random.Next(1, 5);
                if (Horse4.Value + speed > Horse4.Maximum)
                {
                    Horse4.Value = Horse4.Maximum;
                    break;
                }
                Horse4.Value += speed;
                sec[3]++;
                await Task.Delay(100);
            }
        }
        private async Task Horse5Move()
        {
            while (Horse5.Value < Horse5.Maximum)
            {
                int speed = random.Next(1, 5);
                if (Horse5.Value + speed > Horse5.Maximum)
                {
                    Horse5.Value = Horse5.Maximum;
                    break;
                }
                Horse5.Value += speed;
                sec[4]++;
                await Task.Delay(100);
            }
        }
    }
}
