using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject itemPrefab;
    public float spawnInterval = 5f;
    public Transform[] spawnPoints;
    
    void Start()
    {
        InvokeRepeating(nameof(SpawnItem), 2f, spawnInterval); 
    }
    void SpawnItem()
    {
        Transform point = spawnPoints[Random.Range(0, spawnPoints.Length)];
        Instantiate(itemPrefab, point.position, Quaternion.identity);
    }
}
