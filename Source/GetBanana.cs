using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBanana : MonoBehaviour
{
    public GameObject banana;
    public static bool isPipeCol;
    void Update() {
        if(BonusGauge.isBonus == true)
            banana.SetActive(false);
        else 
            banana.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D other) {
          if (other.gameObject.tag == "Pipe")
            isPipeCol = true;
        else 
            isPipeCol = false;
        BonusGauge.bonus += 100f;
        banana.SetActive(false);
    }
}
