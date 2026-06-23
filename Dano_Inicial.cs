using UnityEngine;

public class Dano_Inicial : MonoBehaviour
{
    int vida = 100;
    int dano = 15;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        vida = vida - dano;
        Debug.Log("Vida:" + vida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
