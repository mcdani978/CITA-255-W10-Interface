using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testinterface : MonoBehaviour
{
    void Start()
    {
        //POLYMORPHISM
        // player newPlayer = new Player();
        //IAttack player = new Player();
        //player.Attack();

        AttackObject(new Player());
        AttackObject(new Enemy());
    }


    void AttackObject(IAttack iAttack)
    {
        iAttack.Attack();
    }
}
