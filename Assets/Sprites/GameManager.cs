using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Map")
        {
            Debug.Log("Game LoSt .... boooo");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
