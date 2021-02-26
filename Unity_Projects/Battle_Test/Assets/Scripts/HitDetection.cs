using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitDetection : MonoBehaviour
{
    public Text hitText;
    public Text dmgText;
    public Text energyText;
    public Text hpText;
    public Text rangeText;
    public Text closeText;
    public Text midText;
    public Text longText;
    public Text closeCostText;
    public Text midCostText;
    public Text longCostText;
    public Text victoryText;
    public Text monsterNameText;
    public Text enemyMonsterNameText;
    public Text timeText;
    private float displayTime = 2;
    private float endTime;

    public void GetHit(string newText)
    {
        EnableText(hitText);
        hitText.text = newText;
        
    }
    public void GetDmg(string newText)
    {
        EnableText(dmgText);
        dmgText.text = newText;

    }
    public void GetRange(string newText)
    {
        rangeText.text = newText;

    }
    public void GetTime(string newText)
    {
        timeText.text = newText;

    }
    public void GetMonsterName(string newText)
    {
        monsterNameText.text = newText;

    }
    public void GetEnemyName(string newText)
    {
        enemyMonsterNameText.text = newText;

    }
    public void GetClose(string newText)
    {
        closeText.text = newText;

    }
    public void GetMid(string newText)
    {
        midText.text = newText;

    }
    public void GetLong(string newText)
    {
        longText.text = newText;

    }
    public void GetCloseCost(string newText)
    {
        closeCostText.text = newText;

    }
    public void GetMidCost(string newText)
    {
        midCostText.text = newText;

    }
    public void GetLongCost(string newText)
    {
        longCostText.text = newText;

    }
    public void GetEnergy(string newText)
    {
        energyText.text = newText;
    }
    public void GetHP(string newText)
    {
        hpText.text = newText;
    }
    public void GetVictory(string newText)
    {
        victoryText.text = newText;
    }

    public void EnableText(Text myText)
    {
        myText.enabled = true;
        endTime = Time.time + displayTime;
    }

    void Update()
    {
        if (hitText.enabled && (Time.time >= endTime))
            hitText.enabled = false;
        if (dmgText.enabled && (Time.time >= endTime))
            dmgText.enabled = false;

    }
}
