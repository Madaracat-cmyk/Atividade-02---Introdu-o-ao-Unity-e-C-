using UnityEngine;

public class VerificadordeAcesso : MonoBehaviour
{
    bool porta_de_acesso = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if  (porta_de_acesso == true)
        {
            Debug.Log("Acesso permitido");
        }
        else{
            Debug.Log("Acesso negado");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
