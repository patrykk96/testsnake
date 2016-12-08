using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test

{
    public enum Direction
    {
        up,
        down,
        left,
        right
    };
    class Settings
    {
        //ustawienia pola gry, predkosc, polozenie , zakonczenie gry, punktacja
        public static int width { get; set; }
        public static int height { get; set; }
        public static int score { get; set; }
        public static int speed { get; set; }
        public static bool gameOver { get; set; }
        public static Direction snakeDirection { get; set; }


        public Settings()
        {
            //ustawienia domyślne wartości do zmienienia kiedy będzie można sprawdzić je na polu gry
            width = 16;
            height = 16;
            score = 0;
            speed = 20;
            gameOver = false;
            snakeDirection = Direction.right;

        }
    }
}
