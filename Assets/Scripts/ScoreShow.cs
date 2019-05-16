using UnityEngine;
using UnityEngine.UI;

public class ScoreShow : MonoBehaviour {

	[SerializeField]
	private Text topRecord;

	void OnEnable () {
		GetComponent <Text> ().text = "Score: " + DeleteCar.countCars.ToString ();
		PlayerPrefs.SetInt ("CarsPassed", PlayerPrefs.GetInt ("CarsPassed") + DeleteCar.countCars);

	//	Все закомментированно, так как в игре нет плагина Ultimate Mobile, если его добавить, то код будет рабочим
//		if (PlayerPrefs.GetInt ("CarsPassed") > 1000)
//			UM_GameServiceManager.Instance.UnlockAchievement("Pass1000Cars");
//		else if (PlayerPrefs.GetInt ("CarsPassed") > 200)
//			UM_GameServiceManager.Instance.UnlockAchievement("Pass200Cars");
//		else if (PlayerPrefs.GetInt ("CarsPassed") > 50)
//			UM_GameServiceManager.Instance.UnlockAchievement("Pass50Cars");


		if (PlayerPrefs.GetInt ("Score") < DeleteCar.countCars) {
			PlayerPrefs.SetInt ("Score", DeleteCar.countCars);
			topRecord.text = "Top: " + DeleteCar.countCars.ToString ();

	//	Все закомментированно, так как в игре нет плагина Ultimate Mobile, если его добавить, то код будет рабочим
//			UM_GameServiceManager.Instance.SubmitScore("BestScore", DeleteCar.countCars);
		} else
			topRecord.text = "Top: " + PlayerPrefs.GetInt ("Score").ToString ();
	}

}
