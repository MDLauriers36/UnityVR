using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fire : MonoBehaviour
{
    // Start is called before the first frame update
    
    public static float nb;
    public GameObject cadeau;
    public Temps horloge;
    public GameObject win;

    
    

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "cadeau")
        {
            Debug.Log("cadeau");
            nb++;
            if(Temps.getHorloge() !> 0)
            {
                Debug.Log("Il est trop tard");
            }
            if(nb > 2 && Temps.getHorloge() > 0)
            {
                win.SetActive(true);
            }
        }
        else if (collision.gameObject.tag == "Fire")
        {
            Debug.Log("Fire");
        }
    }
    public static float getNb()
    {
        return nb;
    }
    public void resetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
        nb = 0;
        win.SetActive(false);
    }
    public void goBack()
    {
        SceneManager.LoadScene("scene max xr 2"); // loads current scene
        nb = 0;
        win.SetActive(false);
    }
}
