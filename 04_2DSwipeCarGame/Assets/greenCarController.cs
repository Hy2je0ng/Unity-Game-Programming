using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenCarController : MonoBehaviour
{
    float greenCarSpeed = 0;
    Vector2 greenCarStartPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            this.greenCarStartPos = Input.mousePosition;
        }

        else if (Input.GetMouseButtonUp(1))
        {
            Vector2 greenCarEndPos = Input.mousePosition;
            float distance = this.greenCarStartPos.y - greenCarEndPos.y;
            this.greenCarSpeed = distance / 5000.0f;

            GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.greenCarSpeed, 0, 0);
        this.greenCarSpeed *= 0.98f;
    }
}
