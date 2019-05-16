using UnityEngine;

public class CreateAudio : MonoBehaviour {

	public GameObject music;

	void Start () {
		if (GameObject.Find ("Audio Cntrl(Clone)") == null)
			Instantiate (music, new Vector3 (0,0,0), Quaternion.identity);
	}

}
