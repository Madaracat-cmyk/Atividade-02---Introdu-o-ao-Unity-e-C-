using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float velocidadeDoJogador = 6.0f;
    public float velocidadeDeRotacao = 150.0f;

    public float inputHorizontal;
    public float inputVertical;

    void Start()
    {
        Debug.Log("Sistema de Inpunt acoplado ao Eco");
    }

   
    void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");
        
        Vector3 direcaoDoMovimento = new Vector3(inputHorizontal,0, 0);
        transform.Translate(direcaoDoMovimento * velocidadeDoJogador * Time.deltaTime, Space.World);
       
        Vector3 direcaoDaRotacao = new Vector3( 0, 0, inputVertical);
        transform.Rotate(direcaoDaRotacao * velocidadeDeRotacao * Time.deltaTime);
    }
}
