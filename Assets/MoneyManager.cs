using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float Money;
    public UIManager uiManager;
    // Start is called before the first frame update
    void Start()
    {
        uiManager.UpdateMoneyTxt(Money.ToString());
    }

    // Update is called once per frame
    public void UpdateMoney(float moneyToAdd)
    {
        if(Money + moneyToAdd < 0)
        {
            Debug.Log("No te alcanza");
            return;
        }
        Money += moneyToAdd;
        uiManager.UpdateMoneyTxt(Money.ToString());
    }
}
