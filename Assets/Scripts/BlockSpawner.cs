using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject blockPefab;

    public Vector3 scale;
    public Vector3 newPos;
    public Vector3 newPos1 = new Vector3(0,0, 10);

    public static float posOffset = 8f; // static to not go out of scope, when invoke them in Update
    public static float timeToSpawn = 2f;
    public static float timeBetweenWave = 1.5f;

    public Transform groundIncrease;


    public Rigidbody rb;
    public float sidewayForce = 500f;
    public float forwardForce = 500f;

    public void scaling()
    {
        scale = new Vector3(0, 0, 140);
        groundIncrease.localScale += scale;
    }

    public void levelGenerate()
    {
        int indexR = Random.Range(0, spawnPoints.Length);
        int scaleX = Random.Range(7, 10);
        
       // int scaleY = Random.Range(5, 10);
        int scaleZ = Random.Range(2, 3);
        int posZ = Random.Range(10, 55);
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            
            if (indexR != i)
            {
                blockPefab.transform.localScale = new Vector3(scaleX, 0.1f, scaleZ);
                Instantiate(blockPefab, spawnPoints[i].position + newPos + newPos1, Quaternion.identity);
                scaling();
            }
            newPos += new Vector3(0, 0, posZ);
            newPos1 = new Vector3(0,0, 10);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            levelGenerate();
            timeToSpawn = Time.time + timeBetweenWave;
            forwardForce += 100;
        }
    }
}
