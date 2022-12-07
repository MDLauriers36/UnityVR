using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float delay = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Fire")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Do something else here");

            IEnumerator DelayDeactivate(float _delay)
            {
                yield return new WaitForSeconds(_delay);
                this.gameObject.SetActive(false);
            }
            StartCoroutine(DelayDeactivate(delay));
        }
       
    }
    
}
