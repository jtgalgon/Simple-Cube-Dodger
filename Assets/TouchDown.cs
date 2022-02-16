using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDown : MonoBehaviour
{
    private GameObject enemy1;
    private GameObject enemy2;
    private GameObject player;
    private GameObject boundry;

    void Update() {
        player = GameObject.Find("Player");
        enemy1 = GameObject.Find("Enemy Cube");
        enemy2 = GameObject.Find("Enemy Cube 2");
        boundry = GameObject.Find("Boundary");
    }
    private void OnCollisionEnter(Collision other) {
        if(other.collider.tag == "Player"){
            player.GetComponent<UpdateScores>().updateTouchDowns();
            //reset player
            player.transform.position = player.GetComponent<Controller>().originalPos;
            player.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            //reset enemies
            enemy1.transform.position = new Vector3(Random.Range(-9.5F, 9.5F), 1 , Random.Range(-9.5F, 9.5F));
            enemy2.transform.position = new Vector3(Random.Range(-9.5F, 9.5F), 1 , Random.Range(-9.5F, 9.5F));
            //reset pos of allah
            transform.position = new Vector3(Random.Range(-9.5F, 9.5F), 1 , Random.Range(-9.5F, 9.5F));
        }
    }
}
