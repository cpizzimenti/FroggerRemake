using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class froghit : MonoBehaviour
{

    public GameObject explosionEffect;

    private void OnTriggerEnter(Collider other)
    {
        Vector3 particleSpawnPoint = other.transform.position;
        Instantiate(explosionEffect, particleSpawnPoint, Quaternion.identity);
        //Destroy() is base func for destroying components and objevts in a scene
        //you need ot specify that you are refering to a game object
        //Destroy(this) will destroy the component not the object
        Destroy(this.gameObject);//wil destry th eobject where this compnonet is
        //Destroy(other.gameObject);
    }
}
