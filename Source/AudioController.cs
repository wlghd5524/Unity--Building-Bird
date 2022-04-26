using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    void Update() {
        if(BirdJump.isCol == true) {
            GetComponent<AudioSource>().Stop();
        }
    }
}
