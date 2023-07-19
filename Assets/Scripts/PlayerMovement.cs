using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardSpeed;
    public float rightLeftSpeed;
    public float jumpForce;
    Animator animator;
    bool jump = false;  
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("up"))
        {
            animator.SetBool("iswalking", true);
            rb.AddForce(0, 0, forwardSpeed * Time.deltaTime);
        }
        else
        {
            animator.SetBool("iswalking", false);
        }

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
    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            animator.SetBool("Jump", true);
            JumpApply();
        }
        else
        {
            animator.SetBool("Jump", false);
        }   
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Plane")
        {
            
            jump = true;
        }
    }
    public void JumpApply()
    {
        if (jump == true)
        {
          
            rb.AddForce(0, jumpForce, 0);
            jump = false;
        }
    }
}
