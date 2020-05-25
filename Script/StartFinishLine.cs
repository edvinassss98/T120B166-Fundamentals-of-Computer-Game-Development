using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartFinishLine : MonoBehaviour
{
    private int nLaps = 0; // Number of laps

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "CarModel")
        {
            nLaps++;
            if(nLaps == 2)
            {
                SceneManager.LoadScene("FinishScene");
            }
        }
    }
}
