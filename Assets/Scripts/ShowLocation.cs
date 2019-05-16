using System.Collections;
using UnityEngine;

public class ShowLocation : MonoBehaviour {

	public GameObject[] locations;

	void Start () {
		if (PlayerPrefs.HasKey ("Location")) {
			for (int i = 0; i < locations.Length; i++) {
				if (PlayerPrefs.GetString ("Location") != locations [i].name)
					locations [i].SetActive (false);
			}
		} else {
			locations [0].SetActive (true);
			for (int i = 1; i < locations.Length; i++) {
				if (PlayerPrefs.GetString ("Location") != locations [i].name)
					locations [i].SetActive (false);
			}
		}

		Camera.main.transform.position = new Vector3 (13.97f, Camera.main.transform.position.y, Camera.main.transform.position.z);
	}

}
