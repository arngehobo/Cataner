﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSaver : MonoBehaviour {

	GameData data = GameData.current;

	void FixedUpdate () {
		if (Input.GetKey (KeyCode.Escape)) {
			saveGame ();
			SceneManager.LoadScene ("Menu");
		}
		else if (Input.GetKey (KeyCode.LeftControl) && Input.GetKeyDown ("s")) saveGame ();
	}

	void OnApplicationQuit() {
		saveGame ();
	}

	void saveGame() {
		data.cam_pos_x = Camera.main.transform.position.x;
		data.cam_pos_z = Camera.main.transform.position.z;
		data.cam_pos_y = Camera.main.transform.position.y;
		SaveLoad.saveGame();
		Debug.Log ("saved");
	}
}
