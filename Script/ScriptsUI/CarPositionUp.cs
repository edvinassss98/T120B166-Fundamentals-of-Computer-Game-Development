using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarPositionUp : MonoBehaviour
{
    public GameObject posDisplay;

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "CarPos")
        {
            posDisplay.GetComponent<Text>().text = "1st Place";
        }
        else
        {
            other.gameObject.SetActive(true);
        }
    }
}
