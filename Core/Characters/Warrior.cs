using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public class Warrior : Character
    {
        public Warrior()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }

            Strength = 30;
            if (Strength < 30 || Strength > 250)
            {
                
            }


            Dexterity = 15;
            Intelligence = 10;
            Constitution = 25;
        }
    }
}
