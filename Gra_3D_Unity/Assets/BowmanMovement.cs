using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class BowmanMovement : MonoBehaviour
{
    private NavMeshAgent nav;
    private Transform player;
    private Animator anim;
    private HashIDs hash;
    private SphereCollider sCollider;
    private bool PlayerInRange;


    void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        sCollider = GetComponent<SphereCollider>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        hash = GameObject.FindGameObjectWithTag("GameController").GetComponent<HashIDs>();
        PlayerInRange = false;
    }

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            StopAnimation();
            PlayerInRange = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        PlayerInRange = false;
    }

    void Update()
    {
    if(PlayerInRange == false)
        {
            MovementManager();
        }
    }

    void StopAnimation()
    {
        anim.SetFloat(hash.enemySpeed, 0f);
        nav.speed = 0f;
    }

    void MovementManager()
    {
        nav.SetDestination(player.position);
        anim.SetFloat(hash.enemySpeed, 1.25f);
        nav.speed = anim.GetFloat(hash.enemySpeed);       
    }

}

