using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField]
    private Transform[] spawnPoints;
    [SerializeField]
    private float probabilityOfSpawn = 0.3f;
    [SerializeField]
    private GameObject obstaclePrefab;

    private void Start()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (Random.Range(0f, 1f) < probabilityOfSpawn)
            {
                Instantiate(obstaclePrefab, spawnPoints[i].position, Quaternion.identity, transform);
            }
        }
    }

}
