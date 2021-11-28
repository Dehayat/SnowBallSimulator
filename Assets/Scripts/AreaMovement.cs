using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaMovement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;
    [SerializeField]
    private Transform groundTransform;


    private Vector3 moveDirection;

    void Start()
    {
        moveDirection = -groundTransform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
