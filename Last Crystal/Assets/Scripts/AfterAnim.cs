﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AfterAnim : MonoBehaviour
{
    float timer;
    public string NextScene;
    public string LastScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 10f){
             SceneManager.LoadScene(sceneName:NextScene);
        }
    }
}
