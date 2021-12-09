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
    public int num;
    
    void OnTriggerEnter2D(Collider2D coli)
    {
        if (coli.gameObject.tag == "Frog")
        {
            car.Speed = car.Speed/1.5f;
            car2.Speed = car2.Speed/1.5f;
            bus.Speed = bus.Speed/1.5f;
            bus2.Speed = bus2.Speed/1.5f;
            num = num +1;
            Instantiate(pickup, transform.position, transform.rotation);
            Destroy(gameObject);
            print(num);
        }
    }
}
