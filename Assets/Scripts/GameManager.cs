using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum GameScenes { MainMenu, PauseMenu , GameOver , Win, Gameplay};

    public GameScenes gameScenes;
    public UIManager uiManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(gameScenes)
        {
            case GameScenes.MainMenu:
                MainMenu();
                break;
            case GameScenes.PauseMenu:
                Pause();
                break;
            case GameScenes.Win:
                Win();
                break;
            case GameScenes.Gameplay:
                GamePlay();
                break;
        }
    }
    public void MainMenu()
    {
        uiManager.MainMenuUI();
    }
    public void Pause()
    {
        uiManager.Pause();
    }
    public void Win()
    {
        uiManager.Win();
    }
    public void GamePlay()
    {
        uiManager.GamePlay();
    }
}
