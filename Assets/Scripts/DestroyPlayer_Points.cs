using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer_Points : MonoBehaviour {
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ast")
        {
            print("Astroid Object");
            Destroy(gameObject);
           /* restart =  EditorUtility.DisplayDialog("Restart?", "Do you want to restart ", "Restart", "Exit");
            if(restart)
            {
                SceneManager.LoadScene("scene0");
            }
            else
            {
                Application.Quit();
            }*/
        }
        else if(other.tag == "gem1")
        {
            print("Other Object");
            Destroy(other.gameObject);
        }
        else if (other.tag == "gem2")
        {
            print("Other Object");
            Destroy(other.gameObject);
        }
        else if (other.tag == "gem3")
        {
            print("Other Object");
            Destroy(other.gameObject);
        }
        else if (other.tag == "gem4")
        {
            print("Other Object");
            Destroy(other.gameObject);
        }
        else if (other.tag == "gem5")
        {
            print("Other Object");
            Destroy(other.gameObject);
        }
        else if (other.tag == "coin")
        {
            print("Other Object");
            Destroy(other.gameObject);
        }
    }
}
