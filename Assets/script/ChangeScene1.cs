using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject scene;
   public void LoadScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
