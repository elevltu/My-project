using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public static Canvas upgradeCanvas;
    public static GameObject ownGameObjectForUseElsewhere;
    private void Start()
    {
        upgradeCanvas = GetComponent<Canvas>();
        gameObject.SetActive(false);
        ownGameObjectForUseElsewhere = gameObject;
    }
    public void UpgradeShootSpeed()
    {
        
            PlayerMovement.shotDelay = PlayerMovement.shotDelay * 9 / 10;
            OnUpgrade();
        
    }
    public void UpgradeMovementSpeed()
    {
        
            PlayerMovement.internalSpeed = PlayerMovement.internalSpeed * 11 / 10;
            OnUpgrade();
        
    }
    public void GainOneHealth()
    {
        PlayerMovement.health += 1;
        OnUpgrade();
    }
    private void OnUpgrade()
    {
        
        
            print("triggered");
            print(SpawningScript.enemySpawnDelay);
            SpawningScript.enemySpawnDelay = SpawningScript.enemySpawnDelay * 9 / 10;
            print(SpawningScript.enemySpawnDelay);
            EnemyMovement.internalSpeed = EnemyMovement.internalSpeed * 11 / 10;
            Time.timeScale = 1;
        PauseScript.isPaused = false;
        Timer.currentlyUpgrading = false;
        gameObject.SetActive(false);
        
    }
}
