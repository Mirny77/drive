using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BuyNewLocationMoney : MonoBehaviour {

	//	Все закомментированно, так как в игре нет плагина Ultimate Mobile, если его добавить, то код будет рабочим
//	public AudioSource soundObj;
//	public AudioClip success, fail;
//	public GameObject checkedButton;
//	public Sprite unchekedButton, checkedButtonSprite;
//	public GameObject[] notCurrentLocationButtons;
//	public GameObject[] buttonsToDisable;
//	[SerializeField]
//	private string nameOfLocation;
//	[SerializeField]
//	private string ProductID;

//	void OnMouseUpAsButton () {
//		UM_InAppPurchaseManager.Client.OnPurchaseFinished += OnPurchaseFlowFinishedAction;
//		UM_InAppPurchaseManager.instance.Purchase(ProductID);
//	}

//	private void OnPurchaseFlowFinishedAction (UM_PurchaseResult result) {
//		UM_InAppPurchaseManager.Client.OnPurchaseFinished -= OnPurchaseFlowFinishedAction;
//		if(result.isSuccess) {
//			if (PlayerPrefs.GetString ("Music") != "no") {
//				soundObj.clip = success;
//				soundObj.Play ();
//			}
//			PlayerPrefs.SetString ("Location", nameOfLocation);
//			PlayerPrefs.SetString (nameOfLocation, "Open");				
//			for (int i = 0; i < buttonsToDisable.Length; i++)
//				buttonsToDisable [i].SetActive (false);
//
//			for (int i = 0; i < notCurrentLocationButtons.Length; i++)
//				notCurrentLocationButtons [i].GetComponent <Image> ().sprite = unchekedButton;
//			checkedButton.SetActive (true);
//			checkedButton.transform.GetChild (0).GetComponent <Image> ().sprite = checkedButtonSprite;		
//
//			if (nameOfLocation == "City")
//				UM_GameServiceManager.Instance.UnlockAchievement("OpenCity");
//			else if (nameOfLocation == "Downtown")
//				UM_GameServiceManager.Instance.UnlockAchievement("OpenDowntown");
//		} else  {
//			if (PlayerPrefs.GetString ("Music") != "no") {
//				soundObj.clip = fail;
//				soundObj.Play ();
//			}
//		}
//	}

}
