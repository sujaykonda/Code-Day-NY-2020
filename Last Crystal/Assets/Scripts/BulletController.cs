using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float damage = 10f;
    public float speed = 0.1f;
    public float aiming = 0f;
    public Transform tar;
    public float time = 5f;
    public float kb = 0f;
    float timer = 0;
    void Start(){
        tar = GameObject.Find("Player").transform;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;
        Vector3 diff = transform.position - tar.position;
        float diffAngle = (Mathf.Atan2(diff.y, diff.x)*Mathf.Rad2Deg - transform.eulerAngles.z + 90f);
        if(Mathf.Abs(diffAngle) > 180){
            diffAngle = -Mathf.Abs(diffAngle)/diffAngle*(360-Mathf.Abs(diffAngle));
        }
        float angle = diffAngle*aiming;
        transform.eulerAngles = new Vector3(0f,0f, (angle + transform.eulerAngles.z));
        transform.Translate((Vector3.up * speed));
        if(timer > time){
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "good"){
            other.gameObject.GetComponent<IDamage>().Hit(damage);
        }
    }
}
