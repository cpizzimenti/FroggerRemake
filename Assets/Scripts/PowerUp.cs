using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PowerUp : MonoBehaviour
{
    public GameObject pickup;

    public VehicleBehaviour car;
    public VehicleBehaviour bus;
    public VehicleBehaviour2 car2;
    public VehicleBehaviour2 bus2;
    
    void OnTriggerEnter2D(Collider2D coli)
    {
        if (coli.gameObject.tag == "Frog")
        {
            car.Speed = car.Speed/2;
            car2.Speed = car2.Speed/2;
            bus.Speed = bus.Speed/2;
            bus2.Speed = bus2.Speed/2;

            Pickup(coli);
        }
    }

    void Pickup(Collider2D plr)
    {
        Instantiate(pickup, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
