using UnityEngine;
using System.Collections;
using TMPro;

public class PlayerCharacter : MonoBehaviour {

	[SerializeField] private TextMeshProUGUI textHealth;
	[SerializeField] private TextMeshProUGUI gameoverScript;

	private int _health;

	void Start() {
		_health = 2;
		HealthUpdate();
	}

	void Update(){

	}

	public void Hurt(int damage) {
		_health -= damage;
		HealthUpdate();
		if(_health <= 0){
			gameoverScript.enabled = true;
		}
	}



	private void HealthUpdate(){
		string health = _health + ": ";

		for(int i = 0; i < _health; i++){
			health += "*";
		}
		textHealth.text = health;
	}
 
}
