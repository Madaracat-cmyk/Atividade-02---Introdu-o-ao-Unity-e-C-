using UnityEngine;

public class MecânicadePuloSeguro : MonoBehaviour
{
    bool nochao = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && nochao)
        {
            Debug.Log("Salto realizado");
            nochao = false;
        }
        
    }
}
