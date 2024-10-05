using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverMenu : MonoBehaviour
{
    public string sceneName;
    public int lvl;


    void Start()
    {
    
    }
    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void GoToLevel(int lvl)
    {
        MissionDemolition.SetLevel(lvl);
    }

    public void QuitApp()
    {
        Application.Quit();
        Debug.LogWarning("Application has quit.");
    }
}