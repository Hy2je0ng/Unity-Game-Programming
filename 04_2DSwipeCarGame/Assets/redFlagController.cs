using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redFlagController : MonoBehaviour
{
    int flagRotAngle = 1;
    bool isRotated = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            this.isRotated = !this.isRotated;
        }

        if (this.isRotated)
        {
            transform.Rotate(0, this.flagRotAngle, 0);
        }
    }
}
