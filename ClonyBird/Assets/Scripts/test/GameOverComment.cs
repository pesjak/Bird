using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameOverComment : MonoBehaviour {
	public static int score = 0;

	void Update () {
		score = PlayerPrefs.GetInt("score");


		if(score>=10 && score <=18)
			GetComponent<Text> ().text = "Well you beat my highscore:12, and i created the game";
		else if(score>=18 && score <=25)
			GetComponent<Text> ().text = "Okay this is just crazy...";
		else if(score>=25 && score <=30)
			GetComponent<Text> ().text = "You cheating mate?";
		else if(score>=30 && score <=35)
			GetComponent<Text> ().text = "If not then you are AWESOME" ;
		else if(score>=35 && score <=50)
			GetComponent<Text> ().text = "K... I GET IT YOU ARE GOOD, SHOW OFF!!!";


		switch (score)
		{
		case 0:
		{
			GetComponent<Text> ().text = "WONDERING How to play or are you just BAD";
			break;
		}
		case 1:
		{
			GetComponent<Text> ().text = "Yeah, I'm a COMMENT.";
			break;
		}
		case 2:
		{
			GetComponent<Text> ().text = "Got it?";
	
			break;
		}
		case 3:
		{
			GetComponent<Text> ().text = "Better than some people";

			break;
		}
		case 4:
		{
			GetComponent<Text> ().text = "You had it...";

			break;
		}
		case 5:
		{
			GetComponent<Text> ().text = "I wonder if you noticed this comments";

			break;
		}
		case 6:
		{
			GetComponent<Text> ().text = "Okay you learned to play CONGRATS";

			break;
		}
		case 7:
		{
			GetComponent<Text> ().text = "If you clicked double life, your score would be even higher.";

			break;
		}
		case 8:
		{
			GetComponent<Text> ().text = "You had this.";

			break;
		}
		case 9:
		{
			GetComponent<Text> ().text = "That was soo close!!! *Evil Laugh*";

			break;
		}
		default:
		{
			GetComponent<Text> ().text = "What is happening?";

		}


		}
	}

}
