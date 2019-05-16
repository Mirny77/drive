using System.Collections;
using UnityEngine;

public class NoAds : MonoBehaviour {

	//	Все закомментированно, так как в игре нет плагина Ultimate Mobile, если его добавить, то код будет рабочим
//	public AudioSource soundObj;
//	public AudioClip success, fail;
//
//	void Awake () {
//		if (PlayerPrefs.GetString ("No ads") == "yes")
//			Destroy (gameObject);
//	}
//
//	void OnMouseUpAsButton () {
//		UM_InAppPurchaseManager.Client.OnPurchaseFinished += OnPurchaseFlowFinishedAction;
//		UM_InAppPurchaseManager.instance.Purchase("Ads");
//	}
//
//	private void OnPurchaseFlowFinishedAction (UM_PurchaseResult result) {
//		UM_InAppPurchaseManager.Client.OnPurchaseFinished -= OnPurchaseFlowFinishedAction;
//		if(result.isSuccess) {
//			if (PlayerPrefs.GetString ("Music") != "no") {
//				soundObj.clip = success;
//				soundObj.Play ();
//			}
//			PlayerPrefs.SetString ("No ads", "yes");
//			Destroy (gameObject);
//		} else  {
//			if (PlayerPrefs.GetString ("Music") != "no") {
//				soundObj.clip = fail;
//				soundObj.Play ();
//			}
//		}
//	}

}
