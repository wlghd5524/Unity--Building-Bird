using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetApple : MonoBehaviour
{
    public GameObject apple;
    public static bool isPipeCol = false;
    void Update() {
        if (FeverGauge.isFever == true)
            apple.SetActive(false);
        else 
            apple.SetActive(true);
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Pipe")
            isPipeCol = true;
        FeverGauge.fever += 20f;
        apple.SetActive(false);
    }
}
