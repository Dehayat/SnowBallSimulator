using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BKGScript : MonoBehaviour
{
    [SerializeField]
    float BKGMovingUp = 0.5f;
    [SerializeField]
    float BKGMovingLeft = 0.5f;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(BKGMovingLeft * Time.deltaTime,0,-BKGMovingUp * Time.deltaTime);
    }
}
