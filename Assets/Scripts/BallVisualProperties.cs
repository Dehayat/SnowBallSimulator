using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallVisualProperties : MonoBehaviour
{
    [SerializeField]
    float RotationSpeed = 5f;
    int Size;
    int BallID;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, RotationSpeed , 0 * Time.deltaTime);
    }
}
