using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RaceFinish : MonoBehaviour
{
    public GameObject MyCar;
    public GameObject FinishCam;
    public GameObject ViewModes;
    //public GameObject music; // music in gameplay
    public GameObject CompleteTrig;
    // public AudioSource FinishMusic; // music then finished racing

    public GameObject RaceFinishTrigger;
    public GameObject EndGamePanel;

    void OnTriggerEnter(Collider collider)
    {
        //this.GetComponent<BoxCollider>().enabled = false;
        MyCar.SetActive(false);
        CompleteTrig.SetActive(false);
        NewCarController.m_Topspeed = 0.0f;
        MyCar.GetComponent<NewCarController>().enabled = false;
        MyCar.GetComponent<InputManager>().enabled = false;
        MyCar.SetActive(true);
        FinishCam.SetActive(true);
        ViewModes.SetActive(false);

        this.gameObject.SetActive(false);

        if (collider.gameObject.CompareTag("CarAi"))
        {
            EndGamePanel.GetComponent<GameOver>().Finished(2);
            GlobalMoney.TotalMoney += 50;
        }
        else
        {
            EndGamePanel.GetComponent<GameOver>().Finished(1);
            GlobalMoney.TotalMoney += 100;
        }
           
        //-------------
        GlobalMoney.TotalMoney += 100;
        Debug.Log("RaceFinish adds more money");
        PlayerPrefs.SetInt("SavedMoney", GlobalMoney.TotalMoney);
    }
}
