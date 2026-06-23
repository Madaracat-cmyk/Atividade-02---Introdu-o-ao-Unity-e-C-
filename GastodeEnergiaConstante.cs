using UnityEngine;

public class GastodeEnergiaConstante : MonoBehaviour
{
    bool correndo = true;
    float energia = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
            energia -= 1;
            Debug.Log("Stamina :" + energia);
        }
        
        if(energia == 0)
        {
            Debug.Log("Sem energia");
            
        }
    }
}
