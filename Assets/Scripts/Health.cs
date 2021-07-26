using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 200;
    [SerializeField] GameObject deathVFX;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void DealDamage(int damage)
    {
        health = health - damage;
        if(health <= 0)
        {
            TriggerDeathVFX();
            Destroy(gameObject);
        }
    }

    private void TriggerDeathVFX()
    {
        if (!deathVFX) { return; }
        GameObject objectVFX = Instantiate(deathVFX, transform.position, transform.rotation);
        Destroy(objectVFX, 1f);
    }
}
