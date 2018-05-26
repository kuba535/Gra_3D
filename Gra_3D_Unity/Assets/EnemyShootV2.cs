using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootV2 : MonoBehaviour
{
    public GameObject Bullet_Emtter;
    public GameObject Bullet;
    public float Bullet_Forward_Force;
    public float timeBetweenAttacks = 0.5f;

    bool PlayerInRange;

    private Transform player;
    private Animator anim;
    private SphereCollider sCollider;

    float timer;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        anim = GetComponent<Animator>();
        sCollider = GetComponent<SphereCollider>();
        PlayerInRange = false;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInRange = true;
        }
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (PlayerInRange && timer >= timeBetweenAttacks)
        {
            GameObject TemporaryBulletHandler;
            TemporaryBulletHandler = Instantiate(Bullet, Bullet_Emtter.transform.position, Bullet.transform.rotation) as GameObject;

            TemporaryBulletHandler.transform.Rotate(Vector3.left * 90);

            Rigidbody TemporaryRigidBody;
            TemporaryRigidBody = TemporaryBulletHandler.GetComponent<Rigidbody>();

            TemporaryRigidBody.AddForce(transform.forward * Bullet_Forward_Force);

            Destroy(TemporaryBulletHandler, 10.0f);

            timer = 0f;
        }
    }

}

