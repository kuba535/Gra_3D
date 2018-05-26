using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public int Damage = 10;

    GameObject player;
    PlayerHealth playerHealth;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            Attack();
        }
        if(other.gameObject.tag != "Enemy")
        {
            Destroy(gameObject);
        }
    }

    void Attack()
    {
        if(playerHealth.currentHealth > 0)
        {
            playerHealth.TakeDamage(Damage);
        }
        Destroy(gameObject);
    }
}

