using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float Money;
    public UIManager uiManager;

    void Start()
    {
        uiManager.UpdateMoneyTxt(Money.ToString());
    }

    public void UpdateMoney(float moneyToAdd)
    {
        Debug.Log("update");

        if(Money + moneyToAdd < 0)
        {
            Debug.Log("No te alcanza");
            return;
        }
        Money += moneyToAdd;
        uiManager.UpdateMoneyTxt(Money.ToString());
    }
}
