using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeverTime : MonoBehaviour
{
    SpriteRenderer a;
    BoxCollider2D b;
    public GameObject explosion;
    
    void Start() {
        a = GetComponent<SpriteRenderer>();
        b = GetComponent<BoxCollider2D>();
    }
    
    void Update() {
        if(FeverGauge.isFever == true)
            b.isTrigger = true;
    }
    private void OnTriggerEnter2D(Collider2D coll) {
        if (FeverGauge.isFever == true) {
            a.enabled = false;
            GameObject newExplosion = Instantiate(explosion);
            newExplosion.transform.position = coll.GetComponent<Transform>().position;
            Destroy(newExplosion,1.0f);
        }
    }
}
