using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 Car selection script
     */

public class GlobalCar : MonoBehaviour
{
    public static int CarType; //1 = blue, 2 = dark
    public GameObject TrackWindow;

    public void BlueCar()
    {
        CarType = 1;
        TrackWindow.SetActive(true);
    }

    public void DarkCar()
    {
        CarType = 2;
        TrackWindow.SetActive(true);
    }
}
