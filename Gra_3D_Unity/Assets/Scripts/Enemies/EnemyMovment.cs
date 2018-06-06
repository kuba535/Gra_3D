using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovment : MonoBehaviour
{

    Transform player;               // Reference to the player's position.
    public UnityEngine.AI.NavMeshAgent nav;

    // Use this for initialization
    void Start()
    {
        //Ustaw player jako objekt z tagiem 'Player'
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //Sprawdzanie czy obiekt istnieje, żeby mógł podążać za graczem?
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //Aktualizacja pozycji do której zmierza enemy
        nav.SetDestination(player.position);


    }
}

    

//STARY KOD
/*
 public class EnemyMovement : MonoBehaviour
{
    Transform player;               // Reference to the player's position.
    PlayerHealth playerHealth;      // Reference to the player's health.
    EnemyHealth enemyHealth;        // Reference to this enemy's health.
    UnityEngine.AI.NavMeshAgent nav;               // Reference to the nav mesh agent.


    void Awake()
    {
        // Set up the references.
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerHealth = player.GetComponent();
        enemyHealth = GetComponent();
        nav = GetComponent();
    }


    void Update()
    {
        // If the enemy and the player have health left...
        if (enemyHealth.currentHealth & gt; 0 & amp; &amp; playerHealth.currentHealth & gt; 0)
        {
            // ... set the destination of the nav mesh agent to the player.
            nav.SetDestination(player.position);
        }
        // Otherwise...
        else
        {
            // ... disable the nav mesh agent.
            nav.enabled = false;
        }
    }
}
*/
