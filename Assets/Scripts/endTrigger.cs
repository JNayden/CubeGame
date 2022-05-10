using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endTrigger : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        gameManager.completeLevel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
