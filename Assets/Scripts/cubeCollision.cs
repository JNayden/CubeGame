using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cubeCollision : MonoBehaviour
{
    //Like we said before we need these 2 things, so code can be called:
    //1) RigidBody
    //2) Collider
    public CubeMovement cubeMovement;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit obstacle");
            cubeMovement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
