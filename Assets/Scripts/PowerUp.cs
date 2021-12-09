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
            Pickup(coli);
            car.Speed--;
            car2.Speed--;
            bus.Speed--;
            bus2.Speed--;
        }

    }
 
    void Pickup(Collider2D plr)
    {
        Instantiate(pickup, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
