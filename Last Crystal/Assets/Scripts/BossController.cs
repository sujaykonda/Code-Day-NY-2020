using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossController : MonoBehaviour, IDamage
{
    public GameObject proj;
    public Transform tar;
    public float attackSpeed = 1f;
    public SpriteRenderer renderer;
    public Sprite[] sprites;
    public Vector3[] positions;
    public float movementSpeed = 0.1f;
    float t = 0;
    float timer = 0;
    public float maxhealth = 50f;
    float health;
    float hitTimer = 0;
    int state = 0;
    public string scenename;
    void Start(){
        transform.position = positions[0];
        health = maxhealth;
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
        t += movementSpeed;
        transform.position = Vector3.Lerp(positions[state], positions[((state+1) % positions.Length)], t);
        if(t >= 1){
            t = 0;
            state += 1;
        }
        if(state == positions.Length){
            state = 0;
        }

    }
    public void Hit(float damage){
        if(hitTimer > 0.2f){
            hitTimer = 0f;
            health -= damage;
            for(var i = 0; i < 17; i++){
                if((i*maxhealth/17) <= health && health <= ((i+1)*maxhealth/17)){
                    renderer.sprite = sprites[i];
                }
            }
            if(health <= 0){
                renderer.sprite = sprites[0];
                SceneManager.LoadScene(sceneName: scenename);
            }
        }
    }
}
