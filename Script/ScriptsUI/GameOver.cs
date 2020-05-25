using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject MyCar;
    public GameObject GameOverPanel;
    public Text Title;
    public Text Position;
    public Text Receive;
    public Text GameOverTitle;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (MyCar.GetComponent<CarHealth>().Health <= 0)
        {
            MyCar.SetActive(false);
            GameOverPanel.SetActive(true);
            Title.gameObject.SetActive(false);
            Position.gameObject.SetActive(false);
            Receive.gameObject.SetActive(false);
            GameOverTitle.gameObject.SetActive(true);
            NewCarController.m_Topspeed = 0.0f;
            MyCar.GetComponent<NewCarController>().enabled = false;
            MyCar.GetComponent<InputManager>().enabled = false;
            MyCar.SetActive(true);
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Finished(int place)
    {
        GameOverPanel.SetActive(true);
        Title.gameObject.SetActive(true);
        Position.gameObject.SetActive(true);
        Receive.gameObject.SetActive(true);
        GameOverTitle.gameObject.SetActive(false);

        if(place == 1)
        {
            Position.GetComponent<Text>().text = "Position:" + place + "st";
            Receive.GetComponent<Text>().text = "Money you will receive: 100";
        }
        else
        {
            Position.GetComponent<Text>().text = "Position:" + place + "nd";
            Receive.GetComponent<Text>().text = "Money you will receive: 50";
        }
        
    }
}
