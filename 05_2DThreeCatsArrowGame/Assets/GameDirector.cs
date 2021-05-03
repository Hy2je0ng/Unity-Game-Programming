using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    GameObject YWDistance; // yellowCat - whiteCat distance

    GameObject whiteCat;
    GameObject yellowCat;

    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
        this.YWDistance = GameObject.Find("YWDistance");

        this.whiteCat = GameObject.Find("whiteCat");
        this.yellowCat = GameObject.Find("yellowCat");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = this.whiteCat.transform.position.x - this.yellowCat.transform.position.x;
        this.YWDistance.GetComponent<Text>().text = "Yellow Cat - White Cat 사이 거리는 "+ distance + "m"; // Text UI update
    }

    public void decreaseHP(float hp)
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= hp;
    }

    public void increaseHP(float hp)
    {
        this.hpGauge.GetComponent<Image>().fillAmount += hp;
    }
}
