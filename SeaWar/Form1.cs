using SeaWar.Logic;

namespace SeaWar
{
    public partial class Form1 : Form
    {
        Field myField = new Field();
        int buttonSize = 100;
        int currentShipSize = 4;

        List<Ship.Coordinate> coordinates = new List<Ship.Coordinate>();

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            this.panelMyField.Size = new Size(10 * buttonSize, 10 * buttonSize);
            DrawField(myField);

            this.lblAddingShipInfo.Text = $"Adding ship of size {currentShipSize}";
        }

        public void DrawField(Field field)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button btn = new Button();
                    btn.FlatStyle = FlatStyle.Flat;

                    btn.Location = new Point(buttonSize * j, buttonSize * i);

                    btn.Size = new Size(buttonSize, buttonSize);
                    btn.Text = " ";

                    char letter = (char)(j + (int)'A');

                    btn.Tag = new Ship.Coordinate(letter, i + 1);

                    btn.Click += new EventHandler(btn_Click);
                    this.panelMyField.Controls.Add(btn);
                }
            }
        }

        private void btn_Click(object? sender, EventArgs e)
        {
            this.lblAddingShipInfo.Text = $"Adding ship of size {currentShipSize}";

            coordinates.Add((sender as Button)?.Tag as Ship.Coordinate);

            ((Button)sender).BackColor = Color.Red;

            if (coordinates.Count == currentShipSize)
            {
                switch (currentShipSize)
                {
                    case 4:
                        myField.AddShip4(coordinates.ToArray());
                        currentShipSize--;
                        break;

                    case 3:
                        myField.AddShip3(coordinates.ToArray());
                        if (this.myField.GetShipCount(currentShipSize) == 2)
                            currentShipSize--;
                        break;


                    case 2:
                        myField.AddShip2(coordinates.ToArray());
                        if (this.myField.GetShipCount(currentShipSize) == 3)
                            currentShipSize--;
                        break;


                    case 1:
                        myField.AddShip1(coordinates.ToArray());
                        if (this.myField.GetShipCount(currentShipSize) == 4)
                            currentShipSize--;
                        break;
                }

                coordinates.Clear();
            }

        }
    }
}