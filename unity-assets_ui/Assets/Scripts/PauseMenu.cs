using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public UnityEvent<bool> ToggleMenu;
    public UnityEvent<bool> ToggleMenuInverted;

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
        OptionsMenu.lastScene = 4;
        SceneManager.LoadScene(4);
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
        gameObject.SetActive(true);
    }

    public void Resume()
    {
        gameObject.SetActive(false);
    }

}