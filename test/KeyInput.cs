using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; //potrzebne do uzyskania dostępu do klasy Hashtable
using System.Windows.Forms; //uzyskanie dostępu do zmiennej Keys

namespace test
{
    class KeyInput
    {
        //odczytanie klawiszy z klawiatury użytkownika
        private static Hashtable keyboard = new Hashtable();

        //Metoda sprawdza czy dany klawisz jest wcisnięty
        public static bool isKeyPressed(Keys key)
        {
            if (keyboard[key] == null) return false;
            else return (bool)keyboard[key];
        }


        public static void StateOfKey(Keys key, bool state)
        {
            keyboard[key] = state;
        }

    }
}
