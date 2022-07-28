using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
   public void ChangeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
    public void ApplicationQuit()
    {
        Application.Quit();
    }
}
