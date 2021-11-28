using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float horizontalSpeed = 5f;
    [SerializeField]
    private ParticleSystem snowTrail;
    [Header("Jump Parameters")]
    [SerializeField]
    private float groundY = 0f;
    [SerializeField]
    private float maxHeight = 3f;
    [SerializeField]
    private float timeToMaxHeight = 0.6f;

    private bool isOnTheGround = true;
    private bool isJumping = false;

    private float verticalVelocity = 0f;
    private float gravity = 0f;

    void Update()
    {
        //Normal Movement
        if (isOnTheGround)
        {
            float moveX = -Input.GetAxis("Vertical");
            transform.Translate(Vector3.right * moveX * horizontalSpeed * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isJumping = true;
                verticalVelocity = 2 * maxHeight / timeToMaxHeight;
                gravity = -2 * maxHeight / (timeToMaxHeight * timeToMaxHeight);
                snowTrail.Stop();
            }
        }

        //Check if wants to keep jumping
        if (!Input.GetKey(KeyCode.Space) && isJumping)
        {
            if (verticalVelocity > 0f)
            {
                verticalVelocity = 0.0f;
            }
        }

        //Calculate Jumping
        if (isJumping)
        {
            isOnTheGround = false;
            Vector3 position = transform.position;
            verticalVelocity += gravity * Time.deltaTime;
            position.y += verticalVelocity * Time.deltaTime;
            if (verticalVelocity < 0f)
            {
                if (position.y <= groundY)
                {
                    position.y = groundY;
                    verticalVelocity = 0;
                    gravity = 0;
                    isJumping = false;
                    isOnTheGround = true;
                    snowTrail.Play();
                }
            }
            transform.position = position;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            //Debug.LogError("You Lose");
            SceneManager.LoadScene(0);
        }
    }
}
