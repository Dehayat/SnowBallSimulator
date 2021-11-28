using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField]
    private Transform[] spawnPoints;
    [SerializeField]
    private float probabilityOfLog = 0.1f;
    [SerializeField]
    private float probabilityOfSpawn = 0.3f;
    [SerializeField]
    private float probabilityOfTree = 0.3f;
    [SerializeField]
    private GameObject obstacleLog;
    [SerializeField]
    private GameObject obstacleRock;
    [SerializeField]
    private GameObject obstacleTree;

    private void Start()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (i == 0 && spawnPoints.Length > 1)
            {
                if (Random.Range(0f, 1f) < probabilityOfLog)
                {
                    Instantiate(obstacleLog, spawnPoints[1].position, Quaternion.identity, transform);
                    break;
                }
            }
            if (Random.Range(0f, 1f) < probabilityOfSpawn)
            {
                if (Random.Range(0f, 1f) < probabilityOfTree)
                {
                    Instantiate(obstacleTree, spawnPoints[i].position, Quaternion.identity, transform);
                }
                else
                {
                    Instantiate(obstacleRock, spawnPoints[i].position, Quaternion.identity, transform);
                }
            }
        }
    }

}
