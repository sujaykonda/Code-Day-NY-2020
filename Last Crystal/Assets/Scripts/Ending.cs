using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    public string LastScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PrismsDefeated.defeatedPrisms.ToArray().Length >= 4){
            SceneManager.LoadScene(sceneName:LastScene);
        }
    }
}
