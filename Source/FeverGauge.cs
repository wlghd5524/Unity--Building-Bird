using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeverGauge : MonoBehaviour
{
    Image feverBar;
    float maxFever = 100f;
    public static float fever;
    public static bool isFever = false;
    

    void Start() {
        feverBar = GetComponent<Image>();
        fever = 0;
    }    
    void Update() {
        feverBar.fillAmount = fever / maxFever;
        if (feverBar.fillAmount == 1) {
            isFever = true;
        }
        if (isFever == true) {
            fever -= Time.deltaTime * 6;
            if(fever < 0) {
                isFever = false;
                fever = 0;
            }
        }
    }
}
