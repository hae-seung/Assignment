using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text score;
    [SerializeField] private Text bestScore;

    private void Awake()
    {
        if(!PlayerPrefs.HasKey("BestScore"))
            InitBestScore();

        score.text = "Score " + PlayerPrefs.GetInt("Score");

        int tmpScore = PlayerPrefs.GetInt("Score");
        int tmpBest = PlayerPrefs.GetInt("BestScore");
        if (tmpBest < tmpScore)
        {
            PlayerPrefs.SetInt("BestScore", tmpScore);
            bestScore.text = "Best " + tmpScore;
        }
        else
        {
            bestScore.text = "Best " + tmpBest;
        }
    }

    public void onRestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    

    private void InitBestScore()
    {
        PlayerPrefs.SetInt("BestScore", 0);
    }
   
}
