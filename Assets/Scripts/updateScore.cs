using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateScore : MonoBehaviour
{

    public Text scoreText;
    public FrogMovement level;
    //public PowerUp powerups;
    public int score;

    void Start()
    {
        //powerups = GameObject.FindGameObjectWithTag("PowerUp").GetComponent<PowerUp>();
        level = GameObject.FindGameObjectWithTag("Frog").GetComponent<FrogMovement>();
    }
    void Update()
    {
        scoreText.text = (level.level * 500).ToString();
    }
}
