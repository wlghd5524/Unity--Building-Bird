using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpPower;
    public float continuedJumpPower;
    bool firstJump = true;
    float checkJump = 0.5f;
    public static bool isCol = false;
    public static Vector3 colPoint;
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update() {
        if (firstJump == false) {   // 연속 점프 시 더 큰 추진력을 얻을 수 있음
            checkJump -= Time.deltaTime;
            if(checkJump <= 0) {
                firstJump = true;
            }
        }
        if (Input.GetMouseButtonDown(0)) {
            Jump();
        }
        if(isCol == true) {
            SceneController.StopTime();
            StartCoroutine("Pause");
        }
        else {
            SceneController.GoTime();
        }
        
    }
    IEnumerator Pause() {
        yield return new WaitForSecondsRealtime(1.0f);
        isCol = false;

        SceneController.GoGameOverScene();
    }
    private void OnCollisionEnter2D(Collision2D col) {
        if (FeverGauge.isFever == false) {
            SceneController.ready = false;
            colPoint = col.contacts[0].point;
            isCol = true;
            if (Score.score > PlayerPrefs.GetInt("BestScore")) {
                PlayerPrefs.SetInt("BestScore",Score.score);
            }
        }
    }
    void Jump() {
        GetComponent<AudioSource>().Play();
        firstJump = false;
        if (firstJump == true) {
            rb.velocity = Vector2.up * jumpPower;// (0,1) * jumpPower
        }
        else {
            rb.velocity = Vector2.up * continuedJumpPower;// (0,1) * jumpPower
        }
    }

}
