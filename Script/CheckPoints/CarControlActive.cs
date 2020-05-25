using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControlActive : MonoBehaviour
{
    public GameObject CarControl;
    public GameObject CarAI;

    // Start is called before the first frame update
    void Start()
    {
        CarControl.GetComponent<NewCarController>().enabled = true;
        CarAI.GetComponent<CarAIControl>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
