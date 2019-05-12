using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    Vector3 Rotation;
    private GameObject Player;

	void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
        Rotation = Player.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(0, 0, 0);
        transform.right = (Player.transform.position - Rotation).normalized;
        transform.position = new Vector3(0, 0, 0);
        Rotation = Player.transform.position;
        transform.position = new Vector3(0, 0, 0);
    }
}
