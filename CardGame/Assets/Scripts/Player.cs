using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health;
    protected int maxHealth = 50;

    public PlayerHealthBar playerHealthBar;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        playerHealthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        playerHealthBar.SetHealth(health);
    }
}
