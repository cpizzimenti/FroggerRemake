using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{

    public GameObject vehicle;
    public GameObject vehicle2;
    public float car;
    public float randomtime;


    void pickVehicle()
    {

        if (car == 0)
        {
            GameObject clone = GameObject.Instantiate(vehicle);
            clone.transform.position = transform.position;
        }
        else if (car == 2)
        {
            GameObject clone2 = GameObject.Instantiate(vehicle2);
            clone2.transform.position = transform.position;}
    }

    void spawnVehicle()
    {
        pickVehicle();
        Invoke("spawnVehicle", randomtime);
    }
    void Start()
    {
        Invoke("spawnVehicle", 0.1f);
    }

    void Update()
    {
        randomtime = Random.Range(2, 8);
        car = 2 % Random.Range(1, 10);
    }
}


