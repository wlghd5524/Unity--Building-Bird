using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFruit : MonoBehaviour
{
    public GameObject pipe;
    public static bool isPipeCol;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Pipe")
            isPipeCol = true;
        else
            isPipeCol = false;
        FeverGauge.fever += 20f;
        
        pipe.SetActive(false);
    }
}
