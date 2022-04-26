using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    SpriteRenderer collSprite;
    Transform collTransform;
    void Start() {
        collSprite = GetComponent<SpriteRenderer>();
        collSprite.enabled = false;
        collTransform = GetComponent<Transform>();
    }
    void Update() {
        if(BirdJump.isCol == true) {
            collTransform.transform.position = BirdJump.colPoint;
            collSprite.enabled = true;
        }
    }
}
