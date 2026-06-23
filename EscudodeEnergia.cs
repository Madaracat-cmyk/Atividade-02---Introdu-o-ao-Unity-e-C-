using UnityEngine;

public class EscudodeEnergia : MonoBehaviour
{
    bool ativa_escudo = true;
    int dano_inimigo = 4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(ativa_escudo )
        {
            Debug.Log((dano_inimigo / 2) + "Dano recebido");
        }
        else
        {
            Debug.Log(dano_inimigo + "Dano recebido");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
