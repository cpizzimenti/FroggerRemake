using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleBehaviour : MonoBehaviour
{
    public float Speed = 3;
    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * Speed;
    }

    private void OnCollionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
