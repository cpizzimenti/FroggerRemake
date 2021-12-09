using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleBehaviour : MonoBehaviour
{
    public float Speed = 10;
    public float time = 0;

    public FrogMovement lvl;
    
    void Start()
    {
        lvl = GameObject.FindGameObjectWithTag("Frog").GetComponent<FrogMovement>();
    }
    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * Speed *lvl.level;
        time += Time.deltaTime;

        if (time > 8)
        {Destroy(gameObject);}
    }

    private void OnCollionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
