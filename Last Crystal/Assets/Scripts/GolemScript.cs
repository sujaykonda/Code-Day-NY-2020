using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GolemScript : MonoBehaviour, IDamage
{
    public Transform tar;
    public float speed;
    public Animator animator;
    public GameObject rock;
    public float rockTimer;
    public float hitTimer;
    public string scenename;
    float health = 50;
    // Start is called before the first frame update
    void Start()
    {
        rockTimer = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rockTimer += Time.fixedDeltaTime;
        hitTimer += Time.fixedDeltaTime;
        Vector3 diff = tar.position - transform.position;
        if(Mathf.Abs(diff.x) <= Mathf.Abs(diff.y)){
            if(diff.x < 0){
                animator.SetInteger("Direction", 2);
            }else{
                animator.SetInteger("Direction" , 1);
            }
            transform.Translate((new Vector3(diff.x, 0, 0))*speed);       
            diff = tar.position - transform.position;
            if(Mathf.Abs(diff.x) < 0.1 && rockTimer > 1f){
                rockTimer = 0f;
                GameObject newRock = Instantiate(rock);
                if(diff.y < 0){
                    newRock.transform.position = transform.position;
                    newRock.transform.eulerAngles = new Vector3(0, 0, 180);
                }else{
                    newRock.transform.position = transform.position;
                    newRock.transform.eulerAngles = new Vector3(0, 0, 0);
                }
            }
        }else{
            if(diff.y < 0){
                animator.SetInteger("Direction", 3);
            }else{
                animator.SetInteger("Direction" , 0);
            }
            transform.Translate((new Vector3(0, diff.y, 0))*speed);
            diff = tar.position - transform.position;
            if(Mathf.Abs(diff.y) < 0.1 && rockTimer > 0.5f){
                rockTimer = 0;
                GameObject newRock = Instantiate(rock);
                if(diff.x > 0){
                    newRock.transform.position = transform.position;
                    newRock.transform.eulerAngles = new Vector3(0, 0, 270);
                }else{
                    newRock.transform.position = transform.position;
                    newRock.transform.eulerAngles = new Vector3(0, 0, 90);
                }
            }
        }

    }
    public void Hit(float damage){
        if(hitTimer > 0.2f){
            hitTimer = 0f;
            health -= damage;
        }
        if(health <= 0){
            PrismsDefeated.golemsLeft -= 1;
            if(PrismsDefeated.golemsLeft == 0){
                SceneManager.LoadScene(sceneName: scenename);
            }
            Destroy(gameObject);
        }
    }
}
