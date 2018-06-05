using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class New_Enemy_Health : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;

    public float sinkSpeed = 2.5f;
    public int scoreValue = 10;

    Animator anim;
    EnemyMovment enemyMovement;
    CapsuleCollider capsuleCollider;

    bool isSinking;
    bool isDead;
    bool damaged;

    void Awake()
    {
        enemyMovement = GetComponent<EnemyMovment>();
        anim = GetComponent<Animator>();
        capsuleCollider = GetComponent<CapsuleCollider>();

        currentHealth = startingHealth;

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

        if(currentHealth <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        isDead = true;

        capsuleCollider.isTrigger = true;

        ScoreManager.score += scoreValue;

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
