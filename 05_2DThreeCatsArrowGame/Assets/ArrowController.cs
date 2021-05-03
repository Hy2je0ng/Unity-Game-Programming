using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{

    GameObject whiteCat;

    // Start is called before the first frame update
    void Start()
    {
        this.whiteCat = GameObject.Find("whiteCat");
    }

    // Update is called once per frame
    void Update()
    {   

        // arrow moving control
        transform.Translate(0, -0.03f, 0);

        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        // arrow - whiteCat Collision 
        Vector2 whiteCatCenter = this.whiteCat.transform.position;
        Vector2 arrowCenter = transform.position;

        float whiteCatRadius = 1.0f;
        float arrowRadius = 0.4f;

        Vector2 distance = whiteCatCenter - arrowCenter;

        float dir = distance.magnitude;

        if (dir < whiteCatRadius + arrowRadius)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().decreaseHP(0.1f);

            Destroy(gameObject);
        }

    }
}
