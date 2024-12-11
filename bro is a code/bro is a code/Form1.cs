
namespace bro_is_a_code
{

    public partial class Form1 : Form
    {
        Random random = new Random();
        int[,] Rooms = new int[8, 8];
        Button[,] buttons = new Button[8, 8];
        Button b;
        bool iswinroom = false;

        int turn = 0;
        bool lose = false;
        bool win = false;

        int health = 100;

        int counterPoison = 0;
        bool truePoison = false;

        int counterFire = 0;
        bool trueFire = false;

        bool logTrue = false;
        List<string> log = new List<string>();
        public Form1()
        {
            InitializeComponent();
            CreateButtons();

        }

        void CreateButtons()
        {
            //creates buttons, assigns them to class room, looping until there is definitely a win room
            while (iswinroom == false)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        b = new Button();
                        b.Size = new Size(background.Width, background.Height);
                        b.Location = new Point(j, i);
                        b.FlatStyle = FlatStyle.Popup;
                        b.BackColor = Color.Transparent;
                        b.Click += clickButton;
                        b.Text = "";
                        background.Controls.Add(b);
                        //generates random number to create different room types

                        int newrRandom = random.Next(0, 65);
                        Room room;
                        Color textcolor;
                        if (newrRandom == 0)
                        {
                            room = new Room("Airfryer", i, j);
                            textcolor = Color.Orange;
                        }
                        else if (newrRandom >= 9 && newrRandom <= 16)
                        {
                            room = new Room("Fire", i, j);
                            textcolor = Color.Red;
                        }
                        else if ((newrRandom >= 17 && newrRandom <= 24) || (newrRandom >= 45 && newrRandom <= 60))
                        {
                            room = new Room("Spike", i, j);
                            textcolor = Color.DarkGray;
                        }
                        else if (newrRandom >= 25 && newrRandom <= 32)
                        {
                            room = new Room("Empty", i, j);
                            textcolor = Color.White;
                        }
                        else if (newrRandom >= 36 && newrRandom <= 44)
                        {
                            room = new Room("Health", i, j);
                            textcolor = Color.Green;
                        }
                        else if (newrRandom >= 61 && newrRandom <= 64)
                        {
                            room = new Room("Map", i, j);
                            textcolor = Color.Yellow;
                        }
                        else if (iswinroom == false)
                        {
                            room = new Room("Win", i, j);
                            iswinroom = true;
                            textcolor = Color.Gold;
                        }
                        else
                        {
                            room = new Room("Poison", i, j);
                            textcolor = Color.DarkGreen;
                        }

                        b.Tag = room;
                        buttons[i, j] = b;
                        b.ForeColor = textcolor;

                    }

                }
            }
        }



        //function that checks what button is pressed, and what room type it is
        void clickButton(object sender, EventArgs e)
        {

            Button b = sender as Button;
            Room r = b.Tag as Room;
            b.Text = r.roomInfo;

            if (r.roomInfo == "Poison")
            {
                label3.Text = "Poison";
                effect(0, r);
            }
            else if (r.roomInfo == "Fire")
            {
                label3.Text = "Fire";
                effect(1, r);
            }
            else if (r.roomInfo == "Spike")
            {
                label3.Text = "Spike";
                effect(2, r);
            }
            else if (r.roomInfo == "Health")
            {
                label3.Text = "Health";
                effect(3, r);
            }
            else if (r.roomInfo == "Empty")
            {
                label3.Text = "Empty";
            }
            else if (r.roomInfo == "Map")
            {
                label3.Text = "Map";
                effect(4, r);
            }
            else if (r.roomInfo == "Win")
            {
                label3.Text = "Win";
                win = true;
                winBox.BringToFront();
                DisableButtons();
            }
            else if (r.roomInfo == "Map")
            {
                label3.Text = "Map";
            }
            else if (r.roomInfo == "Airfryer")
            {
                label3.Text = "Airfryer";
                airFryerBox.Image = Image.FromFile("airfryerowning.png");
            }
            turn++;
            label2.Text = "Turn: " + turn;
            Poison(truePoison);
            Fire(trueFire);
            r.roomInfo = "Empty";
            if (lose == true)
            {
                label3.Text = "You Lose!";
                DisableButtons();
                loseBox.BringToFront();
            }

        }

        //runs whatever procedure is needed to apply effect from room
        void effect(int b, Room r)
        {
            if (b == 0)
            {
                //poison
                truePoison = true;

            }
            else if (b == 1)
            {
                //fire
                trueFire = true;
            }
            else if (b == 2)
            {
                //spike
                health = health - 25;
                HealthBar();
            }
            else if (b == 3)
            {
                //heal
                if (health > 50)
                {
                    health = 100;
                }
                else
                {
                    health = health + 50;
                }
                HealthBar();
            }
            else if (b == 4)
            {
                Map(true);
            }
        }
        //poison procedure, does 30 damage over 6 turns
        void Poison(bool tf)
        {
            if (tf == true)
            {
                health = health - 5;
                HealthBar();
                counterPoison++;
                if (counterPoison == 6)
                {
                    truePoison = false;
                    counterPoison = 0;
                }
            }
        }
        //fire procedure, does 30 damage over 3 turns
        void Fire(bool tf)
        {

            if (tf == true)
            {
                health = health - 10;
                HealthBar();
                counterFire++;
                if (counterFire == 3)
                {
                    trueFire = false;
                    counterFire = 0;
                }
            }
        }
        //map procedure, displays what each room is
        void Map(bool tf)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button button = buttons[i, j];
                    Room room = button.Tag as Room;
                    button.Text = room.roomInfo;
                }
            }
        }
        //changes progress bar "healthBar" to whatever the current health is, also checks if health goes below 1 and if it does, turns the "lose" value to true
        void HealthBar()
        {
            healthBar.Maximum = 100;
            healthBar.Minimum = 0;
            if (health <= 0)
            {
                healthBar.Value = 0;
                lose = true;
            }
            else
            {
                healthBar.Value = health;
            }

        }

        //disables buttons, also writes if they won or lost to "Log.txt" and how many turns it took them
        void DisableButtons()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    buttons[i, j].Enabled = false;
                }
            }

            if (!File.Exists("Log.txt"))
            {
                FileStream f = File.Create("Log.txt");
                f.Close();
            }
            StreamWriter Log = new StreamWriter("Log.txt", true);
            if (lose == true)
            {
                Log.WriteLine("Lose on Turn: " + turn);
            }
            else
            {
                Log.WriteLine("Win on Turn: " + turn);
            }
            Log.Close();
        }
        private void B_Click(object? sender, EventArgs e)
        {
            clickButton(sender, e);
            throw new NotImplementedException();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void background_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void healthBar_Click(object sender, EventArgs e)
        {

        }

        //room class that stores the current x and y coords, plus the room type
        class Room
        {
            public string roomInfo;
            public int xCoord;
            public int yCoord;

            public Room(string roomInfo, int xCoord, int yCoord)
            {
                this.roomInfo = roomInfo;
                this.xCoord = xCoord;
                this.yCoord = yCoord;
            }
        }

        //displays log.txt info, by showing/hiding text box and appending each line in log.txt to it
        private void logButton_Click(object sender, EventArgs e)
        {
            if (logTrue == false)
            {
                logBox.Visible = true;
                logBox.BringToFront();
                logTrue = true;
                string[] y = File.ReadAllLines("Log.txt");
                
                logBox.Clear();

                foreach (string line in y)
                {
                    logBox.AppendText(line);
                    logBox.AppendText(Environment.NewLine);
                }

            }
            else
            {
                logBox.Visible = false;
                logTrue = false;
                logBox.Clear();

            }
        }

        //resets all variables, deletes old buttons and creates new ones
        void RestartGame()
        {
            health = 100;
            turn = 0;
            lose = false;
            win = false;
            trueFire = false;
            truePoison = false;
            counterFire = 0;
            counterPoison = 0;
            iswinroom = false;

            foreach (Button button in buttons)
            {
                if (button != null)
                {
                    background.Controls.Remove(button);
                }
            }

            buttons = new Button[8, 8];
            Rooms = new int[8, 8];
            CreateButtons();

            label2.Text = "Turn: " + turn;
            label3.Text = "";
            HealthBar();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}