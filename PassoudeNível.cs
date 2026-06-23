using UnityEngine;

public class PassoudeNível : MonoBehaviour
{
  
    int nivelAtual = 20;
     int nivelNecessario = 15;
     int nivel_jogador = 2;
    void Start()
    {
        if (nivelAtual >= nivelNecessario)
        {
            Debug.Log($"{ nivel_jogador + 1} +LEVEL UP");
        }
        else
        {
            Debug.Log( " no LEVEL UP");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
