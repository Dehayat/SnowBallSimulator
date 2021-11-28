using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaGenerator : MonoBehaviour
{
    [SerializeField]
    private Transform startPosition;
    [SerializeField]
    private GameObject areaPrefab;
    [SerializeField]
    private float areaLength = 10f;
    [SerializeField]
    private int areaCount = 10;

    private void Start()
    {
        Vector3 currentPosition = startPosition.position;
        for(int i = 0; i < areaCount; i++)
        {
            Instantiate(areaPrefab, currentPosition, Quaternion.identity);
            currentPosition.z += areaLength;
        }
    }

}
