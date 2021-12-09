using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
{
    public GameObject powerUp;
    public VehicleBehaviour car;
    public VehicleBehaviour bus;
    public VehicleBehaviour2 car2;
    public VehicleBehaviour2 bus2;

    private void spawnPowerUp()
    {
        Vector3 powerUpPosition = new Vector3(Random.Range(-10f, 10f), Random.Range(-4.5f, 4.5f), 0f);
        Instantiate(powerUp, powerUpPosition, Quaternion.identity);
    }

    void Start()
    {
        car.Speed = 10;
        car2.Speed = 10;
        bus.Speed = 10;
        bus2.Speed = 10;
        spawnPowerUp();
    }
 
     void OnTriggerEnter2D(Collider2D coli)
    {
        if (coli.gameObject.tag == "Frog")
        {
            car.Speed = car.Speed/2;
            car2.Speed = car2.Speed/2;
            bus.Speed = bus.Speed/2;
            bus2.Speed = bus2.Speed/2;
        }

    }
}

