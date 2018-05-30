/*using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	private float timer = 0.0f;

	void Update() {
		timer += Time.deltaTime;
		if(timer > 4.0f) {
			Destroy(gameObject);
		}
	}

}
*/
using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

<<<<<<< HEAD


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
        if (other.gameObject.tag != "Player")
        {
            Destroy(gameObject);
        }
    }

    void Attack()
    {
        if (enemyHealth.currentHealth > 0)
        {
            enemyHealth.TakeDamage(Damage);
        }

        Destroy(gameObject);
    }
}
=======
	private float timer = 0.0f;

	void Update() {
		timer += Time.deltaTime;
		if(timer > 4.0f) {
			Destroy(gameObject);
		}
	}

}
>>>>>>> parent of 067e90b... Merge branch 'master' of https://github.com/kuba535/Gra_3D
