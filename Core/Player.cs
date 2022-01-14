using System;

public abstract class Player
{
	public double strength = 0;
	public double dexterity = 0;
	public double intelligence = 0;
	public double constitution = 0;
	public double health = 0;
	public double mana = 0;

	public Player(double str, double dex, double intell, double con) 
	{
		strength = str;
		dexterity = dex;
		intelligence = intell;
		constitution = con;
		Pattack = str * 3 + 0.5 * dex;
		Pdefense = con * 0.5 + dex * 3;
		Mattack = intell * 4;
		Mdefense = intell * 2;
		Pcrit = 20 + dex * 0.3;
		Mcrit = 20 + intell * 0.1;
		Pcrid = Pattack * (2 + dex * 0.05);
		Mcrid = Mattack * (2 + intell * 0.15);
	}
	public static double Health(double con, double str) 
	{
		health = 2 * con + 0.5 * str;
	}
	public static double Mana(double intell) 
	{
		Mana = intell * 3;
	}

}
