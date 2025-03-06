using System;
public class Kata
{
    public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
    {
        string winner = "";
        while (fighter1.Health >= 0 && fighter2.Health >= 0)
        {
            if (fighter1.Name == firstAttacker)
            {
                fighter2.Health -= fighter1.DamagePerAttack;
                if (fighter2.Health <= 0)
                {
                    winner = fighter1.Name;
                }
                else
                {
                    fighter1.Health -= fighter2.DamagePerAttack;
                }
            }
            else if (fighter2.Name == firstAttacker)
            {
                fighter1.Health -= fighter2.DamagePerAttack;
                if (fighter1.Health <= 0)
                {
                    winner = fighter2.Name;
                }
                else
                {
                    fighter2.Health -= fighter1.DamagePerAttack;
                }
            }
        }
        if (fighter1.Health <= 0)
        {
            winner = fighter2.Name;
        }
        else if (fighter2.Health <= 0)
        {
            winner = fighter1.Name;
        }
        return winner;
    }
}