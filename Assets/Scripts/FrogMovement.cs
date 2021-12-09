using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMovement : MonoBehaviour
{
    private Vector2 speedX = new Vector2(1, 0);
    private Vector2 speedY = new Vector2(0, 1);

    public GameObject frog;
    public int level;
    public float frogY;

    public PowerUpController puc;

    void Start()
    {
        puc = GameObject.FindGameObjectWithTag("PCU").GetComponent<PowerUpController>();
    }

    // Update is called once per frame
    void Update()
    {
        frogY = frog.transform.position.y;

        if (frogY >= 5.5)
        {
            level++;
            frog.transform.position = new Vector2(0.5f,-4.5f);
            puc.spawnPowerUp();
        }
        
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
