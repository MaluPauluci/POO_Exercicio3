using UnityEditor;
using UnityEditor.Rendering.Analytics;
using UnityEngine;

public class Revolver : Arma, IArmaDeFogo
{
    private string nome;
    private int dano; 
    public Revolver(string Nome, int Dano) : base(Nome, Dano)
    {
        this.nome = Nome;
        this.dano = Dano;
    }

    public void Atirar()
    {
        Debug.Log("Atirou com " + nome + " causando dano de " + dano);
    }

    public override void Usar()
    {
        Atirar();
    }
}
