using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour{

private GameObject player;
Rigidbody rb;
public float speed;
    void Start(){
        rb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        speed = 1.5F;
    }
    private void OnCollisionEnter(Collision other) {
            if(other.body.tag == "Player"){
                player.transform.position = player.GetComponent<Controller>().originalPos;
                transform.position = new Vector3(Random.Range(-9.5F, 9.5F), 1 , Random.Range(-9.5F, 9.5F));
                player.GetComponent<UpdateScores>().updateLives();
            }
        
    }

    void Update(){
        transform.LookAt(player.transform);
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
