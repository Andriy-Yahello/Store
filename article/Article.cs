using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article
{
    public class Article
    {
        private string[] name = new string[5];
        private string[] brand = new string[5];
        private string[] price = new string[5];

        public Article()
        {
            name[0] = "ps4"; brand[0] = "Sony"; price[0] = "399.99";
            name[1] = "controller"; brand[1] = "SIXAXIS"; price[1] = "59.99";
            name[2] = "Game F.E.A.R."; brand[2] = "Monolith"; price[2] = "19.99";
            name[3] = "Game MGS5"; brand[3] = "KONAMI"; price[3] = "39.99";
            name[4] = "Game MotorStorm"; brand[4] = "HAVOK"; price[4] = "9.99";
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < name.Length)
                    return name[index] + " " + brand[index] + " " + price[index];
                else
                    return "an attempt to address array index out of scope";
            }
        }


        public string this[string index]
        {
            
            get {
                for (int i = 0; i < name.Length; i++)
                    if (name[i]==index)
                    return name[i] + " " + brand[i] + " " + price[i];
                return string.Format("{0} - There's no item with such name.", index);
            }
        }

    }
}
