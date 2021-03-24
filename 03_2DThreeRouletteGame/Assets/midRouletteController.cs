using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class midRouletteController : MonoBehaviour
{

    float midRotSpeed = 0;
    int midState = 0;

    // ===== midState =====
    // 0 : 회전 안함 상태
    // 1 : 회전 상태

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.midState == 0 && Input.GetMouseButtonDown(0)) // 회전 안함 상태일 때 마우스 왼쪽 누름
        {
            this.midState = 1;
            this.midRotSpeed = 10;
        }

        if (this.midState == 1 && Input.GetMouseButtonDown(1)) // 회전 상태일 때 마우스 오른쪽 누름
        {
            this.midRotSpeed -= 1;
        }

        if (this.midRotSpeed == 0) {
            this.midState = 0; //음수방향으로 돌지 않도록 회전안함 상태(0)로 상태변환
        }

        transform.Rotate(0, 0, this.midRotSpeed);
    }

}
