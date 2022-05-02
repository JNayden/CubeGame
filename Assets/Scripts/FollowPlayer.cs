using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform cube; // we place object of our cube with draggin in Unity
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        offset.Set(0, 1, -5);
        transform.position = cube.position + offset;
    }
}
