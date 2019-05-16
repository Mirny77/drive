﻿using System.Collections;
using UnityEngine;

public class SpawnCars : MonoBehaviour {

	[SerializeField]
	private bool mainScene;
	public GameObject[] cars;
	private float startSpawn = 0.5f, waitSpawn;
	private int countCars = 0;

	private bool onceStop;

	void Start () {
		StartCoroutine (westCars ());
		StartCoroutine (eastCars ());
		StartCoroutine (northCars ());
		StartCoroutine (southCars ());

		waitSpawn = mainScene ? 7f : 3f;

		CollisionCars.lose = false;
	}

	void Update () {
		if (!mainScene) {
			if (countCars > 40)
				waitSpawn = 1f;
			else if (countCars > 30)
				waitSpawn = 1.5f;
			else if (countCars > 20)
				waitSpawn = 2f;
		}

		if (CollisionCars.lose && !onceStop) {
			StopAllCoroutines ();
			onceStop = true;
		}
	}

	IEnumerator westCars () {
		yield return new WaitForSeconds (Random.Range (startSpawn, startSpawn + 4.5f));
		while (true) {
			GameObject carInst = Instantiate (cars[Random.Range (0, cars.Length)], new Vector3 (-83.8f, 0, 2.7f),
				Quaternion.Euler (new Vector3 (0, -90f, 0))) as GameObject;
			countCars++;
			int rand = mainScene ? 2 : Random.Range (0, 4);
			switch (rand) {
			case 1: 
				carInst.AddComponent <WestTurnLeft> ();
				break;
			case 2:
				carInst.AddComponent <WestTurnRight> ();
				break;
			}
			yield return new WaitForSeconds (Random.Range (waitSpawn, waitSpawn + 5f));
		}
	}

	IEnumerator eastCars () {
		yield return new WaitForSeconds (Random.Range (startSpawn, startSpawn + 4.5f));
		while (true) {
			GameObject carInst = Instantiate (cars[Random.Range (0, cars.Length)], new Vector3 (30f, 0, 11.08f),
				Quaternion.Euler (new Vector3 (0, 90f, 0))) as GameObject;
			countCars++;
			int rand = mainScene ? 2 : Random.Range (0, 4);
			switch (rand) {
			case 1: 
				carInst.AddComponent <EastTurnLeft> ();
				break;
			case 2:
				carInst.AddComponent <EastTurnRight> ();
				break;
			}
			yield return new WaitForSeconds (Random.Range (waitSpawn, waitSpawn + 5f));
		}
	}

	IEnumerator northCars () {
		yield return new WaitForSeconds (Random.Range (startSpawn, startSpawn + 4.5f));
		while (true) {
			GameObject carInst = Instantiate (cars[Random.Range (0, cars.Length)], new Vector3 (-9.1f, 0, 64.4f),
				Quaternion.Euler (new Vector3 (0, 0f, 0))) as GameObject;
			countCars++;
			int rand = mainScene ? 2 : Random.Range (0, 4);
			switch (rand) {
			case 1: 
				carInst.AddComponent <NorthTurnLeft> ();
				break;
			case 2:
				carInst.AddComponent <NorthTurnRight> ();
				break;
			}
			yield return new WaitForSeconds (Random.Range (waitSpawn, waitSpawn + 5f));
		}
	}

	IEnumerator southCars () {
		yield return new WaitForSeconds (Random.Range (startSpawn, startSpawn + 4.5f));
		while (true) {
			GameObject carInst = Instantiate (cars[Random.Range (0, cars.Length)], new Vector3 (-0.32f, 0, -27.22f),
				Quaternion.Euler (new Vector3 (0, 180f, 0))) as GameObject;
			countCars++;
			int rand = mainScene ? 2 : Random.Range (0, 4);
			switch (rand) {
			case 1: 
				carInst.AddComponent <SouthTurnLeft> ();
				break;
			case 2:
				carInst.AddComponent <SouthTurnRight> ();
				break;
			}
			yield return new WaitForSeconds (Random.Range (waitSpawn, waitSpawn + 5f));
		}
	}

}
