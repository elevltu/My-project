using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float timer;
    private bool upgradeDone;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        upgradeDone = true;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if ((timer%30 >=0 && timer%30 <= 2) && !upgradeDone)
        {
            
            Time.timeScale = 0;
            UpgradeManager.upgradeCanvas.enabled = true;
            upgradeDone = true;

        } else if (upgradeDone && (timer%30 >= 5 && timer%30 <= 7)) {
            upgradeDone = false;
        }
    }
}
