using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest : MonoBehaviour
{
    [Range(0, 5)]
    public float speed = 0;

    private Animator anim;
    private HashIDs hash;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        hash = GameObject.FindGameObjectWithTag("GameController").GetComponent<HashIDs>();
    }

    private void FixedUpdate()
    {
        MovementManager(speed);  
    }

    void MovementManager(float speed)
    {
        if(speed > 0)
        {
            anim.SetFloat(hash.enemySpeed, speed);
        }
    }


}
