using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star2Controller : MonoBehaviour
{

    float initialY;
    int state = 0;
    // ==== state =====
    // 0 : top down
    // 1 : bottom up

    // Start is called before the first frame update
    void Start()
    {
        this.initialY = transform.position.y; // 초기 y값 저장
    }

    // Update is called once per frame
    void Update()
    {
        float currentY = transform.position.y; // 현재 y값

        float speed = 0.02f;

        if (this.state == 0 && currentY < -this.initialY) // top-down상태에서 특정 y값 (-초기 y값) 아래로 내려가면
        {
            this.state = 1; // bottom-up 상태로 전환
        }
        else if (this.state == 0)
        {
            transform.Translate(0, -speed, 0);
        }

        else if (this.state == 1 && currentY > this.initialY) // bottom-up 상태에서 초기 y값 위로 올라가면
        {
            this.state = 0; // top-down 상태로 전환 
        }
        else if(this.state == 1)
        {
            transform.Translate(0, speed, 0);
        }
        
    }
}
