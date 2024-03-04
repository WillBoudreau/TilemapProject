using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject MainUI;
    public GameObject PauseUI;
    public GameObject WinUI;
    public GameObject GamePlayUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MainMenuUI()
    {
        Cursor.visible = true;
        MainUI.SetActive(true);
        PauseUI.SetActive(false);
        WinUI.SetActive(false);
        GamePlayUI.SetActive(false);
    }
    public void Pause()
    {
        Cursor.visible = true;
        MainUI.SetActive(false);
        PauseUI.SetActive(true);
        WinUI.SetActive(false);
        GamePlayUI.SetActive(false);
    }
    public void Win()
    {
        Cursor.visible = false;
        MainUI.SetActive(false);
        PauseUI.SetActive(false);
        WinUI.SetActive(true);
        GamePlayUI.SetActive(false);
    }
    public void GamePlay()
    {
        Cursor.visible=true;
        MainUI.SetActive(false);
        PauseUI.SetActive(false);
        WinUI.SetActive(false);
        GamePlayUI.SetActive(true);
        SceneManager.LoadScene("Gameplay_Scene");
    }
}