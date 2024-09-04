using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private GameObject score;
    
    public void onRestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameOverUI.SetActive(false);
        Time.timeScale = 1;
    }

    public void ActiveGameOverPanel()
    {
        gameOverUI.SetActive(true);
    }

    public void UpdateScore(int newScore)
    {
        Text text = score.GetComponent<Text>();
        text.text = "Score" + "\n" + newScore;
    }

   
}
