using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;

    float jumpForce = 780.0f;
    float walkForce = 20.0f;
    float maxWalkSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        // <-- Moving -->
        int key = 0;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            key = -1;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            key = 1;
        }

        // Player Speed
        float speedX = Mathf.Abs(this.rigid2D.velocity.x);

        if(speedX < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }


        // Moving Direction
        if(key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        // animation speed control (by player speed)
        this.animator.speed = speedX / 3.0f;

    }
}
