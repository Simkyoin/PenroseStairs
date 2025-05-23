using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSpawner : MonoBehaviour
{
    public GameObject trapPrefab;
    public float spawnInterval = 2f;
    public float fallSpeed = 8f;
    public Transform[] spawnPoints;
    void Start()
    {
        InvokeRepeating(nameof(SpawnTrap), 0f, spawnInterval); 
    }
    void SpawnTrap()
    {
        Transform point = spawnPoints[Random.Range(0, spawnPoints.Length)];
        GameObject trap = Instantiate(trapPrefab, point.position, Quaternion.identity);
        trap.GetComponent<FallingTrap>().speed = fallSpeed;
    }
}