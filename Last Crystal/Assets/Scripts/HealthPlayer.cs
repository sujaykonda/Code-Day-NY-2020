using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    public Sprite[] Health;
    public SpriteRenderer thing;
    public float helth = 100;

void Start()
    {
        for(var i = 0; i < 33; i++){
            if((i*100/33) < helth && helth <= ((i+1)*100/33)){
                thing.sprite = Health[i];
            }
        }
    }
    void Update()
    {
        for(var i = 0; i < 33; i++){
            if((i*100/33) < helth && helth <= ((i+1)*100/33)){
                thing.sprite = Health[i];
            }
        }
    }
}
