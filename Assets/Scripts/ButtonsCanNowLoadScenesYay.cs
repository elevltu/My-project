using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsCanNowLoadScenesYay : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    public void LoadScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneName);
    }
}
