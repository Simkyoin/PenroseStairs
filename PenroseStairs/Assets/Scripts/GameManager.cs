using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform player;
    public float loopHeight = 5.0f;
    public int currentLoop = 0;
    public int loopsPerStage = 5;
    public int currentStage = 1;
    public TrapSpawner trapSpawner;
    public ItemSpawner itemSpawner;

    void Update()
    {
        if (player.position.y > (currentLoop + 1) * loopHeight)
        {
            currentLoop++;
            if (currentLoop % loopsPerStage == 0)
            {
                IncreaseStageDifficulty();
            }
        }
    }
    void IncreaseStageDifficulty()
    {
        currentStage++;
        trapSpawner.fallSpeed += 2f;
        trapSpawner.spawnInterval = Mathf.Max(0.8f, trapSpawner.spawnInterval - 0.2f);
        itemSpawner.spawnInterval = Mathf.Max(1.5f, itemSpawner.spawnInterval - 0.3f);
    }
}
