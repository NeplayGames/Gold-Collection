using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] GameObject settingPanel;
    bool showSetting = false;


    ///<summary>
    ///Replay the current level of the game
    ///</summary>

    public void ReplayLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    ///Start the game
     public void StartGame()
    {
        SceneManager.LoadScene("level");
    }

    ///Go to main menu
    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ShowSetting();
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    ///Show the setting cavas
    public void ShowSetting()
    {
        showSetting = !showSetting;
        Time.timeScale = showSetting ? 0 : 1;
        settingPanel.SetActive(showSetting);
    }
}
