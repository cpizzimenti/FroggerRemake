using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMovement : MonoBehaviour
{
    private Vector2 speedX = new Vector2(1, 0);
    private Vector2 speedY = new Vector2(0, 1);

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left"))
        {
            GetComponent<Rigidbody2D>().MovePosition(GetComponent<Rigidbody2D>().position - speedX);
        }
        else if (Input.GetKeyDown("right"))
        {
            GetComponent<Rigidbody2D>().MovePosition(GetComponent<Rigidbody2D>().position + speedX);
        }
        else if (Input.GetKeyDown("up"))
        {
            GetComponent<Rigidbody2D>().MovePosition(GetComponent<Rigidbody2D>().position + speedY);
        }
        else if (Input.GetKeyDown("down"))
        {
            GetComponent<Rigidbody2D>().MovePosition(GetComponent<Rigidbody2D>().position - speedY);
        }
    }
}
