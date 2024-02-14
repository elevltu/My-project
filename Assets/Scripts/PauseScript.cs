using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public static bool isPaused;
    public static GameObject pauseCanvas;
    
    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
        Time.timeScale = 1;
        pauseCanvas = gameObject;
        pauseCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
             if (isPaused && !Timer.currentlyUpgrading)
            {
                pauseCanvas.SetActive(false);
                isPaused = false;
                Time.timeScale = 1;
            }
           
        }
    }
}
