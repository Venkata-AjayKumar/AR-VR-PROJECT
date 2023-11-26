using UnityEngine;

public class BounceBall : MonoBehaviour
{
    // Adjust these values to control the throw and fall
    public float throwForce = 10f;
    public float fallAcceleration = 5f;

    private Rigidbody rb;
    private bool isThrown = false;

    void Start()
    {
        // Get the Rigidbody component
        rb = GetComponent<Rigidbody>();
        // Set isKinematic to true initially to disable physics
        rb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the 'A' key is pressed to throw the ball
        if (Input.GetKeyDown(KeyCode.C) && !isThrown)
        {
            // Enable physics when 'A' key is pressed
            rb.isKinematic = false;

            // Apply initial upward velocity to simulate the throw
            rb.velocity = new Vector3(0, throwForce, 0);

            isThrown = true;
        }

        // Simulate falling using kinematics
        if (isThrown)
        {
            // Update the velocity to simulate falling with acceleration
            rb.velocity += new Vector3(0, -fallAcceleration * Time.deltaTime, 0);
        }
    }
}
