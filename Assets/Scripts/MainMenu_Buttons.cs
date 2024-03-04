using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_Buttons : MonoBehaviour
{
    public void LoadScene(string Scenename)
    {
        SceneManager.LoadScene(Scenename);
    }
}
