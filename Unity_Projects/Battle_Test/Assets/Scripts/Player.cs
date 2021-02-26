using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Monster
{
    private GameObject pObj;
    private GameObject eObj;
    public HealthBar healthBar;
    public EnergyBar energyBar;
    public float clock;


    // Start is called before the first frame update
    void Start()
    {
        type = GetMonsterType();
        Name = "Jerry";
        SetCloseMove(CloseMoves.Bite);
        SetMidMove(MidMoves.Fireball);
        SetLongMove(LongMoves.Eruption);
        SetSecondaryClose(CloseMoves.Scorch);
        SetSecondaryMid(MidMoves.JumpKick);
        SetSecondaryLong(LongMoves.Earthquake);
        energy = 20;
        healthBar.SetMaxHealth((int)health);
        energyBar.SetEnergy((int)energy);
        alive = true;
        hit.GetMonsterName(Name.ToString());
        clock = 60;
    }

    // Update is called once per frame
    void Update()
    {
        eObj = GameObject.Find("Enemy");
        pObj = GameObject.Find("Player");
        var distance = Vector3.Distance(pObj.transform.position, eObj.transform.position); 

        if (distance < 10)
            range = Range.Close;
        else if (distance > 10 && distance < 20)
            range = Range.Mid;
        else
            range = Range.Long;

        if (Input.GetMouseButtonDown(0))
        {
            float tempDef = defense;
            float tempSpd = speed;
            defense = eObj.GetComponent<Enemy>().GetDefense();
            speed = eObj.GetComponent<Enemy>().GetSpeed();
            eObj.GetComponent<Enemy>().TakeDamage(Attack(range));
            defense = tempDef;
            speed = tempSpd;
        }

        timer -= Time.fixedDeltaTime;
        if (timer < 0.58 && energy < 100 && !Input.GetKey(KeyCode.LeftShift))
        {
            energy = energy + 1 + (stamina / 1000);
            timer = 1;
        }

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
        {
            SwapMoves();
        }

        if (health <= 0)
        {
            alive = false;
            hit.GetVictory("DEFEAT!");
        }
        energyBar.SetEnergy((int)energy);
        hit.GetHP(health.ToString());
        int cleanEnergy = (int)energy;
        hit.GetEnergy(cleanEnergy.ToString());
        hit.GetRange(range.ToString() + " Range");

        Moves myMove;
        myMove = GetCloseMove(GetMoveClose());
        hit.GetCloseCost(myMove.moveCost.ToString());
        hit.GetClose(myMove.moveName);
        myMove = GetMidMove(GetMoveMid());
        hit.GetMidCost(myMove.moveCost.ToString());
        hit.GetMid(myMove.moveName);
        myMove = GetLongMove(GetMoveLong());
        hit.GetLongCost(myMove.moveCost.ToString());
        hit.GetLong(myMove.moveName);

        if(clock > 0)
        {
            clock -= Time.deltaTime;
            float seconds = Mathf.FloorToInt(clock % 60);
            hit.GetTime(seconds.ToString());
        }

    }

    public override void TakeDamage(float dmg)
    {
        health = health - (int) dmg;
        
        healthBar.SetHealth((int)health);
    }
}
