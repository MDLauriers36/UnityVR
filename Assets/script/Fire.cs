using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float nb;

    public Timer horloge;
    private GameObject win;

    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Fire")
        {

            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Fais dequoi");
            nb++;
               
             
                if(nb >= 2)
                {
                    Debug.Log("plus que 2");
                }
            
        }
       
    }
    
}
