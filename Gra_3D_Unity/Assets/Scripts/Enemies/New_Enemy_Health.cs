using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class New_Enemy_Health : MonoBehaviour
{
    public int startingHealth = 50;
    public int currentHealth;

    public float sinkSpeed = 2.5f;
    public int scoreValue = 10;

    Animator anim;
    EnemyMovment enemyMovement;
    CapsuleCollider capsuleCollider;

    bool isSinking;
    bool isDead;
    bool damaged;

    [Header("Unity Stuff")]
    public Image healthBar;
    public Image healthBarBG;
    public float healthBar_factor;
    public float f_currenthealth;
    public float f_startinghealth;


    void Awake()
    {
        enemyMovement = GetComponent<EnemyMovment>();
        anim = GetComponent<Animator>();
        capsuleCollider = GetComponent<CapsuleCollider>();

        currentHealth = startingHealth;
        f_startinghealth = startingHealth;

        isDead = false;
        damaged = false;
        isSinking = false;
    }


    void Update()
    {
        if (isSinking)
        {
            transform.Translate(-Vector3.up * sinkSpeed * Time.deltaTime);
        }
        damaged = false;
        
    }

    public void TakeDamage(int amount)
    {
        if (isDead)
            return;

        damaged = true;

        currentHealth -=amount;
        f_currenthealth = currentHealth;
        healthBar_factor = f_currenthealth / f_startinghealth;
        
        healthBar.fillAmount = healthBar_factor;

        if (currentHealth <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        isDead = true;

        capsuleCollider.isTrigger = true;

        ScoreManager.score += scoreValue;
        Destroy(healthBarBG.gameObject);

        anim.SetTrigger("Die");
    }

    public void StartSinking()
    {
        GetComponent<NavMeshAgent>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        isSinking = true;

        Destroy(gameObject, 2f);
    }

}
