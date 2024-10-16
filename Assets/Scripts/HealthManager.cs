using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 


public class HealthManager : MonoBehaviour
{
    public PointManager pointManager;
    public int playerHealth = 5;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI gameOverText;

    private bool gameIsOver = false;

    void Start()
    {
        UpdateHealthUI(); 
        gameOverText.gameObject.SetActive(false);
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
    }

    // reduce player health by 1
    public void TakeDamage()
    {
        playerHealth--;
        UpdateHealthUI();

        if (playerHealth <= 0)
        {
            Debug.Log("Game Over! Player is out of lives.");
            GameOver();
        }
    }

    void UpdateHealthUI()
    {
        healthText.text = "" + playerHealth;
    }

    void GameOver()
    {
        gameIsOver = true;
        gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0f; 
        pointManager.ShowFinalText();
    }

    void Update()
    {
        if (gameIsOver && Input.GetKeyDown(KeyCode.R)) 
        {
            RestartGame();
        }
    }

    void RestartGame()
    {
        Time.timeScale = 1f;  
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}

