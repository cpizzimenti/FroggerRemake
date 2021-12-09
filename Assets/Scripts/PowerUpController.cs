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

    public void spawnPowerUp()
    {
        Vector3 powerUpPosition = new Vector3(Random.Range(-10f, 10f), Random.Range(-4.5f, 4.5f), 0f);
        Instantiate(powerUp, powerUpPosition, Quaternion.identity);
    }

    void Start()
    {
        car.Speed = 30;
        car2.Speed = 30;
        bus.Speed = 30;
        bus2.Speed = 30;
        spawnPowerUp();
    }
}

