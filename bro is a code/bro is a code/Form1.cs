using System.Xml.Serialization;

namespace bro_is_a_code
{

    public partial class Form1 : Form
    {
        Random random = new Random();
        int[,] Rooms = new int[8, 8];
        Button[,] buttons = new Button[8, 8];
        Button b;
        bool iswinroom = false;

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
                            effect(0);
                        }
                        else if (newrRandom >= 9 && newrRandom <= 16)
                        {
                            b.Tag = new Room("Fire", i, j);
                            effect(1);
                        }
                        else if (newrRandom >= 17 && newrRandom <= 24)
                        {
                            b.Tag = new Room("Spike", i, j);
                            effect(2);
                        }
                        else if (newrRandom >= 25 && newrRandom <= 32)
                        {
                            b.Tag = new Room("Empty", i, j);
                        }
                        else if (newrRandom >= 36 && newrRandom <= 44)
                        {
                            b.Tag = new Room("Health", i, j);
                            effect(3);
                        }
                        else if (newrRandom >= 45 && newrRandom <= 60)
                        {
                            b.Tag = new Room("Empty", i, j);
                        }
                        else if (newrRandom >= 61 && newrRandom <= 64)
                        {
                            b.Tag = new Room("Map", i, j);
                            effect(4);
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
        int turn = 0;
        int health = 100;
        //function that checks what button is pressed, and what room type it is
        void clickButton(object sender, EventArgs e)
        { 
            Button b = sender as Button;
            Room r = b.Tag as Room;
            if (r.roomInfo == "Poison")
            {
                label3.Text = "Poison";
            }
            else if (r.roomInfo == "Fire")
            {
                label3.Text = "Fire";
            }
            else if (r.roomInfo == "Spike")
            {
                label3.Text = "Spike";
            }
            else if (r.roomInfo == "Shield")
            {
                label3.Text = "Shield";
            }
            else if (r.roomInfo == "Health")
            {
                label3.Text = "Health";
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
            }
            else if (r.roomInfo == "Airfryer")
            {
                label3.Text = "Airfryer";
            }
            else if (r.roomInfo == "Map")
            {
                label3.Text = "Map";
            }
            turn++;
            label2.Text = "Turn: " + turn;
        }

        void effect(int b)
        {
            if (b == 0)
            {
                while (turn < turn + 6)
                {
                    health = health - 5;
                    healthBar.Value = health;
                }
            }
            else if (b == 1)
            {
                while (turn < turn + 2)
                {
                    health = health - 15;
                    healthBar.Value = health;
                }
            }
            else if (b == 2)
            {
                health = health - 25;
            }
            else if (b == 3)
            {
                health = health + 50;
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