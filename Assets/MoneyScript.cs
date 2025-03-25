using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyScript : MonoBehaviour
{
    float player_money = 0;

    public ClockScript clock;

    void Start()
    {
        clock = GameObject.FindGameObjectWithTag("ClockTag").GetComponent<ClockScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (clock.isNextTurn())
        {
            player_money++;
        }
    }
    public bool setMoney(float moneyAmount)
    {
        if (moneyAmount >= 0)
        {
            player_money = moneyAmount;
            return true;
        } else
        {
            player_money = 0;
            return false;
        }
    }
    public void addMoney(float moneyAmount)
    {
        player_money += moneyAmount;
    }
    public float getMoney()
    {
        return player_money;
    }
}
