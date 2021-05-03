using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject redCar;
    GameObject redFlag;
    GameObject redDistanceText;

    GameObject greenCar;
    GameObject greenFlag;
    GameObject greenDistanceText;

    GameObject flagRotateText;
    int redFlagCount = 0; // flag ȸ�� Ƚ��
    int redFlagLastY = 0; // flag �� rotation y��

    // Start is called before the first frame update
    void Start()
    {
        this.redCar = GameObject.Find("redCar");
        this.redFlag = GameObject.Find("redFlag");
        this.redDistanceText = GameObject.Find("redDistanceText");

        this.greenCar = GameObject.Find("greenCar");
        this.greenFlag = GameObject.Find("greenFlag");
        this.greenDistanceText = GameObject.Find("greenDistanceText");

        this.flagRotateText = GameObject.Find("flagRotateText");
      
    }

    // Update is called once per frame
    void Update()
    {   

        // red text control
        float redLength = (this.redFlag.transform.position.x - this.redCar.transform.position.x);
        this.redDistanceText.GetComponent<Text>().text = "Red Car ��ǥ �������� " + redLength.ToString("F2") + "m";

        // green text control
        float greenLength = (this.greenCar.transform.position.y - this.greenFlag.transform.position.y);
        this.greenDistanceText.GetComponent<Text>().text = "Green Car ��ǥ �������� " + greenLength.ToString("F2") + "m";

        // flag text control
        int redFlagCurrentY = (int)this.redFlag.transform.rotation.eulerAngles.y % 360;

        if ((this.redFlagLastY != redFlagCurrentY) && (redFlagCurrentY == 0))
        {
            this.redFlagCount++;
        }

        this.redFlagLastY = redFlagCurrentY;

        //Debug.Log(this.redFlagLastY);

        this.flagRotateText.GetComponent<Text>().text = "RED ��� ȸ�� Ƚ�� " + this.redFlagCount.ToString() + "ȸ";

    }
}
