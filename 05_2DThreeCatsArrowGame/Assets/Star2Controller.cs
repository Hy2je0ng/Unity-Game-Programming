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
        this.initialY = transform.position.y; // �ʱ� y�� ����
    }

    // Update is called once per frame
    void Update()
    {
        float currentY = transform.position.y; // ���� y��

        float speed = 0.02f;

        if (this.state == 0 && currentY < -this.initialY) // top-down���¿��� Ư�� y�� (-�ʱ� y��) �Ʒ��� ��������
        {
            this.state = 1; // bottom-up ���·� ��ȯ
        }
        else if (this.state == 0)
        {
            transform.Translate(0, -speed, 0);
        }

        else if (this.state == 1 && currentY > this.initialY) // bottom-up ���¿��� �ʱ� y�� ���� �ö󰡸�
        {
            this.state = 0; // top-down ���·� ��ȯ 
        }
        else if(this.state == 1)
        {
            transform.Translate(0, speed, 0);
        }
        
    }
}
