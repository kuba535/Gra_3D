using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    public int Damage = 10;

    GameObject enemy;
    New_Enemy_Health enemyHealth;
    
    void Awake()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        enemyHealth = enemy.GetComponent<New_Enemy_Health>();
    }

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Enemy")
        {
            Attack();
        }
        if(other.gameObject.tag != "Player" )
        {

        }
    }

    void Attack()
    {
        if (enemyHealth.currentHealth > 0)
        {
            enemyHealth.TakeDamage(Damage);
        }

    }
}
