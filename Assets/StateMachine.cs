using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StateMachine : MonoBehaviour
{
    Animator anim;
    NavMeshAgent agent;
    public Transform target;

    
   public enum STATE { IDLE,WALK,ATTACK,DAMAGE};
   public STATE state;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        state = STATE.IDLE;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case STATE.IDLE:
                Idle();
                break;
            case STATE.WALK:
                Walk();
                break;
            case STATE.ATTACK:
                Attack();
                break;
            case STATE.DAMAGE:
                Damage();
                break;
            default:
                break;
        }
    }

    private void Damage()
    {
       
    }

    private void Attack()
    {
        agent.stoppingDistance = 5f;
        anim.SetBool("Walk", false);
        anim.SetBool("Attack", true);

    }

    private void Walk()
    {
        anim.SetBool("Attack", false);
        anim.SetBool("Walk", true);
        //anim.SetBool("Attack", false);
        if(Vector3.Distance(target.position,this.transform.position)<=10f)
        {
           
            state = STATE.ATTACK;
        }
      
    }

    private void Idle()
    {
        state = STATE.WALK;
    }
}
