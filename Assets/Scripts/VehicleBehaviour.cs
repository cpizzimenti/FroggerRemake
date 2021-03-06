using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleBehaviour : MonoBehaviour
{
    public float Speed = 20;
    public float Level = 1;
    public float time = 0;
    
    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * Speed;
        time += Time.deltaTime;

        if (time > 8)
        {Destroy(gameObject);}
    }

    private void OnCollionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
