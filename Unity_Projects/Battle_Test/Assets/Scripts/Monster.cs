using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : Moves 
{
    public enum MonsterType { Fire, Water, Rock, Nature, Wind, Electric, Normal };
    public enum Range { Close, Mid, Long };
    public Range range;
    private const float baseStrength = 100;
    private const float baseSpeed = 100;
    private const float baseHealth = 100;
    private const float baseAccuracy = 70;
    private const float baseStamina = 100;
    private const float baseDefense = 50;
    private const float maxEnergy = 100;
    protected float damage;
    public float timer;
    public bool dead;
    public bool alive;
    public HitDetection hit;

    public string Name;
    public MonsterType type;

    [Header("Stats")]
    public float strength;
    public float speed;
    public float health;
    public float accuracy;
    public float defense;
    public float stamina;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void SwapMoves()
    {
        CloseMoves tempClose;
        MidMoves tempMid;
        LongMoves tempLong;

        tempLong = longMove1;
        tempMid = midMove1;
        tempClose = closeMove1;

        longMove1 = longMove2;
        midMove1 = midMove2;
        closeMove1 = closeMove2;

        closeMove2 = tempClose;
        midMove2 = tempMid;
        longMove2 = tempLong;
    }

    public float GetEnergy()
    {
        return energy;
    }
    public virtual void TakeDamage(float dmg)
    {
        health -= dmg;
    }


    public float GetStrength()
    {
        return strength;
    }
    public void SetStrength(float str)
    {
        strength = str;
    }

    public float GetDefense()
    {
        return defense;
    }
    public void SetDefense(float def)
    {
        defense = def;
    }

    public float GetSpeed()
    {
        return speed;
    }
    public void SetSpeed(float spd)
    {
        speed = spd;
    }

    public float GetStamina()
    {
        return stamina;
    }
    public void SetStamina(float sta)
    {
        stamina = sta;
    }

    public float GetHealth()
    {
        return health;
    }
    public void SetHealth(float hp)
    {
        health = hp;
    }

    public float GetAccuracy()
    {
        return accuracy;
    }
    public void SetAccuracy(float acc)
    {
        accuracy = acc;
    }

    public void SetMonsterType(MonsterType myType)
    {
        type = myType;
    }

    public MonsterType GetMonsterType()
    {
        return type;
    }

    public float Attack(Range position)
    {
        Moves myMove;
        switch (position)
        {
            case Range.Close:
                myMove = GetCloseMove(GetMoveClose());
                break;
            case Range.Mid:
                myMove = GetMidMove(GetMoveMid());
                break;
            default:
                myMove = GetLongMove(GetMoveLong());
                break;
        }
        if (energy < moveCost)
        {
            hit.GetDmg("Not enough Stamina");
            return 0;
        }

        energy = energy - moveCost;

        //((((accuracy * myMove.moveChance) * Random.value) / (100 - myMove.moveChance)) >= (((speed * (100 - myMove.moveChance)) * Random.value)))
        


        if ((((accuracy / 10) * Random.value) * myMove.moveChance) >= (((speed / 10) * Random.value) * (100 - myMove.moveChance)))
        {
            damage = strength * myMove.moveDmg / (defense / 1.5f);
            hit.GetHit("HIT!");
            hit.GetDmg(myMove.moveName + " did " + (int) damage + " damage ");
            return damage;
        }
        else
        {
            hit.GetHit("MISSED!");
            return 0;
        }
    }
}
 

    
