using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    public int points = 0;
    public TextMeshProUGUI pointsText;
    public TextMeshProUGUI FinalScoreText;

    void Start()
    {
        UpdatePointsUI(); 
        FinalScoreText.gameObject.SetActive(false);
    }

    // reduce player health by 1
    public void GetPoints()
    {
        points++;
        UpdatePointsUI();
    }

    void UpdatePointsUI()
    {
        pointsText.text = "Points: " + points;
        FinalScoreText.text = "Final score: " + points + " points";
    }

    public void ShowFinalText()
    {
        FinalScoreText.gameObject.SetActive(true);
    }
}

