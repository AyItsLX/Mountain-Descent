using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    private float Distance;
    private GameObject Player;
    private bool Dead = false, submitted = false;
    public Text Score, submit;
    public GameObject[] EndGameGO;

    void Start() {
        Player = GameObject.FindGameObjectWithTag("Player");
    }


    void Update() {
        if (Input.GetKeyDown(KeyCode.R)) {
            if (submitted) {
                SceneManager.LoadScene("Game");
            }
        } else if (Input.GetKeyDown(KeyCode.Escape)) {
            if (submitted) {
                SceneManager.LoadScene("Menu");
                //Application.Quit();
            }
        }
        if (!Dead) {
            Score.text = "Distance: " + Mathf.FloorToInt(Distance);
            if (Distance < Player.transform.position.x) {
                Distance = Player.transform.position.x;
            }
        }
    }

    public void EndGame() {
        Dead = true;
        EndGameGO[0].SetActive(true);
    }

    public void Submit() {
        string name = (submit.text).ToUpper();
        Highscores.AddNewHighscore(name, Mathf.FloorToInt(Distance));
        EndGameGO[0].SetActive(false);
        EndGameGO[1].SetActive(true);
        submitted = true;
    }
}
