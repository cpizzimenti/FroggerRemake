using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController2 : MonoBehaviour
{
    public GameObject[] spawnees;
    public GameObject[] spawnPoints;
    Vector3 randomVec;

    int randomInt;
    int randomInt2;

    void Start(){
        spawnPoints = GameObject.FindGameObjectsWithTag("-Spawner");
        InvokeRepeating("SpawnRandom", 0, Random.Range(2,10));
    }

    void Update(){
    }

    int GetRandom(int count){
        return Random.Range(0, count);
    }

    Vector3 GetRandomVector(Vector3 vec) {
        return vec;
    }
    void SpawnRandom() {
        randomInt = GetRandom(spawnees.Length);
        randomInt2 = GetRandom(spawnPoints.Length);
        randomVec = GetRandomVector(spawnPoints[randomInt2].transform.position);
        Instantiate(spawnees[randomInt], randomVec, spawnPoints[randomInt2].transform.rotation);
    }
}
