using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    float timer = 0;
    public float timeDiff;
    private static float yPipe = 0;
    void Update()
    {
        if (FeverGauge.isFever == true) 
            timer += Time.deltaTime * 2;
        else
            timer += Time.deltaTime;
        if (timer > timeDiff && SceneController.ready == true) {
            GameObject newpipe = Instantiate(pipe);
            yPipe = Random.Range(-2.2f,3.0f);
            newpipe.transform.position = new Vector3(1,yPipe,0);
            timer = 0;
            Destroy(newpipe,8.0f);
        }
    }
    public static float GetYPipe() {
        return yPipe;
    }
}