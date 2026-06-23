using UnityEngine;

public class RadardeInimigos : MonoBehaviour
{
    float distancia_inimigo = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (distancia_inimigo < 5f)
            {
                Debug.Log("Inimigo perto");
            }
            else
            {
                Debug.Log("Area segura");
            }


        }
    }
}