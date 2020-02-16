using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour{
    float damage = 10f;
    float timer = 0f;
    void Start(){
        timer = 0f;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;
        if(timer > 1){
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "bad"){
            other.gameObject.GetComponent<IDamage>().Hit(damage);
            Debug.Log("Hit");
        }
    }
}
