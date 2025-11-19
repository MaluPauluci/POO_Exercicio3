using UnityEngine;

public class Arqueiro : Personagem
{
    public int arrows = 10; 

    public Arqueiro(string name, int life, int strength) : base(name, life, strength)
    {
    }

    public void ShootingArrows()
    {
        if(arrows > 0)
        {
            arrows--;
            Debug.Log("Sobraram " + arrows + " flechas");
        }
    }
}
