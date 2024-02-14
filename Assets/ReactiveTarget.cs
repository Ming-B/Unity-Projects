using UnityEngine;
using System.Collections;

public class ReactiveTarget : MonoBehaviour {

	public void ReactToHit() {
		WanderingAI behavior = GetComponent<WanderingAI>();
		if (behavior != null) {
			behavior.SetAlive(false);
		}
		StartCoroutine(Die());
	}

	private IEnumerator Die() {
		this.transform.Rotate(-75, 0, 0);	
		yield return new WaitForSeconds(1.5f);
		Destroy(this.gameObject);
	}

	private IEnumerator RotateoverTime(){
		float rotationSpeed = 90f;
		float rotationAmount = 0f;

		while(rotationAmount < 90f){

			float rotationThisFrame = rotationSpeed*Time.deltaTime;
			transform.Rotate(Vector3.up, rotationThisFrame);
			rotationAmount += rotationThisFrame;
			yield return null;
			
		}
	}
}
