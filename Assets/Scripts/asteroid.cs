using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour
{

    public GameObject ast1;
    public GameObject ast2;
    public GameObject ast3;
    public GameObject ast4;
    public GameObject ast5;
    public GameObject ast6;
    public GameObject ast7;
    public GameObject ast8;
    public GameObject ast9;
    protected GameObject Asteroid;
    private float xPosition = 0f;
    private int s = 0;
    float total_t = 0;
    float t = 0;
    float t_compare=10.0f;
    float SpawnTime = 4.0f;

    // Use this for initialization
    void Start()
    {

        AstSpawnfunc();
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    // Update is called once per frame

    void Update()
    {
        t = Time.deltaTime;
        total_t = total_t + t;
        
    }

    void AstSpawnfunc()
    {
        s = Random.Range(1, 9);
        xPosition = Random.Range(-2.8f, 2.8f);
        switch (s)
        {
            case 1: Asteroid = Instantiate(ast1, new Vector3(xPosition, transform.position.y, 0), Quaternion.identity) as GameObject; break;
            case 2: Asteroid = Instantiate(ast2, new Vector3(xPosition, transform.position.y, 0), Quaternion.identity) as GameObject; break;
            case 3: Asteroid = Instantiate(ast3, new Vector3(xPosition, transform.position.y, 0), Quaternion.identity) as GameObject; break;
            case 4: Asteroid = Instantiate(ast4, new Vector3(xPosition, transform.position.y, 0), Quaternion.identity) as GameObject; break;
            case 5: Asteroid = Instantiate(ast5, new Vector3(xPosition, transform.position.y, 0), Quaternion.identity) as GameObject; break;
            case 6: Asteroid = Instantiate(ast6, new Vector3(xPosition, transform.position.y, 0), Quaternion.identity) as GameObject; break;
            case 7: Asteroid = Instantiate(ast7, new Vector3(xPosition, transform.position.y, 0), Quaternion.identity) as GameObject; break;
            case 8: Asteroid = Instantiate(ast8, new Vector3(xPosition, transform.position.y, 0), Quaternion.identity) as GameObject; break;
            case 9: Asteroid = Instantiate(ast9, new Vector3(xPosition, transform.position.y, 0), Quaternion.identity) as GameObject; break;
        }
        if (total_t > t_compare && SpawnTime > 1.0)
        {
            SpawnTime -= 0.5f;
            total_t = 0;
            print("Speed increased");
        }
        else if (SpawnTime <= 1.0)
            print("Maximum speed");
        Invoke("AstSpawnfunc", SpawnTime);
    }


}

