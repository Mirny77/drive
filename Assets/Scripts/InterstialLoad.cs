using UnityEngine;
//using UnityEngine.Advertisements;

public class InterstialLoad : MonoBehaviour {

//	Все закомментированно, так как в игре нет плагина Ultimate Mobile, если его добавить, то код будет рабочим
//	public static int countLoses;
//	private bool loaded, shown, unityAds;

//	void Awake () {
//		if (PlayerPrefs.GetString ("No ads") != "yes" && countLoses % 5 == 0) {
//			//subscribing to the Interstitial events
//			UM_AdManager.OnInterstitialLoaded += HandleOnInterstitialLoaded;
//
//			//pre-loading Interstitial content
//			UM_AdManager.LoadInterstitialAd ();
//		} else if (PlayerPrefs.GetString ("No ads") != "yes" && (countLoses % 9 == 0 && countLoses % 4 != 0))
//			unityAds = true;
//	}
//
//	void Update () {
//		if (loaded && CollisionCars.lose && !shown) {
//			// Content was loaded, we can now show the Interstitial ad.
//			UM_AdManager.ShowInterstitialAd ();
//			shown = true;
//		} else if (CollisionCars.lose && !shown && unityAds) {
//			ShowAd ();
//			shown = true;
//		}
//	}
//
//	void ShowAd() {
//		if (Advertisement.IsReady()) {
//			Advertisement.Show();
//		}
//	}
//
//	void HandleOnInterstitialLoaded () {
//		Debug.Log ("Interstitial ad content ready");
//		loaded = true;
//	}
//
//	void OnDisable () {
//		countLoses++;
//	}

}