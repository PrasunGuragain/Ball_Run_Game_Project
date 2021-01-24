using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    // the player
    public Rigidbody rb;

    public float forwardAndBackwardForce = 500f; // moving forward and backward
    public float sidewaysForce = 500f; // moving sideways

    //public PlayerMovement movement;
    //jump
    public float upward = 10.0f;


    //public PlayerCollision breakFalling;

    //public float upward = 5000f; // moving upward
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardAndBackwardForce * Time.deltaTime);

        //If "d" is pressed, go right
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //If "a" is pressed, go left
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        
        // jumps only after level 3
        if(SceneManager.GetActiveScene().buildIndex > 3)
            if (rb.position.y < 1.01f)
            {
 
                if (Input.GetKeyDown(KeyCode.Space))
                {

                   rb.AddForce(0, upward * Time.deltaTime, 0, ForceMode.VelocityChange);
                }

            }


        //if (rb.position.x > 10.1 || rb.position.y < -1f || rb.position.x < -10.1)
        //{
        //    movement.enabled = false;
        //    FindObjectOfType<GameManager>().EndGame();
        //}

    }

}
