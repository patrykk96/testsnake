using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {

        private List<Circle> snake = new List<Circle>();
        Circle feed = new Circle();

        public Form1()
        {
            InitializeComponent();
            new Settings();

            timer1.Interval = 1000 / Settings.speed;
            timer1.Tick += ScreenState;
            timer1.Start();

            BeginGame();
        }


        private void BeginGame()
        {
            new Settings(); //ustawia domyślne ustawienia gry na rozpoczęciu

            
            snake.Clear();
            Circle snakeHead = new Circle(5, 5); 
            snake.Add(snakeHead);
            FeedSpawn(); //metoda umożliwiająca pojawienie się pożywienie w losowych punktach planszy na rozpoczęciu gry
            labelScore.Text = Settings.score.ToString(); //ustawia punktację na domyślną, czyli zero


            //
        }

        private void FeedSpawn()
        {
            //metoda określa pole w którym może pojawić sie jedzenie i generuje losowe w którym ono sie pojawi
            //jeśli metoda zostanie wywołana
            int maxPositionX = pictureBoxGameField.Size.Width / Settings.width;
            int maxPositionY = pictureBoxGameField.Size.Height / Settings.height;
            feed = new Circle();
            Random rand = new Random();
            feed.x = rand.Next(0, maxPositionX);
            feed.y = rand.Next(0, maxPositionY);
        }
        private void ScreenState(object sender, EventArgs e)
        {
            if (Settings.gameOver == true)
            {
                if (KeyInput.isKeyPressed(Keys.Enter)) BeginGame();
            }
            else
            {
                if (KeyInput.isKeyPressed(Keys.Up))
                    Settings.snakeDirection = Direction.up;
                else if (KeyInput.isKeyPressed(Keys.Left) && Settings.snakeDirection != Direction.right)
                    Settings.snakeDirection = Direction.left;
                else if (KeyInput.isKeyPressed(Keys.Down) && Settings.snakeDirection != Direction.up)
                    Settings.snakeDirection = Direction.down;
                else if (KeyInput.isKeyPressed(Keys.Right) && Settings.snakeDirection != Direction.left)
                    Settings.snakeDirection = Direction.right;

                Movement();

            }

            pictureBoxGameField.Invalidate();
        }

        private void pictureBoxGameField_Paint(object sender, PaintEventArgs e)
        {
            Graphics pole = e.Graphics;

            if (Settings.gameOver != true)
            {

                Brush feedColor;

                for (int i = 0; i < snake.Count; i++)
                {
                    Brush snakeColor;
                    if (i == 0) snakeColor = Brushes.Aqua; // inny kolor głowy posłuży do sprawdzenia czy wszystko działa, do zmienienia pozniej
                    else snakeColor = Brushes.White;

                    feedColor = Brushes.Green;
                    pole.FillEllipse(snakeColor, new Rectangle(snake[i].x * Settings.width, snake[i].y * Settings.height, Settings.width, Settings.height));
                    pole.FillEllipse(feedColor, new Rectangle(feed.x * Settings.width, feed.y * Settings.height, Settings.width, Settings.height));

                }


            }
            else
            {
                string gameOverText = "Przegrałeś"; //komunikat do rozwiniecia pozniej
               

            }
        }
        private void Movement()
        {

            for (int i = snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.snakeDirection)
                    {
                        case Direction.right:
                            snake[i].x++;
                            break;
                        case Direction.down:
                            snake[i].y++;
                            break;
                        case Direction.up:
                            snake[i].y--;
                            break;
                        case Direction.left:
                            snake[i].x--;
                            break;
                    }
                }




                else
                {
                    snake[i].x = snake[i - 1].x;
                    snake[i].y = snake[i - 1].y;
                }

            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            KeyInput.StateOfKey(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            KeyInput.StateOfKey(e.KeyCode, false);
        }
    }
}
