using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTimeScript : MonoBehaviour {

    public float delay;
    float time;

    void Start() {
        time = Time.time + delay;
    }

    void Update() {
        if (Time.time >= time) {
            Destroy(this.gameObject);
        }
    }
}
