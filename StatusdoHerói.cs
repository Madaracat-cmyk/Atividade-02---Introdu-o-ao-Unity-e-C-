using UnityEngine;

public class StatusdoHerói : MonoBehaviour
{
    int vida = 10;
    float energia = 25.0f;
    bool mascara = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Vida:" + vida);
        Debug.Log("Energia" + energia);
        Debug.Log(mascara);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
