using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BestScore : MonoBehaviour
{
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = "Best Score : " + PlayerPrefs.GetInt("BestScore");
    }
}
