using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float deltaTime = 0;
    float span = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.deltaTime += Time.deltaTime;

        if(this.deltaTime > this.span)
        {
            this.deltaTime = 0;
            GameObject go = Instantiate(arrowPrefab) as GameObject;

            int px = Random.Range(-7, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
