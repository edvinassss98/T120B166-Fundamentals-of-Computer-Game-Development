using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyCar : MonoBehaviour
{
    public GameObject darkButton;// the top one false interactive
    public int moneyValue;

    // Update is called once per frame
    void Update()
    {
        moneyValue = GlobalMoney.TotalMoney;
        if(moneyValue >= 200)
        {
            darkButton.GetComponent<Button>().interactable = true;
        }
    }

    public void DarkCarUnlock()
    {
        darkButton.SetActive(false);
        moneyValue -= 200;
        GlobalMoney.TotalMoney -= 200;
        //update money
        PlayerPrefs.SetInt("SavedMoney", GlobalMoney.TotalMoney);
        PlayerPrefs.SetInt("DarkCarUnlock", 200);
    }
}
