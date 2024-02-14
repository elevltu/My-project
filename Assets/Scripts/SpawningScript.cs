using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class SpawningScript : MonoBehaviour
{
    private int screenWidth;
    private int screenHeight;
    private int screenRatio;
    private bool canSpawn;
    public GameObject enemy;
    public static int enemySpawnDelay;
    // Start is called before the first frame update
    void Start()
    {
        screenWidth = Screen.width;
        screenHeight = Screen.height;
        screenRatio= Screen.width / Screen.height;
        canSpawn = true;
        enemySpawnDelay = 5000;
    }

    // Update is called once per frame
    void Update()
    {
        if (canSpawn && !PauseScript.isPaused)
        {
            Instantiate(enemy);
            canSpawn = false;
            SpawnDelay();

        }
    }
    async void SpawnDelay()
    {
        await Task.Delay(enemySpawnDelay);
        canSpawn = true;
    }
}
