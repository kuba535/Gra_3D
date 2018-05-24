using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SkillFriendFollowEnemy : MonoBehaviour
{

    Transform enemy;               // Reference to the player's position.
    public UnityEngine.AI.NavMeshAgent nav;

    // Use this for initialization
    void Start()
    {
        //Ustaw player jako objekt z tagiem 'Player'
        enemy = GameObject.FindGameObjectWithTag("Enemy").transform;
        //Sprawdzanie czy obiekt istnieje, żeby mógł podążać za graczem?
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        //Aktualizacja pozycji do której zmierza enemy
        nav.SetDestination(enemy.position);


    }
}