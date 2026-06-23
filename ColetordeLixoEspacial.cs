using UnityEngine;

public class ColetordeLixoEspacial : MonoBehaviour
{
    int coletor_de_lixo = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            coletor_de_lixo ++;
            Debug.Log("Pontuação: " + coletor_de_lixo );
        }
        else
        {

        }
        
    }
}
