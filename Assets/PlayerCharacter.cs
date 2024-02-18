using UnityEngine;
using System.Collections;
using TMPro;

public class PlayerCharacter : MonoBehaviour
{

	[SerializeField] private TextMeshProUGUI textHealth;
	// [SerializeField] private TextMeshProUGUI gameoverScript;

	private int _health;
	public bool isDead = false;
	private float xSpeed = 50.0f;
	private float ySpeed = -50.0f;
	private float xDirection = Screen.width - 100;
	private float yDirection = 100f;

	void Start()
	{
		_health = 2;
		HealthUpdate();
	}


	public void Hurt(int damage)
	{
		_health -= damage;
		HealthUpdate();
		if (_health <= 0)
		{
			// gameoverScript.enabled = true;
			textHealth.text = "Game Over";
			isDead = true;
		}
	}


	private void HealthUpdate()
	{
		string health = _health + ": ";

		for (int i = 0; i < _health; i++)
		{
			health += "*";
		}
		textHealth.text = health;
	}

	void Update()
	{
		if (isDead)
		{
			textHealth.transform.position = new Vector3(xDirection, yDirection, 0);
			xDirection += xSpeed * Time.deltaTime;
			yDirection += ySpeed * Time.deltaTime;

			if (xDirection + 100 >= Screen.width || xDirection <= 100)
			{
				xSpeed = -xSpeed;
			}

			if (yDirection + 25 >= Screen.height || yDirection <= 25)
				{
					ySpeed = -ySpeed;
				}
		}


	}

}
