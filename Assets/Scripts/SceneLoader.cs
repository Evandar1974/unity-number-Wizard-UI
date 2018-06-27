using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene(string scene)
    {

        SceneManager.LoadScene(scene);
    }

    public void QuitRequest()
    {
        Debug.Log("Quit Button Pressed");
        Application.Quit();
    }
}
