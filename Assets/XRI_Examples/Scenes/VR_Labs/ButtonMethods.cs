using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonMethods : MonoBehaviour
{
    public void ExitGame()
    {
        Application.Quit();
    }
    public void LoadScene(int numberScene)
    {
        SceneManager.LoadScene(numberScene);
    }
}
