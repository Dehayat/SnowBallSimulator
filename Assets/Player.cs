using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float horizontalSpeed = 5f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * moveX * horizontalSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.LogError("You Lose");
    }
}
