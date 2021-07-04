using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 왼쪽 마우스 클릭
        {
            GameObject bamsongi = Instantiate(bamsongiPrefab) as GameObject;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;

            int weight = 2000;

            bamsongi.GetComponent<BamsongiController>().shoot(worldDir.normalized * weight);
        }
    }
}
