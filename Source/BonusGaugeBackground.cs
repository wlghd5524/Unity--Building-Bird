using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BonusGaugeBackground : MonoBehaviour
{
    Image bar;
    void Start()
    {
        bar = GetComponent<Image>();
    }
    void Update()
    {
        if(BonusGauge.isBonus == true) 
        {
            bar.enabled = true;
        }
        else
        {
            bar.enabled = false;
        }
    }
}
