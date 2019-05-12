using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame() {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame() {
        Application.Quit(); 
    }

    public void MMF(GameObject MM) {
        MM.SetActive(true);
    }
    public void Dis(GameObject Disable) {
        Disable.SetActive(false);
    }
}
