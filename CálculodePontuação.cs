using UnityEngine;

public class CálculodePontuação : MonoBehaviour
{
    

    void Start() { 
   int inimigosDerrotados = 5;
    int pontosPorInimigo = 10;

    int pontuacaoTotal = inimigosDerrotados * pontosPorInimigo;

    Debug.Log("Pontuação Total: " + pontuacaoTotal);
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
