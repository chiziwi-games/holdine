using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTriggeringObject : MonoBehaviour {

    private void OnTriggerEnter(Collider triggeredCollider) {
        if (triggeredCollider.gameObject.tag == "destroy") {
            Destroy(gameObject);
        } 
    }
}
