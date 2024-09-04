using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class GameManager : Singleton<GameManager>
{
    public bool Dead { get; private set; }
    public PlayerMovement player;
    public UIManager uiManager;
    public int Score { get; set; }


    private void Update()
    {
        uiManager.UpdateScore(Score);
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
        Time.timeScale = 0;
        uiManager.ActiveGameOverPanel();
    }


    private void Init()
    {
        Score = 0;
        Dead = false;
        player.onDeath += Die;
    }
}
