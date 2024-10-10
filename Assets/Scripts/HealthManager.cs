using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public int playerHealth = 3;
    public TextMeshProUGUI healthText;

    void Start()
    {
        UpdateHealthUI(); 
    }

    // reduce player health by 1
    public void TakeDamage()
    {
        playerHealth--;
        UpdateHealthUI();

        if (playerHealth <= 0)
        {
            Debug.Log("Game Over! Player is out of lives.");
        }
    }

    // Method to update the health UI
    void UpdateHealthUI()
    {
        healthText.text = "Lives: " + playerHealth;
    }
}
