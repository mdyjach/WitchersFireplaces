namespace WitchersFireplaces
{
    public partial class MainForm : Form
    {
        List<Fireplace> fireplaces = new List<Fireplace>();

        public MainForm()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture;
            InitializeComponent();

            fireplaces.Add(new Fireplace());// dodany fejkowy element pod indeks 0 aby zachowac zgodna numeracje z indeksami na liscie
            fireplaces.Add(new Fireplace(button1, new int[] { 1, 2, 4 }, true));
            fireplaces.Add(new Fireplace(button2, new int[] { 2, 5, 7 }));
            fireplaces.Add(new Fireplace(button3, new int[] { 3, 1, 2 }));
            fireplaces.Add(new Fireplace(button4, new int[] { 4, 3, 6 }, true));
            fireplaces.Add(new Fireplace(button5, new int[] { 5, 1, 7 }, true));
            fireplaces.Add(new Fireplace(button6, new int[] { 6, 3, 5 }));
            fireplaces.Add(new Fireplace(button7, new int[] { 7, 3, 6 }));

            ;
        }

        private void CheckState()
        {
            if (fireplaces.All(x => x.IsActive))
            {
                buttonDoor.Enabled = true;
                buttonDoor.BackColor = Color.White;
                buttonDoor.ForeColor = Color.Black;
                buttonDoor.Text = Resource.Open;
            }
        }

        private void ChangeState(int index)
        {
            Fireplace fireplace = fireplaces[index];
            if (fireplace != null)
            {
                foreach (int i in fireplace.Influenced)
                {
                    fireplaces[i].ChangeState();
                }
                CheckState();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeState(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeState(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeState(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangeState(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangeState(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangeState(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChangeState(7);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        private void buttonDoor_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resource.RiddleSolved, Resource.Solved);
        }

        private void SetComponentsNames(System.Globalization.CultureInfo cultureInfo)
        {
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            fileToolStripMenuItem.Text = Resource.FileMenu;
            helpToolStripMenuItem.Text = Resource.HelpMenu;
            changeLanguageToolStripMenuItem.Text = Resource.ChangeLanguage;
            exitToolStripMenuItem.Text = Resource.Exit;
            aboutToolStripMenuItem.Text = Resource.About;
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetComponentsNames(new System.Globalization.CultureInfo("en-US"));
        }

        private void polishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetComponentsNames(new System.Globalization.CultureInfo("pl-PL"));
        }
    }
}