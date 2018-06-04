using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_Enemy_Health : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;

    EnemyMovment enemyMovement;

    bool isDead;
    bool damaged;

    void Awake()
    {
        enemyMovement = GetComponent<EnemyMovment>();

        currentHealth = startingHealth;

        isDead = false;
        damaged = false;
    }

    void Update()
    {
        damaged = false;
    }

    public void TakeDamage(int amount)
    {
        damaged = true;

        currentHealth -=amount;

        if(currentHealth <= 0 && !isDead)
        {
            Death();
        }
    }

    void Death()
    {
        Destroy(gameObject);
    }

}
