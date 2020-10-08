using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    public int index;
    public string levelName;
    
    void onTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //Loading Level with build index
            //SceneManager.LoadScene(index);

            // Loading level with scene name
            //SceneManager.LoadScene("levelName");

            //Restart lvl
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}