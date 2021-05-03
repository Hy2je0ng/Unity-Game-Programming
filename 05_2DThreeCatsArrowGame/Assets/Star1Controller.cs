using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star1Controller : MonoBehaviour
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
        // star1 rotaton & translaton control
        transform.Rotate(0, 0, 1.0f);
        transform.Translate(0, -0.015f, 0, Space.World);

        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        // star1 - whiteCat Collision
        Vector2 whiteCatCenter = this.whiteCat.transform.position;
        Vector2 star1Center = transform.position;

        float whiteCatRadius = 1.0f;
        float starRadius = 0.2f;

        Vector2 distance = whiteCatCenter - star1Center;
        float dir = distance.magnitude;

        if(dir < whiteCatRadius + starRadius)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().increaseHP(0.1f);

            Destroy(gameObject);
        }

    }
}
