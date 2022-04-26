using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waiting : MonoBehaviour
{
    public GameObject text;
    void Update() {
        if (Input.GetMouseButtonDown(0))
            text.SetActive(false);
    }
}
