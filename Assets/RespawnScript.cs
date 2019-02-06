//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour {

    [SerializeField]
    private Transform playerPos;
    [SerializeField]
    private Transform respawnPos;

    private void OnTriggerEnter(Collider other)
    {
        playerPos.transform.position = respawnPos.transform.position;
    }
}
