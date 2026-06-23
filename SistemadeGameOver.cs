using UnityEngine;

public class SistemadeGameOver : MonoBehaviour
{
    int vida = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (vida == 0) {
            Debug.Log("Game over");
        }
        else {
            Debug.Log("Continua");
        
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
