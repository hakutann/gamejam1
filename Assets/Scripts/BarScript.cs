using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarScript : MonoBehaviour
{
    float presentGauge = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Image gaugeCircle = GetComponent<Image>();

        if(presentGauge<1f){
            presentGauge += 0.01f;
        }else if(presentGauge>=1f){
            presentGauge = 0f;
        }
        gaugeCircle.fillAmount = presentGauge;
    }
}
