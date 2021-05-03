using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteCatController : MonoBehaviour
{
    GameObject yellowCat;
    GameObject blackCat;
    GameObject star2;

    // Start is called before the first frame update
    void Start()
    {
        this.yellowCat = GameObject.Find("yellowCat");
        this.blackCat = GameObject.Find("blackCat");
        this.star2 = GameObject.Find("star2");
    }

    // Update is called once per frame
    void Update()
    {   
        // whiteCat moving control
        float speed = 0.03f;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed, 0, 0);
        }

        // Variables required for collision 
        Vector2 whiteCatCenter = transform.position;
        Vector2 distance;
        float catRadius = 1.0f;
        float dir;

        // whiteCat - yellowCat Collision 
        Vector2 yellowCatCenter = this.yellowCat.transform.position;
        
        distance = whiteCatCenter - yellowCatCenter;
        dir = distance.magnitude;

        if (dir < catRadius + catRadius)
        {
            transform.Translate(0.7f, 0, 0); // whiteCat 오른쪽으로 이동
            this.yellowCat.transform.Translate(-0.7f, 0, 0); // yellowCat 왼쪽으로 이동
        }

        //whiteCat - blackCat Collision 

        Vector2 blackCatCenter = this.blackCat.transform.position;

        distance = whiteCatCenter - blackCatCenter;
        dir = distance.magnitude;

        if (dir < catRadius + catRadius)
        {
            Destroy(gameObject);
        }

        //whiteCat - star2 Collision 
        Vector2 star2Center = this.star2.transform.position;
        float Star2Radius = 0.6f;

        distance = whiteCatCenter - star2Center;
        dir = distance.magnitude;

        if (dir < catRadius + Star2Radius)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().increaseHP(1.0f);
        }

    }
}
