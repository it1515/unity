using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour {
	public Text healthText;
	public int health = 3;
	void Update () {
		if(health<0){
			health = 0;
		}
		healthText.text = "Lives: " + health.ToString();
	}
}