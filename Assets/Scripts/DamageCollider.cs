using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.GetComponent<Attacker>())
        {
            FindObjectOfType<LivesDisplay>().DealDamage();
            Destroy(otherCollider.gameObject);
        }
    }
}
