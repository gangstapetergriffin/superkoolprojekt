using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ClickSingleplayer() // checks if the singleplayer button is pushed
    {
        SceneManager.LoadScene(2); // loads the singleplayer scene
    }
    public void ClickMultiplayer()// checks if the Multiplayer button is pushed
    {
        SceneManager.LoadScene(1); // loads the multiplayer scene
    }
    public void ClickFastMode()// checks if the fastmode button is pushed
    {
        SceneManager.LoadScene(3); // loads the fastmode scene
    }
}
