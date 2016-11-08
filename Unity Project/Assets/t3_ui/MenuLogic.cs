using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuLogic : MonoBehaviour {

    public GameObject menu;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Escape)) {
            menu.SetActive(!menu.activeSelf);

            if (!menu.activeSelf)
                Time.timeScale = 1;
            else
                Time.timeScale = 0;
        }
	}

    public void StartGame() {
        SceneManager.LoadScene("animation");
    }

    public void GoToMenu() {
        SceneManager.LoadScene("menu");
    }

    public void QuitGame() {
        Application.Quit();
    }
}
