using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class New_Enemy_Health : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;

    EnemyMovment enemyMovement;

    bool isDead;
    bool damaged;

    [Header("Unity Stuff")]
    public Image healthBar;


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
        healthBar.fillAmount = currentHealth / 100f;

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
