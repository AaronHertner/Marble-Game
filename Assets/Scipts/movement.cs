using UnityEngine;

public class movement : MonoBehaviour
{
    //member variables of class movement
    public Rigidbody    rb;
    private float       force = 1000f;
    private string[]    keys = {"a", "d"};

    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //forward movement
        rb.AddForce(0, 0, 8000);

        //left movement
        if (Input.GetKey(keys[0]))
        {
            rb.AddForce(-force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //right movement
        if (Input.GetKey(keys[1]))
        {
            rb.AddForce(force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
