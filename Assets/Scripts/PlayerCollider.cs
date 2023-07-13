using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    public PlayerMovement movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            Debug.Log("You hit");
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
