using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoin01 : MonoBehaviour
{
    public GameObject CheckPointTrigger;
    public GameObject LapCompleteTrigger;

    public int MyCarCheck;
    public int AICarCheck;

    public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            LapCompleteTrigger.GetComponent<LapComplete>().MyCar++;
            LapCompleteTrigger.GetComponent<LapComplete>().passed = true;
        }
        else if (other.gameObject.CompareTag("CarAi"))
        {
            LapCompleteTrigger.GetComponent<LapComplete>().AICar++;
        }
    }
}
