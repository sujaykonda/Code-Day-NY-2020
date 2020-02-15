using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    public float Speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 translation = new Vector3(0, 0, 0);
        if(Input.GetKey(KeyCode.UpArrow)){
            spriteRenderer.sprite = sprites[0];
            translation += Vector3.up * Speed; 
        }
        
        if(Input.GetKey(KeyCode.DownArrow)){
            spriteRenderer.sprite = sprites[2];
            translation += Vector3.down * Speed;
        }
        
        if(Input.GetKey(KeyCode.RightArrow)){
            spriteRenderer.sprite = sprites[1];
            translation += Vector3.right * Speed;
        }
        
        if(Input.GetKey(KeyCode.LeftArrow)){
            spriteRenderer.sprite = sprites[3];
            translation += Vector3.left * Speed;
        }
        transform.Translate(translation);
    }
}
