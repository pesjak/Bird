using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Net;

public class CheckDouble : MonoBehaviour {

	public GameObject doubleON;
	public GameObject always;


	public int twice;

	// Use this for initialization
	void Awake () {
	
		twice = PlayerPrefs.GetInt ("doublepoints", 0);


		if (twice == 0) {
			always.SetActive(false);
			doubleON.SetActive(false);
			//doubleON = GameObject.Find ("DoublePointsText");
				} 
		else if (twice == 1) {
			always.SetActive(true);
			doubleON.SetActive(false);

		}else if (twice == 2) {
			always.SetActive(true);
			doubleON.SetActive(true);

			
		}


	}

}
