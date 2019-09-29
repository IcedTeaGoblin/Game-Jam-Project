using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Switcher : MonoBehaviour
{
    public void GotoMainGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void GotoHowToPlayScene()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void GotoMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
