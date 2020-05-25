using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonOption : MonoBehaviour
{
    public GameObject playGameButton;
    public GameObject optionsButton;
    public GameObject aboutButton;
    public GameObject quitGameButton;
    public GameObject mainMenuButton;

    public Text aboutDisplay;

    public GameObject optionsPanel;

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void MainMenu()
    {
        if(SceneManager.GetActiveScene().buildIndex != 0)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            ButtonsSetActive(1);
            mainMenuButton.gameObject.SetActive(false);
            if (aboutDisplay.gameObject.active)
                aboutDisplay.gameObject.SetActive(false);
            else
                optionsPanel.SetActive(false);
        }
    }

    //Bellow here are track selection buttons :)

    public void Track01()
    {
        SceneManager.LoadScene(2);
    }

    //Second testing circuit how it would look
    public void Track02()
    {
        SceneManager.LoadScene(3);
    }

    public void Options()
    {
        ButtonsSetActive(0);
        optionsPanel.SetActive(true);
    }
    public void About()
    {
        ButtonsSetActive(0);
        aboutDisplay.gameObject.SetActive(true);
    }

    private void ButtonsSetActive(int sig)
    {
        if(sig == 0)
            playGameButton.gameObject.SetActive(false);
        else
            playGameButton.gameObject.SetActive(true);
        if (sig == 0)
            optionsButton.gameObject.SetActive(false);
        else
            optionsButton.gameObject.SetActive(true);
        if (sig == 0)
            aboutButton.gameObject.SetActive(false);
        else
            aboutButton.gameObject.SetActive(true);
        if (sig == 0)
            quitGameButton.gameObject.SetActive(false);
        else
            quitGameButton.gameObject.SetActive(true);
        if(sig == 0)
            mainMenuButton.gameObject.SetActive(true);
        else
            mainMenuButton.gameObject.SetActive(false);
    }

    public void Exit()
    {
        Debug.Log("Has quit game");
        Application.Quit();
    }
}
