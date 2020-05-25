using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Lap time Counter Counts time of the Lap
/// </summary>
public class LapTimeManager : MonoBehaviour
{
    public static int MinCount;
    public static int SecCount;
    public static float MilliCount;
    public static string MilliDisplay;

    //UI objects
    public GameObject MinBox;
    public GameObject SecBox;
    public GameObject MilliBox;

    public static float RawTime;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        MilliCount += Time.deltaTime * 10; // we need milli seconds 
        RawTime += Time.deltaTime;
        MilliDisplay = MilliCount.ToString("F0");
        MilliBox.GetComponent<Text>().text = "" + MilliDisplay;

        if(MilliCount >= 10)
        {
            MilliCount = 0;
            SecCount += 1;
        }

        //Because we want 01 02 03.. time sec
        if(SecCount <= 9)
        {
            SecBox.GetComponent<Text>().text = "0" + SecCount + ".";
        }
        else
        {
            SecBox.GetComponent<Text>().text = SecCount + ".";
        }

        if(SecCount >= 60)
        {
            SecCount = 0;
            MinCount += 1;
        }

        if(MinCount <= 9)
        {
            MinBox.GetComponent<Text>().text = "0" + MinCount + ":";
        }
        else
        {
            MinBox.GetComponent<Text>().text = MinCount + ":";
        }
    }
}
