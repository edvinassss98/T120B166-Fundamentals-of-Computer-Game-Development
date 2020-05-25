using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarIgnore : MonoBehaviour
{
    //IEnumerator 
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("CarAi"))
        {

            Debug.Log("Respawn_HP_More!!!!");
            Debug.Log("Masina atsitrenke I HP box");

            this.gameObject.SetActive(false);
            //yield return new WaitForSeconds(2.0F);
            //collider.gameObject.SetActive(true);

        }
        //Maybe i will do that after several second he will be back
        if (collider.gameObject.CompareTag("Speed_Pad"))
        {
            Debug.Log("None_More_Speed:)");
            this.gameObject.SetActive(false);
        }

    }
}
