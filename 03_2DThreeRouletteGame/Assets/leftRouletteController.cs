using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftRouletteController : MonoBehaviour
{

    string[] fortunes = { "운수나쁨", "운수대통", "운수매우나쁨", "운수보통", "운수조심", "운수좋음" };
    float currentZ = 0; // 현재 Rotation Z 값 받아올 변수

    float leftRotSpeed = 0;
    float leftMinSpeed = 0.08f;
    int leftState = 0;

    // ===== leftState =====
    // 0 : 회전 안함 상태
    // 1 : 회전 상태
    // 2 : 회전 안함 + 상태 출력

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.leftState == 0 && Input.GetMouseButtonDown(0)) //회전 안함 상태 + 마우스 왼쪽 누름
        {
            this.leftRotSpeed = 10;
            this.leftState = 1;
        }

        if(this.leftState == 1) // 회전 상태
        {
            this.leftRotSpeed *= 0.96f;
            transform.Rotate(0, 0, this.leftRotSpeed);

            if (this.leftRotSpeed <= this.leftMinSpeed) // 현재 속도가 최소 속도보다 작아진다면
            {
                this.leftRotSpeed = 0;
                this.leftState = 2; // 멈춘걸로 간주하고 출력 상태로 상태 변환
            }
        }

       if (this.leftState == 2) // 움직임을 멈췄을 때 한 번만 출력하기 위한 상태
        {
            this.currentZ = transform.rotation.eulerAngles.z + 30; // 현재 rotation z 값 범위를 -30 ~ 30 -> 0 ~ 60으로 변경해야하므로 rotateZ 값+ 30
            this.currentZ %= 360; // 0 ~ 360 안의 범위로 

            Debug.Log(this.fortunes[(int)this.currentZ / 60]); // 현재 회전 된 각도를 60으로 나눠 6가지중 해당 상태 출력
            this.leftState = 0;
        }
    }

}
