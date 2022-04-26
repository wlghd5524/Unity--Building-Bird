using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    private MeshRenderer render;
    public float speed;
    private float offset;
    void Start() {
        render = GetComponent<MeshRenderer>();
    }
    void Update()  {
        offset += Time.deltaTime * speed;
        render.material.mainTextureOffset = new Vector2(offset, 0);
        if(FeverGauge.isFever == true) {
            GetComponent<AudioSource>().Stop();
        }
        else {
            GetComponent<AudioSource>().Play();
        }
    }
}
