using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    [SerializeField]
    int startingHealth;
    [SerializeField]
    int currentHealth;
    NavMeshAgent Agent;
    public GameObject player;
    public ParticleSystem particle;
    public ParticleSystem deathEffect;

    

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startingHealth;
        Agent = GetComponent<NavMeshAgent>();
       
    }

    // Update is called once per frame
    void Update()
    {

        Agent.SetDestination(player.transform.position);
        Agent.stoppingDistance = 5f;
    }
    public void Damage(int damageAmount)
    {
        particle.Play();
        currentHealth -= damageAmount;

        if(currentHealth<=0)
        {
            deathEffect.Play();
            Death();
            Debug.Log(currentHealth);
        }
    }
    public void Death()
    {
        gameObject.SetActive(false);
      }

  
}
