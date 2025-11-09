using UnityEngine;

public class Personagem 
{
    public string name;
    public int life;
    public int strength;

    public Personagem(string name, int life, int strength)
    {
        this.name = name;
        this.life = life;
        this.strength = strength;
    }

    public void Atacar()
    {
        Debug.Log(name + " atacou causando " + strength + " força de dano");

    }
}
