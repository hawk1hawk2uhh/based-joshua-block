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
                        background.Controls.Add(b);
                        //generates random number to create different room types

                        int newrRandom = random.Next(0, 65);
                        if (newrRandom == 0)
                        {
                            b.Tag = new Room("Airfryer", i, j);
                        }
                        else if (newrRandom >= 1 && newrRandom <= 8)
                        {
                            b.Tag = new Room("Poison", i, j);
                        }
                        else if (newrRandom >= 9 && newrRandom <= 16)
                        {
                            b.Tag = new Room("Fire", i, j);
                        }
                        else if (newrRandom >= 17 && newrRandom <= 24)
                        {
                            b.Tag = new Room("Spike", i, j);
                        }
                        else if (newrRandom >= 25 && newrRandom <= 32)
                        {
                            b.Tag = new Room("Empty", i, j);
                        }
                        else if (newrRandom >= 36 && newrRandom <= 44)
                        {
                            b.Tag = new Room("Health", i, j);
                        }
                        else if (newrRandom >= 45 && newrRandom <= 60)
                        {
                            b.Tag = new Room("Empty", i, j);
                        }
                        else if (newrRandom >= 61 && newrRandom <= 64)
                        {
                            b.Tag = new Room("Map", i, j);
                        }
                        else
                        {
                            b.Tag = new Room("Win", i, j);
                            iswinroom = true;
                        }
                        buttons[i, j] = b;

                    }

                }
            }
        }
        
        

        //function that checks what button is pressed, and what room type it is
        void clickButton(object sender, EventArgs e)
        {
            Button b = sender as Button;
            Room r = b.Tag as Room;
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
            }
            else if (r.roomInfo == "Win")
            {
                label3.Text = "Win";
                win = true;
            }
            else if (r.roomInfo == "Map")
            {
                label3.Text = "Map";
            }
            turn++;
            label2.Text = "Turn: " + turn;
            Poison(truePoison);
            Fire(trueFire);
            r.roomInfo = "Empty";
            if (lose == true)
            {
                label3.Text = "You Lose!";
            }
            else if (win == true)
            {
                label3.Text = "You Win!";
            }
        }

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
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (r.xCoord == j && r.yCoord == j)
                        {
                            
                        }
                    }
                }
            }
        }
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
        void HealthBar()
        {
            healthBar.Maximum = 100;
            healthBar.Minimum = 0;
            if (health < 0)
            {
                healthBar.Value = 0;
                lose = true;
            }
            else
            {
                healthBar.Value = health;
            }

        }

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
    }
}