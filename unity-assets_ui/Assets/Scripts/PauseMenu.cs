using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public UnityEvent<bool> ToggleMenu;
    public UnityEvent<bool> ToggleMenuInverted;
    private bool isPaused = false;
    public GameObject pauseCanvas;

    public void OnEnable()
    {
        ToggleMenuInverted.Invoke(false);
        ToggleMenu.Invoke(true);
    }

    public void OnDisable()
    {
        ToggleMenuInverted.Invoke(true);
        ToggleMenu.Invoke(false);
    }

    public void MainMenu()
    {
        OptionsMenu.lastScene = 0;
        SceneManager.LoadScene(3);
    }

    public void Options()
    {
        OptionsMenu.lastScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(4);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Pause()
    {
        pauseCanvas.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Resume()
    {
        pauseCanvas.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    } 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
}