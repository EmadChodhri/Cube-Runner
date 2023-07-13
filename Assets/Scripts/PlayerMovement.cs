using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardSpeed = 1000;
    public float rightLeftSpeed = 500;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardSpeed * Time.deltaTime);
       
        
        if (Input.GetKey("right"))
        {
            rb.AddForce(rightLeftSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("left"))
        {
            rb.AddForce(-rightLeftSpeed * Time.deltaTime, 0, 0);
        }

        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }

    
}
