using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private GameObject score;
    [SerializeField] private GameObject bestScore;

    private void Awake()
    {
        if(!PlayerPrefs.HasKey("BestScore"))
            InitBestScore();
    }

    public void onRestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameOverUI.SetActive(false);
        Time.timeScale = 1;
    }

    public void ActiveGameOverPanel(int newScore)
    {
        gameOverUI.SetActive(true);
    
        int score = PlayerPrefs.GetInt("BestScore");
    
        if (newScore > score)
        {
            score = newScore;
            PlayerPrefs.SetInt("BestScore", score);  // 새로운 최고 점수를 저장
        }

        Text text = bestScore.GetComponent<Text>();
        text.text = "BestScore" + "\n" + score;
    }

    
    public void UpdateScore(int newScore)
    {
        Text text = score.GetComponent<Text>();
        text.text = "Score" + "\n" + newScore;
    }

    private void InitBestScore()
    {
        PlayerPrefs.SetInt("BestScore", 0);
    }
   
}
