using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    public int Damage = 10;

    New_Enemy_Health enemyHealth;
    
    void Awake()
    {

    }

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Enemy")
        {
            enemyHealth = other.gameObject.GetComponent<New_Enemy_Health>();
            Attack();
        }
        if(other.gameObject.tag != "Player" )
        {
            if(other.gameObject.tag != "Bullet")
            {
                Destroy(gameObject);
            }
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
