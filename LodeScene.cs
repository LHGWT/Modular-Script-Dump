using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class LodeScene : MonoBehaviour
{
    public string sceneName;
    public void ChangeSceneByName()
    {
        SceneManager.LoadScene(sceneName);
    }
}
