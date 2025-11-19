using UnityEngine;

public abstract class Arma
{
    private string nome;
    private int dano;

    public Arma(string Nome,  int Dano)
    {
        this.nome = Nome;
        this.dano = Dano;
    }

    public abstract void Usar();
}
