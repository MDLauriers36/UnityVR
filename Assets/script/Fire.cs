using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float nb;
    public GameObject cadeau;
    public Timer horloge;
    public GameObject win;

    
    

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "cadeau")
        {
            Debug.Log("cadeau");
        }
        else if (collision.gameObject.tag == "Fire")
        {
            Debug.Log("Fire");
        }
    }

}
