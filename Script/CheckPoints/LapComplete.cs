using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
     Here i am calculating laps , saving best time.
     */

public class LapComplete : MonoBehaviour
{
    public GameObject CheckPointTrigger;
    public GameObject LapCompleteTrigger;

    //UI objects
    public GameObject MinDisp;
    public GameObject SecDisp;
    public GameObject MilliDisp;

    public GameObject LapCounter;
    public int LapsDone;

    public float RawTime;

    public GameObject RaceFinish;

    public int MyCar;
    public int AICar;
    private bool nextLap = true;
    public bool passed = true;

    public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player") && passed)
        {
            passed = false;
            MyCar++;
            Debug.Log("MyCar" + MyCar);
            nextLap = true;
        }
        else if(other.gameObject.CompareTag("CarAi"))
        {
            AICar++;
            //Debug.Log(AICar);
        }

        if(MyCar == 5)
        {
            RaceFinish.SetActive(true);
            Debug.Log("Pralosiau");
        }
        else if (AICar == 5)
        {
            RaceFinish.SetActive(true);
            Debug.Log("AI Laimejo");
        }

        if(MyCar == 3 && nextLap == true || MyCar == 5 && nextLap == true)
        {
            nextLap = false;
            LapsDone++;
            Debug.Log("LAps");

            RawTime = PlayerPrefs.GetFloat("RawTime");
            if (LapTimeManager.RawTime <= RawTime)
            {
                if (LapTimeManager.SecCount <= 9)
                {
                    SecDisp.GetComponent<Text>().text = "0" + LapTimeManager.SecCount + ".";
                }
                else
                {
                    SecDisp.GetComponent<Text>().text = "" + LapTimeManager.SecCount + ".";
                }

                if (LapTimeManager.MinCount <= 9)
                {
                    MinDisp.GetComponent<Text>().text = "0" + LapTimeManager.MinCount + ".";
                }
                else
                {
                    MinDisp.GetComponent<Text>().text = "" + LapTimeManager.MinCount + ".";
                }

                MilliDisp.GetComponent<Text>().text = "" + LapTimeManager.MilliCount;
            }
            Debug.Log( "MinCount" +  LapTimeManager.MinCount);
            Debug.Log("SecCount" + LapTimeManager.SecCount);
            Debug.Log("MilliCount" + LapTimeManager.MilliCount);
            PlayerPrefs.SetInt("MinSave", LapTimeManager.MinCount);
            PlayerPrefs.SetInt("SecSave", LapTimeManager.SecCount);
            PlayerPrefs.SetFloat("MilliSave", LapTimeManager.MilliCount);
            PlayerPrefs.SetFloat("RawTime", LapTimeManager.RawTime);

            //Reseting Time
            LapTimeManager.MinCount = 0;
            LapTimeManager.SecCount = 0;
            LapTimeManager.MilliCount = 0;

            LapTimeManager.RawTime = 0;
            LapCounter.GetComponent<Text>().text = "" + LapsDone;
        }
    }

}
