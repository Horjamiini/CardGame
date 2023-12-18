using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public EnemyHealthBar enemyHealthBar;
    public Player player;
    
    public int enemyHealth;
    protected int enemyMaxHealth;


    void Start()
    {
         
        enemyHealth = enemyMaxHealth;
        enemyHealthBar.SetMaxHealth(enemyMaxHealth);
    }

    public void TakeDamage(int damage)
    {
        enemyHealth -= damage;
        enemyHealthBar.SetHealth(enemyHealth);
    }

    public abstract void Attack1(Player player);

    public abstract void Attack2(Player player);

    public abstract void AttackAction();
}
