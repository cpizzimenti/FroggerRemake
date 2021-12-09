using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleBehaviour : MonoBehaviour
{
    public float Speed = 10;
    public float time = 1;

    public int lvl = 1;
    
    void Start()
    {
    }
    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * Speed *lvl;
        time += Time.deltaTime;

        if (time > 8)
        {Destroy(gameObject);}

        if (time % 10 == 0)
        {
            lvl = 20;
        }
    }

    private void OnCollionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
