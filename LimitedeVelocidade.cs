using UnityEngine;

public class LimitedeVelocidade : MonoBehaviour
{
    float velocidade_player = 8.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (velocidade_player >= 10.0f)
        {
            Debug.Log("Correndo rapido");
        } else if (velocidade_player >= 5.0f)
        {
            Debug.Log("Correndo ideal");

        } else {
            Debug.Log("PAradaro");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
