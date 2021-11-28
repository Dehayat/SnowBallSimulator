using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField]
    private Transform parent;
    [SerializeField]
    private bool follow = true;

    private Vector3 initOffset;

    private void Start()
    {
        initOffset = transform.position - parent.position;
    }

    void Update()
    {
        if (follow)
        {
            Vector3 newPosition = transform.position;
            newPosition = parent.position + initOffset;
            newPosition.y = transform.position.y;
            transform.position = newPosition;
        }
    }
}
