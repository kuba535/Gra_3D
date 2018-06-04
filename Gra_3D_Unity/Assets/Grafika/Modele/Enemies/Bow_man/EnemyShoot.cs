using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject Bullet_Emtter;
    public GameObject Bullet;
    public float Bullet_Forward_Force;

    bool PlayerInRange;

    private NavMeshAgent nav;
    private Transform player;
    private Animator anim;
    private SphereCollider sCollider;
    private HashIDs hash;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        anim = GetComponent<Animator>();
        sCollider = GetComponent<SphereCollider>();
        PlayerInRange = false;
        nav = GetComponent<NavMeshAgent>();
    }

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "player")
        {
            PlayerInRange = true;
        }
    }

    void Update()
    {
        if(PlayerInRange == true && anim.GetFloat(hash.enemySpeed) == 0f && nav.speed == 0f)
        {
            anim.SetBool("IsShooting", true);

            GameObject TemporaryBulletHandler;
            TemporaryBulletHandler = Instantiate(Bullet, Bullet_Emtter.transform.position, Bullet.transform.rotation) as GameObject;

            TemporaryBulletHandler.transform.Rotate(Vector3.left * 90);

            Rigidbody TemporaryRigidBody;
            TemporaryRigidBody = TemporaryBulletHandler.GetComponent<Rigidbody>();

            TemporaryRigidBody.AddForce(transform.forward * Bullet_Forward_Force);

            Destroy(TemporaryBulletHandler, 10.0f);
        }
    }

}
