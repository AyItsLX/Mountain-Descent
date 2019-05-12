using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    Rigidbody2D rb;
    public bool Gameplaytype = false;
    private GameObject GM;
    private bool isdead = false, footsteps = false;
    public AudioClip[] Sounds;
    private AudioSource AS;
    private float audiodelay = 1;

    void Start() {
        AS = GetComponent<AudioSource>();
        GM = GameObject.FindGameObjectWithTag("GameController");
        rb = GetComponent<Rigidbody2D>();
        transform.eulerAngles = new Vector3(0, 0, 0);
    }

    void Update() {
        if (Input.GetAxis("Jump") >= 0.01f) {
            if (!isdead) {
                rb.gravityScale = 4;
            }
        } else {
            if (!isdead) {
                rb.gravityScale = 1;
            }
        }
        if (!isdead) {
            if (footsteps) {
                audiodelay += Time.deltaTime;
                if (audiodelay >= 1f) {
                    audiodelay = 0;
                    AS.clip = Sounds[1];
                    AS.Play();
                }
            }
            if (rb.velocity.x > 0) {
                gameObject.GetComponent<Animator>().speed = rb.velocity.x * 0.12f;
            }
            if (!Gameplaytype) {
                if (rb.velocity.x < 0 || (transform.position.y < -7)) {
                    AS.clip = Sounds[0];
                    AS.Play();
                    rb.constraints = RigidbodyConstraints2D.FreezeAll;
                    isdead = true;
                    GM.GetComponent<GameManager>().EndGame();
                }
            } else {
                if (Input.GetAxis("Jump") >= 0.01f) {
                    rb.gravityScale = -1;
                } else {
                    rb.gravityScale = 1;
                }
            }
        }
    }

    public void OnCollisionEnter2D(Collision2D collision) {
        footsteps = true;
    }
    public void OnCollisionExit2D(Collision2D collision) {
        audiodelay = 1;
        footsteps = false;
    }
}
