using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public static float timer;
    private bool upgradeDone;
    public static bool currentlyUpgrading;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        upgradeDone = true;
        currentlyUpgrading = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if ((timer%30 >=0 && timer%30 <= 2) && !upgradeDone)
        {
            
            Time.timeScale = 0;
            UpgradeManager.ownGameObjectForUseElsewhere.SetActive(true);
            PauseScript.isPaused = true;
            upgradeDone = true;
            currentlyUpgrading = true;

        } else if (upgradeDone && (timer%30 >= 5 && timer%30 <= 7)) {
            upgradeDone = false;
        }
    }
}
