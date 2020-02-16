using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float damage = 10f;
    public float speed = 0.1f;
    public float aiming = 0f;
    public Transform tar;
    void Start(){
        tar = GameObject.Find("Player").transform;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 diff = transform.position - tar.position;
        float angle = ((Mathf.Atan2(diff.y, diff.x)*Mathf.Rad2Deg - transform.eulerAngles.z + 90f)%360)*aiming;
        transform.eulerAngles = new Vector3(0f,0f, (angle + transform.eulerAngles.z)%360);
        transform.Translate((Vector3.up * speed));
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "good"){
            other.gameObject.GetComponent<IDamage>().Hit(damage);
        }
    }
}
