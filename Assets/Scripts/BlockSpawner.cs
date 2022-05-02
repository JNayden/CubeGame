using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject blockPefab;

    public Vector3 scale;
    public Vector3 newPos;

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
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            
            if (indexR != i)
            {
                Instantiate(blockPefab, spawnPoints[i].position + newPos, Quaternion.identity);
                scaling();
            }
            newPos += new Vector3(0, 0, posOffset);
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
