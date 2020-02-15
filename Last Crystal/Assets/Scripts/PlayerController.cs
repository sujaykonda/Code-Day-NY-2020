using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    public float Speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 translation = new Vector3(0, 0, 0);
        if(Input.GetKey(KeyCode.UpArrow)){
            anim.SetInteger("Direction", 0);
            translation += Vector3.up * Speed; 
        }
        
        if(Input.GetKey(KeyCode.DownArrow)){
            anim.SetInteger("Direction", 3);
            translation += Vector3.down * Speed;
        }
        
        if(Input.GetKey(KeyCode.RightArrow)){
            anim.SetInteger("Direction", 1);
            translation += Vector3.right * Speed;
        }
        
        if(Input.GetKey(KeyCode.LeftArrow)){
            anim.SetInteger("Direction", 2);
            translation += Vector3.left * Speed;
        }
        transform.Translate(translation);
    }
}
