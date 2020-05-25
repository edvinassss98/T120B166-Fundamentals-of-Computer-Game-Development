using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAIIgnore : MonoBehaviour
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
    //IEnumerator 
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("HP"))
        {

            Debug.Log("Respawn_HP_More!!!!");

            collider.gameObject.SetActive(false);
            //yield return new WaitForSeconds(2.0F);
            //collider.gameObject.SetActive(true);

        }
        //Maybe i will do that after several second he will be back
        if (collider.gameObject.CompareTag("Speed_Pad"))
        {
            Debug.Log("None_More_Speed:)");
            collider.gameObject.SetActive(false);
        }

    }*/


    //IEnumerator 
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Barrel_Fire"))
        {
            //Debug.Log("respawnBoom and None");
            collision.gameObject.SetActive(false);

            //yield return new WaitForSeconds(2.0F);

            collision.gameObject.SetActive(true);

        }
    }
}
