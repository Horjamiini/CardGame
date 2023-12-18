using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertedBoi : Enemy
{
    
    private void Awake()
    {
        player = FindObjectOfType<Player>();
        enemyMaxHealth = 30;
    }
    public override void Attack1(Player player)
    {
        Debug.Log("Attack1");
        player.TakeDamage(3);
    }

    public override void Attack2(Player player)
    {
        Debug.Log("Attack2");
        player.TakeDamage(7);
        TakeDamage(-2);
    }

    public override void AttackAction()
    {
        float rnd = Random.Range(0f, 1f);
        Debug.Log(rnd);
        if (rnd > 0.65)
        {
            Attack2(player);
        }
        else
        {
            Attack1(player);
        }
    }
}
