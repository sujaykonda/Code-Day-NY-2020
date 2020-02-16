using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour, IDamage
{
    public Sprite[] Health;
    public SpriteRenderer thing;
    public float helth;
    public float hitTimer;
    public GameObject dedscreen;

    void Start()
    {
        helth = 100;
        for(var i = 0; i < 33; i++){
            if((i*100/33) <= helth && helth <= ((i+1)*100/33)){
                thing.sprite = Health[i];
            }
        }
        if(helth < 0){
            thing.sprite = Health[0];
        }
    }
    void Update()
    {
        hitTimer += Time.deltaTime;
        for(var i = 0; i < 33; i++){
            if((i*100/33) <= helth && helth <= ((i+1)*100/33)){
                thing.sprite = Health[i];
                dedscreen.SetActive(false);
            }
        }
        if(helth < 0){
            thing.sprite = Health[0];
            dedscreen.SetActive(true);
        }
    }
    public void Hit(float damage){
        if(hitTimer > 0.1){
            hitTimer = 0;
            helth -= damage;
        }
        
    }
}

