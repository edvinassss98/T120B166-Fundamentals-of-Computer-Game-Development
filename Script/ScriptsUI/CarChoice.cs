using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    public GameObject BlueBody;
    public GameObject DarkBody;

    public int CarImport;

    // Start is called before the first frame update
    void Start()
    {
        // 1 blue 2 is Dark
        CarImport = GlobalCar.CarType;
        if(CarImport == 1)
        {
            BlueBody.SetActive(true);
        }
        if (CarImport == 2)
        {
            DarkBody.SetActive(true);
        }
    }

}
