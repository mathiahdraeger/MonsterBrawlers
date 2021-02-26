using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moves : MonoBehaviour
{
    public enum MoveSets
    {
        Bite, Punch, Peck, Strangle, Crush, Scorch, JumpKick, SlideTackle,
        GustShot, Drop, Photosynthesis, Roll, Splash, Whirlpool, Fireball,
        Wildfire, Dive, Overgrowth, Seed, Avalanche, Earthquake, Tidalwave, Geyser, Eruption
    }
    public enum CloseMoves { Bite, Punch, Peck, Strangle, Crush, Scorch };
    public enum MidMoves { JumpKick, SlideTackle, GustShot, Drop, Photosynthesis, Roll, Splash, Whirlpool, Fireball, Wildfire };
    public enum LongMoves { Dive, Overgrowth, Seed, Avalanche, Earthquake, Tidalwave, Geyser, Eruption };
    public CloseMoves closeMove1;
    public CloseMoves closeMove2;
    public MidMoves midMove1;
    public MidMoves midMove2;
    public LongMoves longMove1;
    public LongMoves longMove2;
    public float energy;

    public float moveDmg;
    public float moveCost;
    public float moveChance;
    public string moveName;

    public Moves()
    {

    }

    public Moves(string name, float damage, float cost, float chance)
    {
        this.moveName = name;
        this.moveDmg = damage;
        this.moveCost = cost;
        this.moveChance = chance;
    }

    public Moves(Moves myMoves)
    {
        this.moveName = myMoves.moveName;
        this.moveDmg = myMoves.moveDmg;
        this.moveCost = myMoves.moveCost;
        this.moveChance = myMoves.moveChance;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Moves GetMove()
    {
        return this;
    }

    public void SetMove(CloseMoves move)
    {
        closeMove1 = move;
    }

    public CloseMoves GetMoveClose()
    {
        return closeMove1;
    }

    public MidMoves GetMoveMid()
    {
        return midMove1;
    }

    public LongMoves GetMoveLong()
    {
        return longMove1;
    }

    public void SetCloseMove(CloseMoves move)
    {
        closeMove1 = move;
    }

    public void SetMidMove(MidMoves move)
    {
        midMove1 = move;
    }

    public void SetLongMove(LongMoves move)
    {
        longMove1 = move;
    }

    public void SetSecondaryClose(CloseMoves move)
    {
        closeMove2 = move;
    }

    public void SetSecondaryMid(MidMoves move)
    {
        midMove2 = move;
    }

    public void SetSecondaryLong(LongMoves move)
    {
        longMove2 = move;
    }

    public Moves Bite()
    {
        this.moveName = "Bite";
        this.moveDmg = 15;
        this.moveCost = 25;
        this.moveChance = 80;
        return this;
    }

    public Moves JumpKick()
    {
        this.moveName = "JumpKick";
        this.moveDmg = 20;
        this.moveCost = 40;
        this.moveChance = 82;
        return this;
    }

    public Moves Punch()
    {
        this.moveName = "Punch";
        this.moveDmg = 10;
        this.moveCost = 15;
        this.moveChance = 85;
        return this;
    }

    public Moves SlideTackle()
    {
        this.moveName = "SlideTackle";
        this.moveDmg = 20;
        this.moveCost = 25;
        this.moveChance = 65;
        return this;
    }

    public Moves Fireball()
    {
        this.moveName = "Fireball";
        this.moveDmg = 20;
        this.moveCost = 35;
        this.moveChance = 80;
        return this;
    }

    public Moves Eruption()
    {
        this.moveName = "Eruption";
        this.moveDmg = 25;
        this.moveCost = 45;
        this.moveChance = 95;
        return this;
    }

    public Moves Earthquake()
    {
        this.moveName = "Earthquake";
        this.moveDmg = 23;
        this.moveCost = 40;
        this.moveChance = 80;
        return this;
    }

    public Moves Scorch()
    {
        this.moveName = "Scorch";
        this.moveDmg = 20;
        this.moveCost = 35;
        this.moveChance = 85;
        return this;
    }

    public Moves Peck()
    {
        this.moveName = "Peck";
        this.moveDmg = 7;
        this.moveCost = 15;
        this.moveChance = 90;
        return this;
    }

    public Moves Strangle()
    {
        this.moveName = "Strangle";
        this.moveDmg = 12;
        this.moveCost = 27;
        this.moveChance = 70;
        return this;
    }

    public Moves Crush()
    {
        this.moveName = "Crush";
        this.moveDmg = 25;
        this.moveCost = 35;
        this.moveChance = 60;
        return this;
    }

    public Moves GustShot()
    {
        this.moveName = "GustShot";
        this.moveDmg = 15;
        this.moveCost = 30;
        this.moveChance = 72;
        return this;
    }

    public Moves Drop()
    {
        this.moveName = "Drop";
        this.moveDmg = 40;
        this.moveCost = 60;
        this.moveChance = 60;
        return this;
    }

    public Moves Photosynthesis()
    {
        this.moveName = "Photosynthesis";
        this.moveDmg = 7; //supposed to heal, need to implement
        this.moveCost = 30;
        this.moveChance = 100;
        return this;
    }

    public Moves Roll()
    {
        this.moveName = "Roll";
        this.moveDmg = 15;
        this.moveCost = 25;
        this.moveChance = 80;
        return this;
    }

    public Moves Splash()
    {
        this.moveName = "Splash";
        this.moveDmg = 12;
        this.moveCost = 22;
        this.moveChance = 82;
        return this;
    }

    public Moves Whirlpool()
    {
        this.moveName = "Whirlpool";
        this.moveDmg = 20;
        this.moveCost = 37;
        this.moveChance = 95;
        return this;
    }

    public Moves Wildfire()
    {
        this.moveName = "Wildfire";
        this.moveDmg = 25;
        this.moveCost = 45;
        moveChance = 95;
        return this;
    }

    public Moves Dive()
    {
        this.moveName = "Dive";
        this.moveDmg = 22;
        this.moveCost = 38;
        this.moveChance = 78;
        return this;
    }

    public Moves Overgrowth()
    {
        this.moveName = "Overgrowth";
        this.moveDmg = 12;
        this.moveCost = 25;
        this.moveChance = 85;
        return this;
    }

    public Moves Seed()
    {
        this.moveName = "Seed";
        this.moveDmg = 7;
        this.moveCost = 18;
        this.moveChance = 80;
        return this;
    }

    public Moves Avalanche()
    {
        this.moveName = "Avalanche";
        this.moveDmg = 32;
        this.moveCost = 50;
        this.moveChance = 78;
        return this;

    }

    public Moves Tidalwave()
    {
        this.moveName = "Tidalwave";
        this.moveDmg = 28;
        this.moveCost = 43;
        this.moveChance = 90;
        return this;
    }

    public Moves Geyser()
    {
        this.moveName = "Geyser";
        this.moveDmg = 21;
        this.moveCost = 28;
        this.moveChance = 85;
        return this;

    }

    public Moves GetCloseMove(CloseMoves moves)
    {
        Moves atkDmg = null;
        switch (moves)
        {
            case CloseMoves.Bite:
                atkDmg = Bite();
                break;
            case CloseMoves.Punch:
                atkDmg = Punch();
                break;
            case CloseMoves.Strangle:
                atkDmg = Strangle();
                break;
            case CloseMoves.Peck:
                atkDmg = Peck();
                break;
            case CloseMoves.Crush:
                atkDmg = Crush();
                break;
            case CloseMoves.Scorch:
                atkDmg = Scorch();
                break;
            default:
                break;
        }
        return atkDmg;
    }

    public Moves GetMidMove(MidMoves moves)
    {
        Moves atkDmg = null;
        switch (moves)
        {
            case MidMoves.JumpKick:
                atkDmg = JumpKick();
                break;
            case MidMoves.SlideTackle:
                atkDmg = SlideTackle();
                break;
            case MidMoves.Fireball:
                atkDmg = Fireball();
                break;
            case MidMoves.GustShot:
                atkDmg = GustShot();
                break;
            case MidMoves.Drop:
                atkDmg = Drop();
                break;
            case MidMoves.Photosynthesis:
                atkDmg = Photosynthesis();
                break;
            case MidMoves.Roll:
                atkDmg = Roll();
                break;
            case MidMoves.Splash:
                atkDmg = Splash();
                break;
            case MidMoves.Whirlpool:
                atkDmg = Whirlpool();
                break;
            case MidMoves.Wildfire:
                atkDmg = Wildfire();
                break;
            default:
                break;
        }
        return atkDmg;
    }

    public Moves GetLongMove(LongMoves moves)
    {
        Moves atkDmg = null;
        switch (moves)
        {
            case LongMoves.Eruption:
                atkDmg = Eruption();
                break;
            case LongMoves.Earthquake:
                atkDmg = Earthquake();
                break;
            case LongMoves.Dive:
                atkDmg = Dive();
                break;
            case LongMoves.Overgrowth:
                atkDmg = Overgrowth();
                break;
            case LongMoves.Seed:
                atkDmg = Seed();
                break;
            case LongMoves.Avalanche:
                atkDmg = Avalanche();
                break;
            case LongMoves.Tidalwave:
                atkDmg = Tidalwave();
                break;
            case LongMoves.Geyser:
                atkDmg = Geyser();
                break;
            default:
                break;
        }
        return atkDmg;
    }

    

    

}





    

