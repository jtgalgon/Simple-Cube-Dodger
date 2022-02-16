using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other) {
        resetPlayerPos(other);
    }

    public void resetPlayerPos(Collider other){
        if (other.tag == "Player"){
            other.transform.position = other.GetComponent<Controller>().originalPos;
            other.attachedRigidbody.velocity = new Vector3(0,0,0);
            other.GetComponent<UpdateScores>().updateLives();
        }
    }
}
