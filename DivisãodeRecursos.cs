using UnityEngine;

public class DivisãodeRecursos : MonoBehaviour
{
    int semente = 50;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int resultado = semente / 3;
        int sobra = semente % 3;

        Debug.Log("Caada um ficou com " + resultado);
        Debug.Log("É sobrou " + sobra);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
