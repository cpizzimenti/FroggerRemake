using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PowerUp : MonoBehaviour
{
    public GameObject pickup;

    
    void OnTriggerEnter2D(Collider2D coli)
    {
        if (coli.gameObject.tag == "Frog")
        {
            Pickup(coli);
        }

    }
 
    void Pickup(Collider2D plr)
    {
        Instantiate(pickup, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
