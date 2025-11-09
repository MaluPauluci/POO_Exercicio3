using UnityEngine;

public class Teste : MonoBehaviour
{
    void Start()
    {
        Arqueiro Teste = new Arqueiro("Katniss", 50, 10);
        Teste.Atacar();
        Teste.ShootingArrows();

    }
}
