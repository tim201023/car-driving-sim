using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene(8);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Authors()
    {
        SceneManager.LoadScene(1);
    }
    public void Description()
    {
        SceneManager.LoadScene(2);
    }
    public void Level()
    {
        SceneManager.LoadScene(3);
    }
    public void Free()
    {
        SceneManager.LoadScene(9);
    }
    

}
