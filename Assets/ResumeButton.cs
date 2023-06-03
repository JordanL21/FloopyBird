using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResumeButton : MonoBehaviour
{
    private GameObject pauseGame;

    private void Start()
    {
        // Find the pause screen in the scene
        pauseGame = GameObject.Find("Pause Game Screen");

        // Attach the button click event to the ResumeGame method
        Button button = GetComponent<Button>();
        button.onClick.AddListener(ResumeGame);
    }

    public void ResumeGame()
    {
        // Hide the pause screen
        pauseGame.SetActive(false);

        // Resume the game by setting the timescale to 1
        Time.timeScale = 1f;
    }
}
