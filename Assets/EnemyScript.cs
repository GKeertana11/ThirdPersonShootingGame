using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField]
    int startingHealth;
    [SerializeField]
    int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startingHealth; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Damage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if(currentHealth<=0)
        {
            Death();
            Debug.Log(currentHealth);
        }
    }
    public void Death()
    {
        gameObject.SetActive(false);
    }
}
