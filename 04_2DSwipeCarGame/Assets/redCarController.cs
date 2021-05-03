using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redCarController : MonoBehaviour
{
    float redCarSpeed = 0;
    Vector2 redCarStartPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.redCarStartPos = Input.mousePosition;
        }

        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 redCarEndPos = Input.mousePosition;
            float distance = redCarEndPos.x - this.redCarStartPos.x;
            this.redCarSpeed = distance / 5000.0f;
        }

        transform.Translate(this.redCarSpeed, 0, 0);
        this.redCarSpeed *= 0.98f;
    }
}
