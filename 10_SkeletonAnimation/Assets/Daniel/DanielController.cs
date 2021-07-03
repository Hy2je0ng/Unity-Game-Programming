using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanielController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;

    float jumpForce = 680.0f;
    float walkForce = 30.0f;
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
        if (Input.GetKeyDown(KeyCode.Return))
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        int key = 0;

        if (Input.GetKey(KeyCode.D)) key = 1;
        if (Input.GetKey(KeyCode.S)) key = -1;


        float speedX = Mathf.Abs(this.rigid2D.velocity.x);

        if ( speedX < this.maxWalkSpeed )
        {
            Debug.Log("=== daniel Speed : " + speedX);
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        if ( key != 0 )
        {
            transform.localScale = new Vector3(key * 0.3f, 0.3f, 1);
        }

        this.animator.speed = speedX / 2.0f;

    }

}
