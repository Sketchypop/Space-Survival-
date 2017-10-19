using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveUFO : MonoBehaviour {

    public float speed;             //Floating point variable to store the player's movement speed.

    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //Vector2 movement = new Vector2(moveHorizontal, 0f);
        //rb2d.MovePosition(rb2d.position + movement *speed* Time.fixedDeltaTime);

        float moveacc = Input.acceleration.x;
        Vector2 movementacc = new Vector2(moveacc, 0f);
        rb2d.MovePosition(rb2d.position + movementacc * speed * Time.fixedDeltaTime);
    }

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
        else if (other.tag == "gem1")
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
