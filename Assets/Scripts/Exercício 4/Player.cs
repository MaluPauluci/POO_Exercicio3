using UnityEngine;

public class Player : MonoBehaviour
{
    private Espada espada = new Espada("João", 20);
    private Revolver revolver = new Revolver("escopeta", 30);
    void Start()
    {
        espada.Usar();
        revolver.Usar();
    }

   
}
