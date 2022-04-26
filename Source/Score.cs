using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static int score = 0;
    TextMeshProUGUI resourceText;
    void Start() {
        score = 0;
    }
    void Update() {
        GetComponent<TextMeshProUGUI>().text = score.ToString();
        if (BonusGauge.isBonus == true)
            GetComponent<TextMeshProUGUI>().text = "<color=#ffd700>" + score.ToString() + "</color>";
    }
}
