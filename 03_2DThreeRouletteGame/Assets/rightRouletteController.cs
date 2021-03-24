using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightRouletteController : MonoBehaviour
{
    float rightRotSpeed = 0;
    float rightMinSpeed = 0.08f;
    int rightState = 0;

    // ===== rightState =====
    // 0 : 회전 안함 상태
    // 1 : 회전 상태
    // 2 : 감속 상태

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.rightState == 0 && Input.GetMouseButton(0)) // 회전안함 상태일 때 마우스 왼쪽이 계속 눌리는 중
        {
            this.rightRotSpeed = 10;
            this.rightState = 1;
        }

        if (this.rightState == 1 && Input.GetMouseButtonUp(0)) // 회전 상태일 때 마우스 왼쪽이 떼지면
        {
            this.rightState = 2;
        }

        if (this.rightState == 2) // 감속 상태
        {
            this.rightRotSpeed *= 0.96f;

            if(this.rightRotSpeed <= this.rightMinSpeed) // 현재 속도가 최소 속도보다 작아진다면
            {
                this.rightRotSpeed = 0; // 멈춘걸로 간주
                this.rightState = 0;
            }
        }

        transform.Rotate(0, 0, this.rightRotSpeed);
    }

}
