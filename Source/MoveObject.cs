using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed;
    void Update() {
        transform.position += Vector3.left * speed * Time.deltaTime; //(-1 * speed,0)
        if (FeverGauge.isFever == true) {
            transform.position += Vector3.left * speed * 2 * Time.deltaTime; //(-1 * speed * 2,0) 
        }
    }
}
