using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalMoney : MonoBehaviour
{
    public int MoneyValue;
    public static int TotalMoney;
    public GameObject MoneyDisplay;

    // Start is called before the first frame update
    void Start()
    {
        TotalMoney = PlayerPrefs.GetInt("SavedMoney");
    }

    // Update is called once per frame
    void Update()
    {
        //Cheats
        if (Input.GetKeyDown(KeyCode.M))
        {
            
            TotalMoney += 1000;
            Debug.Log("AddMoneyCheat");
        }

        //ResetPlayerPrefs
        if (Input.GetKeyDown(KeyCode.P))
        {
            PlayerPrefs.DeleteAll();
            Debug.Log("ResetEverything");
        }
        MoneyValue = TotalMoney;
        MoneyDisplay.GetComponent<Text>().text = "Money: " + MoneyValue;


    }
}
