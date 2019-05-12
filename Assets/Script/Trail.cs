using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trail : MonoBehaviour {

    public Sprite dashFrame;
    public KeyCode dash;

    public Transform Dash1;
    public Transform Dash2;
    public Transform Dash3;

	// Use this for initialization
	void Start () {
        Dash1.GetComponent<SpriteRenderer>().enabled = false;
        Dash2.GetComponent<SpriteRenderer>().enabled = false;
        Dash3.GetComponent<SpriteRenderer>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(dash)) {
            GetComponent<Rigidbody2D>().velocity = new Vector2(4, 0);
            GetComponent<SpriteRenderer>().sprite = dashFrame;

            Dash1.GetComponent<SpriteRenderer>().enabled = true;
            Dash2.GetComponent<SpriteRenderer>().enabled = true;
            Dash3.GetComponent<SpriteRenderer>().enabled = true;
        }
	}
}
