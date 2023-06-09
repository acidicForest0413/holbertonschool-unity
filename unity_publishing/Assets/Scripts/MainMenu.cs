using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    
    public Material trapMat;
    public Material goalMat;
    public Toggle colorblindMode;

    public int MazeScene;
    public void PlayMaze()
    {
        ToggleColorblindMode();
        SceneManager.LoadScene(MazeScene);
    }

    public void QuitMaze()
    {
        Ogg_Helpers.Abort("Quit Game");
    }

    public void ToggleColorblindMode()
    {
        if (colorblindMode.isOn)
        {
            trapMat.color = new Color32(255, 112, 0, 1);
            goalMat.color = Color.blue;
        }
        else
        {
            trapMat.color = Color.red;
            goalMat.color = Color.green;
        }
    }

}