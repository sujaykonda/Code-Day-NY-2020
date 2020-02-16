using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour, IDamage
{
    public GameObject proj;
    public Transform tar;
    public float attackSpeed = 1f;
    float timer = 0;
    float health = 10;
    float hitTimer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer+= Time.fixedDeltaTime;
        hitTimer += Time.fixedDeltaTime;
        Vector3 diff = transform.position - tar.position;
        float angle = Mathf.Atan2(diff.y, diff.x);
        transform.eulerAngles = new Vector3(0f,0f, angle * Mathf.Rad2Deg + 90f);
        if(timer > attackSpeed){
            Instantiate(proj, transform.position, transform.rotation);
            timer = 0;
        }
    }
    public void Hit(float damage){
        if(hitTimer > 0.1){
            hitTimer = 0;
            health -= damage;
        }
    }
}
