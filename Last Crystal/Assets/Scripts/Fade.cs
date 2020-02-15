using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour{

    float timer = 0f;
    void Start(){
        timer = 0f;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if(timer > 1){
            Destroy(gameObject);
        }
    }
}
