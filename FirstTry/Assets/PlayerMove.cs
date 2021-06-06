using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewayForce = 100f;

/*     // Everthing written in this block will be applied at start of game
    void Start()
    {
        rb.AddForce(0, 200, 500);
    }
 */
    // We marked this as Fixed"Update" because we are using it to mess with pyhsics
    void FixedUpdate()
    {   
        //add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0);
        }
        if ( Input.GetKey("a") )
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0);
        }

    }
}
