﻿using System;
using System.Collections.Generic;
using System.Text;
using BaseEmptyApp.Core.Classes;

namespace BaseEmptyApp.Core
{
    public class Warrior : BaseClass
    {
        public Warrior()
        {
            this.imgPath = @"C:\Users\secon\Source\Repos\320WPFLab\BaseEmptyApp\images\WarriorPng.jpg";
            this.MinStrenght = 30;
            this.MinDexterity = 15;
            this.MinIntelligance = 10;
            this.MinConstitution = 25;

            this.Strenght = MinStrenght;
            this.Dexterity = MinDexterity;
            this.Intelligance = MinIntelligance;
            this.Constitution = MinConstitution;

            this.MaxStrenght = 250;
            this.MaxDexterity = 80;
            this.MaxIntelligance = 50;
            this.MaxConstitution = 100;

            GetCharacteristics();
        }
    }
}
