using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float damage = 10f;
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate((Vector3.up * 0.1f));
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "good"){
            other.gameObject.GetComponent<IDamage>().Hit(damage);
        }
    }
}
