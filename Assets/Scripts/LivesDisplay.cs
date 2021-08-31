using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LivesDisplay : MonoBehaviour
{
    [SerializeField] float baseLives = 3;
    [SerializeField] int damage = 1;
    float lives;
    Text healthText;

    private void Start()
    {
        lives = baseLives - PlayerPrefsController.GetMasterDifficulty();
        healthText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        healthText.text = lives.ToString();
    }

    public void DealDamage()
    {
        lives -= damage;
        UpdateDisplay();
        if (lives <= 0)
        {
            FindObjectOfType<LevelController>().YouLose();
        }
    }
}
