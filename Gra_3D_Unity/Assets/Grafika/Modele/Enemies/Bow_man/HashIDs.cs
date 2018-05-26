using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashIDs : MonoBehaviour
{
    [HideInInspector]
    public int enemySpeed,
               isShooting;
            

    private void Awake()
    {
        enemySpeed = Animator.StringToHash("EnemySpeed");
        isShooting = Animator.StringToHash("IsShooting");
    }
}
