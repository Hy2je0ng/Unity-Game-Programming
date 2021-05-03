using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCatController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // yellowCat moving control
        float speed = 0.03f;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(-speed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(speed, 0, 0);
        }

    }
}
