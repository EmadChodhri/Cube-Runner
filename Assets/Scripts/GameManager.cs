using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject LevelCompletePanel;
    public GameObject gameOverPanel;
    bool gameOver = false;
    float restartDelay=1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameOver()
    {
        if (!gameOver)
        {
            gameOverPanel.SetActive(true);
            gameOver = true;
            Debug.Log("You lose");
           // Invoke("Restart", restartDelay);
        }
        
    }

    public void LevelComplete()
    {
        LevelCompletePanel.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
