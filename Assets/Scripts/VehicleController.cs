using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{
    public VehicleBehaviour VehiclePrefab;
    public VehicleBehaviour VehiclePrefab2;
    public Transform LaunchOffset;

    private int VehicleNum = Random.Range(0,1);
    private int SpawnRate = Random.Range(1,6);
    
    void SpawnVehicles()
    {
        if (VehicleNum == 0)
            Instantiate(VehiclePrefab, LaunchOffset.position, transform.rotation);
        else
            Instantiate(VehiclePrefab2, LaunchOffset.position, transform.rotation);
    }

    void Start()
    {
        Invoke("SpawnVehicles", SpawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
