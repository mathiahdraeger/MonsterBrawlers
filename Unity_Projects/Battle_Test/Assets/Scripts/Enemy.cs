using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : Player
{
    private GameObject enemyObj;
    private GameObject playerObj;

    // Start is called before the first frame update
    void Start()
    {
        type = MonsterType.Rock;
        Name = "Bob";
        energy = 20;
        SetCloseMove(Enemy.CloseMoves.Bite);
        SetMidMove(Enemy.MidMoves.JumpKick);
        SetLongMove(Enemy.LongMoves.Eruption);
        SetSecondaryClose(Enemy.CloseMoves.Punch);
        SetSecondaryMid(Enemy.MidMoves.Fireball);
        SetSecondaryLong(Enemy.LongMoves.Earthquake);
        healthBar.SetMaxHealth((int)health);
        energyBar.SetEnergy((int)energy);
        dead = false;
        hit.GetEnemyName(Name.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        enemyObj = GameObject.Find("Enemy");
        playerObj = GameObject.Find("Player");
        var distance = Vector3.Distance(playerObj.transform.position, enemyObj.transform.position);

        if (distance < 10)
            range = Range.Close;
        else if (distance > 10 && distance < 20)
            range = Range.Mid;
        else
            range = Range.Long;

        if(energy > 50)
        {
            float tempDef = defense;
            float tempSpd = speed;
            defense = playerObj.GetComponent<Player>().GetDefense();
            speed = playerObj.GetComponent<Player>().GetSpeed();
            playerObj.GetComponent<Player>().TakeDamage(Attack(range));
            defense = tempDef;
            speed = tempSpd;

        }

        timer -= Time.fixedDeltaTime;
        if (timer < 0.58 && energy < 100 && !Input.GetKey(KeyCode.LeftShift))
        {
            energy = energy + 1 + (stamina / 1000);
            timer = 1;
        }
        if (health <= 0)
        {
            dead = true;
            hit.GetVictory("VICTORY!");
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

    }

    public override void TakeDamage(float dmg)
    {
        health = health - (int) dmg;
        healthBar.SetHealth((int)health);

    }

}

