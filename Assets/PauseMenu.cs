using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject menu; // Reference to the menu GameObject

    private bool isPaused = false;

    void Start()
    {
        // Ensure menu is initially disabled
        menu.SetActive(false);
    }

    void Update()
    {
        // Check for input to toggle pause
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0f;
        menu.SetActive(true);
        isPaused = true;
    }

    void ResumeGame()
    {
        Time.timeScale = 1f;
        menu.SetActive(false);
        isPaused = false;
    }
}
