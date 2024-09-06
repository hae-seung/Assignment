using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public bool Dead { get; private set; }
    public Text scoreText;
    public PlayerMovement player;
    public int Score { get; set; }


    private void Update()
    {
        scoreText.text = "Score" + "\n" + Score;
    }

    private void OnEnable()
    {
        Init();
    }

    private void Start()
    {
        Init();
    }
    
    private void Die()
    {
        Dead = true;
        PlayerPrefs.SetInt("Score" , Score);
        SceneManager.LoadScene("GameOver");
    }
    
    
    private void Init()
    {
        Score = 0;
        Dead = false;
        player.onDeath += Die;
    }
}
