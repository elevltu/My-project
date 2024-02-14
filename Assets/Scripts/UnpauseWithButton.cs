using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnpauseWithButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void UnpauseGamePlsShowUp()
    {
        PauseScript.pauseCanvas.SetActive(false);
        PauseScript.isPaused = false;
        Time.timeScale = 1;
    }
}
