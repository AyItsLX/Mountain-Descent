using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfRemove : MonoBehaviour {
    private GameObject Player;
    public int minimumdis;

    void Start() {
        Player = GameObject.FindGameObjectWithTag("Player");
    }


    void Update() {
        if (transform.position.x < (Player.transform.position.x - minimumdis)) {
            Destroy(gameObject);
        }
    }
}
