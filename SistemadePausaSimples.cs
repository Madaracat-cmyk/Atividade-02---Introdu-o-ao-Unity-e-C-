using UnityEngine;

public class SistemadePausaSimples : MonoBehaviour
{
    bool jogo_pausado = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
        {
            jogo_pausado = !jogo_pausado;

            Debug.Log(jogo_pausado ? "Jogo Pausado..." : "Jogo Ativo!");
        }
        
    }
}
