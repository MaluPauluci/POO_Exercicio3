using UnityEngine;

public class Espada : Arma, IArmaDeCorte
{
    private string nome;
    private int dano; 
    public Espada(string Nome, int Dano) : base(Nome, Dano)
    {
        this.nome = Nome;
        this.dano = Dano;
    }

    public void Cortar()
    {
        Debug.Log("Corte com a espada " +  nome  + " causa dano de " + dano);
    }

    public override void Usar()
    {
        Cortar();
    }
}
