using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField] private Player player;
    [SerializeField] private Enemy enemy;
    [SerializeField] private GameObject gameEndScreen;
    [SerializeField] Text ending;


    // Update is called once per frame
    void Update()
    {
        if (player.health <= 0)
        {
            ending.text = "Defeat";
            SetGameEndScreen();
        }

        if (enemy.enemyHealth <= 0)
        {
            ending.text = "Victory?";
            SetGameEndScreen();
        }
    }
    
    public void SetGameEndScreen()
    {
        gameEndScreen.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
