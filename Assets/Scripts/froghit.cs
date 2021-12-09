using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class froghit : MonoBehaviour
{

    public void LoadLevel(string name)//function with string parameter, void is return type.
    {
        SceneManager.LoadScene(name);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Frog"))
        {
           
                LoadLevel("gameover");
        }

        if (collision.gameObject.CompareTag("Car"))
        {
           Destroy(gameObject);
        }

    }

    //private void OnCollisionEnter2D(Collision2D collision)
  //  {
    /// 
         //   Destroy(gameObject);
        
   // }
}
