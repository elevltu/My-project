using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerInfoScript : MonoBehaviour
{
    public TextMeshProUGUI health;
    public TextMeshProUGUI timer;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer.timer % 60 < 10)
        {
            timer.text = ((int)(Timer.timer / 60) + ":0" + (int)(Timer.timer % 60));
        }
        else
        {
            timer.text = ((int)(Timer.timer / 60) + ":" + (int)(Timer.timer % 60));
        }

        health.text = PlayerMovement.health.ToString();
    }
}
