using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockedCars : MonoBehaviour
{
    public int darkSelect;
    public GameObject lockedDarkCar;

    // Start is called before the first frame update
    void Start()
    {
        darkSelect = PlayerPrefs.GetInt("DarkCarUnlock");
        if (darkSelect == 200)
        {
            lockedDarkCar.SetActive(false);
        }
    }

}
