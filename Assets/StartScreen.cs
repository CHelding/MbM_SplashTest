using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScreen : MonoBehaviour {

    //public Button startButton;

	// Use this for initialization
	void Start () {

        //startButton = startButton.GetComponent<Button>();
		
	}

    public void StartAR() {
        SceneManager.LoadScene("MbM_Test");

    }

}
