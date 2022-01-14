using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp.Core
{
    abstract class PhysicalUnit : BaseUnit
    {
        double pAttack;
        double pDefence;
        double pCritChance;
        double pCritDamage;

        public PhysicalUnit() : base()
        {
            pAttack = Strength * 3 + 0.5 * Dexterity;
            pDefence = Constitution * 0.5 + Dexterity * 3;
            pCritChance = 20 + Dexterity * 0.3;
            pCritDamage = pAttack * (2 + Intelligence * 0.5);
        }
    }

    abstract class MagicUnit : BaseUnit
    {
        double mAttack;
        double mDefence;
        double mCritChance;
        double mCritDamage;

        public MagicUnit() : base()
        {
            mAttack = Intelligence * 4;
            mDefence = Intelligence * 2;
            mCritChance = 20 + Intelligence * 0.1;
            mCritDamage = mAttack * (2 + Intelligence * 0.15);
        }
    }
}
