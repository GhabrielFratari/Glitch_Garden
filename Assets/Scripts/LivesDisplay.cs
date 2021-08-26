using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LivesDisplay : MonoBehaviour
{
    [SerializeField] int health = 500;
    Text healthText;

    private void Start()
    {
        healthText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        healthText.text = health.ToString();
    }

    public void DealDamage()
    {
        health-= 100;
        UpdateDisplay();
        if (health <= 0)
        {
            FindObjectOfType<LevelController>().YouLose();
        }
    }
}
