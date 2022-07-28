using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
    }
    void Update()
    {
        OldMovement(); 
    }

    void NewMovement()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertial");
        Vector2 move = new Vector2(xAxis, yAxis);

        move *= speed * Time.deltaTime;

        transform.position += (Vector3) move;
    }


    // Update is called once per frame
    void OldMovement()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Vector2 playerPosition = transform.position;
            playerPosition.x += speed * Time.deltaTime;
            transform.position = playerPosition;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Vector2 playerPosition = transform.position;
            playerPosition.x -= speed * Time.deltaTime;
            transform.position = playerPosition;
        }

        if (Input.GetKey(KeyCode.W))
        {
            Vector2 playerPosition = transform.position;
            playerPosition.y += speed * Time.deltaTime;
            transform.position = playerPosition;
        }

        if (Input.GetKey(KeyCode.S))
        {
            Vector2 playerPosition = transform.position;
            playerPosition.y -= speed * Time.deltaTime;
            transform.position = playerPosition;
        }

    }

}
