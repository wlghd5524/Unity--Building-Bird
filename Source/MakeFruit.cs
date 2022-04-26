
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeFruit : MonoBehaviour
{
    public GameObject fruit;
    float timer = 0;
    public float timeDiff;
    float yFruit = 0;
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff && SceneController.ready == true) {
            GameObject newFruit = Instantiate(fruit);
            yFruit = Random.Range(MakePipe.GetYPipe()-0.5f,MakePipe.GetYPipe()+0.5f);
            if(GetApple.isPipeCol == false) {
                newFruit.transform.position = new Vector3(9,yFruit,0);
                timer = 0;
            }
            Destroy(newFruit,8.0f);
        }
        
    }

}
