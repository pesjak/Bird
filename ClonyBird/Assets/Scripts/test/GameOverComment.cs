using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameOverComment : MonoBehaviour {
	public static int score = 0;

	void Update () {
		score = PlayerPrefs.GetInt("score");

		if(score == 0)
		GetComponent<Text> ().text = "WONDERING How to play or are you just BAD";

		else if(score == 1)
			GetComponent<Text> ().text = "Yeah, I'm a COMMENT.";

		else if(score == 2)
			GetComponent<Text> ().text = "Got it?";
			
		else if(score == 3)
			GetComponent<Text> ().text = "Better than some people";
			
		else if(score == 4)
			GetComponent<Text> ().text = "You had it...";
			
		else if(score == 5)
			GetComponent<Text> ().text = "I wonder if you noticed this comments";
			
		else if(score == 6)
			GetComponent<Text> ().text = "Okay you learned to play CONGRATS";
			
		else if(score == 7)
			GetComponent<Text> ().text = "If you clicked double life, your score would be even higher.";
			
		else if(score == 8)
			GetComponent<Text> ().text = "You had this.";

		else if(score == 09)
			GetComponent<Text> ().text = "That was soo close!!! *Evil Laugh*";
		else if(score>=10 && score <=18)
			GetComponent<Text> ().text = "Well you beat my highscore:12, and i created the game";
		else if(score>=18 && score <=25)
			GetComponent<Text> ().text = "Okay this is just crazy...";
		else if(score>=25 && score <=30)
			GetComponent<Text> ().text = "You cheating mate?";
		else if(score>=30 && score <=35)
			GetComponent<Text> ().text = "If not then you are AWESOME" ;
		else if(score>=35 && score <=50)
			GetComponent<Text> ().text = "K... I GET IT YOU ARE GOOD, SHOW OFF!!!";



	}

}
