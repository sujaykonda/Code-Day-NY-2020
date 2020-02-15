using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            spriteRenderer.sprite = sprites[0];
        }
        
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            spriteRenderer.sprite = sprites[2];
        }
        
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            spriteRenderer.sprite = sprites[1];
        }
        
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            spriteRenderer.sprite = sprites[3];
        }
    }
}
