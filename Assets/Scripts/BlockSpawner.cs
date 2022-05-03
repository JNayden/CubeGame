using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject blockPefab;

    public Vector3 scale;
    public Vector3 newPos;
    public Vector3 newPos1;

    public static float posOffset = 15f; // static to not go out of scope, when invoke them in Update
    public static float timeToSpawn = 2f;
    public static float timeBetweenWave = 3f;

    public Transform groundIncrease;
    
    public void scaling()
    {
        scale = new Vector3(0, 0, 50);
        groundIncrease.localScale += scale;
    }

    public void levelGenerate()
    {
        int indexR = Random.Range(0, spawnPoints.Length);
        int scaleX = Random.Range(3, 6);
       // int scaleY = Random.Range(5, 10);
        int scaleZ = Random.Range(3, 6);
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            
            if (indexR != i)
            {
                blockPefab.transform.localScale = new Vector3(scaleX, 2, scaleZ);
                Instantiate(blockPefab, spawnPoints[i].position + newPos + newPos1, Quaternion.identity);
                scaling();
            }
            newPos += new Vector3(0, 0, posOffset);
            newPos1 = new Vector3(scaleZ,0, scaleX);
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
        }
    }
}
