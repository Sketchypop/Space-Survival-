using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour {

    public GameObject obj;
    protected GameObject Coin;
    private float xPosition = 0f;

    // Use this for initialization
    void Start () {
        Invoke("CoinSpawnfunc", 1);
    }

    void CoinSpawnfunc()
    {
        xPosition = Random.Range(-2.8f, 2.8f);
        Coin = Instantiate(obj, new Vector3(xPosition, transform.position.y, 0), Quaternion.identity) as GameObject;
        Invoke("CoinSpawnfunc", Random.Range(3, 5));
    }
}
