using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gem : MonoBehaviour {

    public GameObject gem1;
    public GameObject gem2;
    public GameObject gem3;
    public GameObject gem4;
    public GameObject gem5;
    protected GameObject Gem;
    private float xPosition = 0f;
    private int s = 0;

    // Use this for initialization
    void Start () {
        Invoke("GemSpawnfunc", 2);
    }

    void GemSpawnfunc()
    {
        s = Random.Range(1, 5);
        xPosition = Random.Range(-2.8f, 2.8f);
        switch(s)
         {
            case 1: Gem = Instantiate(gem1, new Vector3(xPosition, transform.position.y, 0), Quaternion.identity) as GameObject;break;
            case 2: Gem = Instantiate(gem2, new Vector3(xPosition, transform.position.y, 0), Quaternion.identity) as GameObject; break;
            case 3: Gem = Instantiate(gem3, new Vector3(xPosition, transform.position.y, 0), Quaternion.identity) as GameObject; break;
            case 4: Gem = Instantiate(gem4, new Vector3(xPosition, transform.position.y, 0), Quaternion.identity) as GameObject; break;
            case 5: Gem = Instantiate(gem5, new Vector3(xPosition, transform.position.y, 0), Quaternion.identity) as GameObject; break;
        }
        
        Invoke("GemSpawnfunc", Random.Range(4, 6));
    }
}
