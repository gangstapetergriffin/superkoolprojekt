using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ClickSingleplayer()
    {
        SceneManager.LoadScene(2);
    }
    public void ClickMultiplayer()
    {
        SceneManager.LoadScene(1);
    }
    public void ClickFastMode()
    {
        SceneManager.LoadScene(3);
    }
}
