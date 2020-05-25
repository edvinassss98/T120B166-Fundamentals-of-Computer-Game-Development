using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAiColissions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "CarAi")
        {
            Debug.Log("Atsitrenke");
            this.gameObject.SetActive(false);
            StartCoroutine(Respawn());
        }
    }

    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(2);
        //ijungia box 
        this.gameObject.SetActive(true);
        Debug.Log("true");
    }*/

    IEnumerator OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "CarAi")
        {
            Debug.Log("Atsitrenke");
            this.gameObject.SetActive(false);
            //collision.gameObject.SetActive(false);
            yield return new WaitForSeconds(5.0F);
            //ijungia box 
            this.gameObject.SetActive(true);
            Debug.Log("true");
        }
    }
    /*
    IEnumerator OnCollisionEnter(Collider collision)
    {
        if (collision.gameObject.tag == "CarAi")
        {
            Debug.Log("Atsitrenke");
            this.GetComponent<BoxCollider>().enabled = false;
            yield return new WaitForSeconds(1);
            //ijungia box 
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }*/
}
