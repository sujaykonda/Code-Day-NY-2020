using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public Animator anim;
public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Up", Input.GetKeyDown(KeyCode.Up));
        anim.SetBool("Down", Input.GetKeyDown(KeyCode.Down));
        anim.SetBool("Left", Input.GetKeyDown(KeyCode.Left));
        anim.SetBool("Right", Input.GetKeyDown(KeyCode.Right));
    }
}
