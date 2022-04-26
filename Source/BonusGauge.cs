using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BonusGauge : MonoBehaviour
{
    Image bonusBar;
    float maxBonus = 100f;
    public static float bonus;
    public static bool isBonus;
    
    // Start is called before the first frame update
    void Start()
    {
        bonusBar = GetComponent<Image>();
        bonus = 0;
        isBonus = false;
    }
    // Update is called once per frame
    void Update()
    {
        bonusBar.fillAmount = bonus / maxBonus;
        if (bonusBar.fillAmount >= 1) 
        {
            bonus = 100f;
            isBonus = true;
        }
        if (isBonus == true) {
            bonus -= Time.deltaTime * 6;
            if(bonus <= 0) {
                isBonus = false;
                bonus = 0;
            }
        }
    }
}
