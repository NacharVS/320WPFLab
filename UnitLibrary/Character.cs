using System;

namespace UnitLibrary
{
    abstract class Character
    {
        static int Strength;
        static int Dexterity;
        static int Intelligence;
        static int Constitution { get; set; }
        double Health => 2 * Constitution + 0.5 * Strength;
        double Mana => Intelligence * 3;
        //if Health < 0.5*Health ==>
        //allCharacteristics - *0.1

        //if mana< 0.2*mana ==>
        //MaxHealth - MaxHealth*0.2

        Magic magic = new Magic() { 
            Attack = Strength * 3 + 0.5 * Dexterity,
            Defense = Constitution * 0.5 + Dexterity * 3,
            CriticalChance = 20 + Dexterity *0.3,
            //CriticalDamage = 
        };
        Physics physics;



        //P.Attack = str*3 + 0.5*dex
        //P.Defense = con* 0.5 + dex* 3
        //P.CriticalDamage = P.Attack* (2 + dex*0.05) 
        //P.Critical Chanse = 20 + dex * 0.3        
        //
        //M.Attack = int* 4;
        //M.Critical Chanse = 20 + int * 0.1
        //M.Defense = int*2;
        //M.CriticalDamage = M.Attack* (2 + int* 0.15 )
    }
}
