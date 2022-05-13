using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float forwardForce = 500f;
    public float sidewayForce = 500f;
    // Update is called once per frame
    void FixedUpdate()
    {
       // forwardForce += 1;
       // sidewayForce += 0.05f;
        rb.AddForce(0f, 0f, Time.deltaTime * forwardForce);

        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < 2f)
        {
            FindObjectOfType<GameManager>().EndGameFromFalling();
        }
    }
}
