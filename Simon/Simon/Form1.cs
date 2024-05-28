namespace Simon
{
    public partial class Form1 : Form
    {
        private const int TimerInterval = 1000; 
        private const int NumberOfColors = 4; // Number of colors

        private List<int> computerColors = new List<int>();
        private List<int> playerColors = new List<int>();
        private Random random = new Random();
        private int level = 0;
        private Button[] colorButtons;
        private System.Windows.Forms.Timer timer;
        private int currentIndex;
        private Color[] colors = new Color[] { Color.Red, Color.Blue, Color.Green, Color.Yellow };
        private System.Windows.Forms.Timer offTimer; // New timer

        public Form1()
        {
            InitializeComponent();
            InitializeButtons();
            InitializeTimers();
        }

        private void InitializeButtons()
        {
            colorButtons = new Button[] { button1, button2, button3, button4 };
            for (int i = 0; i < colorButtons.Length; i++)
            {
                colorButtons[i].BackColor = colors[i]; // Set initial button color
                colorButtons[i].Click += colorButton_Click;
            }
        }

        private void InitializeTimers()
        {
            timer = new System.Windows.Forms.Timer { Interval = TimerInterval };
            timer.Tick += timer1_Tick;

            offTimer = new System.Windows.Forms.Timer { Interval = 500 }; // Set off timer interval to 0.5 seconds
            offTimer.Tick += timer2_Tick; // Connect Tick event to new method
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResetGame();
            NextLevel();
        }

        private void ResetGame()
        {
            level = 0;
            computerColors.Clear();
            playerColors.Clear();
        }

        private void NextLevel()
        {
            playerColors.Clear();
            computerColors.Add(random.Next(NumberOfColors));
            level++;
            currentIndex = 0;
            SetButtonState(false);
            timer.Start();
        }

        private void SetButtonState(bool isEnabled)
        {
            foreach (var button in colorButtons)
            {
                button.Enabled = isEnabled;
                button.BackColor = colors[Array.IndexOf(colorButtons, button)]; // Reset button color
            }
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int colorIndex = Array.IndexOf(colorButtons, button);
            playerColors.Add(colorIndex); // Assume buttons have a Tag indicating their color (1-4)

            if (playerColors[playerColors.Count - 1] != computerColors[playerColors.Count - 1])
            {
                // Player made a mistake, end game
                MessageBox.Show("You lost! You reached level " + level);
                button5_Click(this, EventArgs.Empty);
            }
            else if (playerColors.Count == computerColors.Count)
            {
                // Player completed the sequence correctly, move on to next level
                NextLevel();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // If there are still colors left in the sequence
            if (currentIndex < computerColors.Count)
            {
                var button = colorButtons[computerColors[currentIndex]];
                button.BackColor = Color.White; // Change button color to white
                offTimer.Start(); // Start off timer
            }
            else
            {
                timer.Stop();
                SetButtonState(true);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // Turn off current button
            if (currentIndex < computerColors.Count)
            {
                colorButtons[computerColors[currentIndex]].BackColor = colors[computerColors[currentIndex]]; // Reset button color
                currentIndex++;
                timer.Start(); // Start main timer again
            }
            offTimer.Stop();
        }
    }
}
