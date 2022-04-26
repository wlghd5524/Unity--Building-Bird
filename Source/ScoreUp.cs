using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScoreUp : MonoBehaviour {
    BoxCollider2D a;
    Transform b;
    Vector2 v = new Vector3(1f,100f,1f);
    
    void Start() {
        a = GetComponent<BoxCollider2D>();
        b = GetComponent<Transform>();
    }
    void Update() {
        if (FeverGauge.isFever == true) 
            b.localScale = v;
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (BonusGauge.isBonus == true)
            Score.score += 2;
        else
            Score.score += 1;
    }
}
