using UnityEngine;
using System.Collections;

public class ReactiveTarget : MonoBehaviour {

	    [SerializeField] private GameObject TombstonePrefab;


	public void ReactToHit() {
		WanderingAI behavior = GetComponent<WanderingAI>();
		if (behavior != null) {
			behavior.SetAlive(false);
		}
		StartCoroutine(Die());
		GameObject tombstone = Instantiate(TombstonePrefab) as GameObject;
		tombstone.transform.position = transform.position;

	}

	private IEnumerator Die() {

		StartCoroutine(RotateoverTime());
		yield return new WaitForSeconds(1.5f);
		Destroy(this.gameObject);
		SceneController scene = GameObject.Find("Controller").GetComponent<SceneController>();
		scene.SpawnEnemy(2);

	}

	private IEnumerator RotateoverTime(){
		float rotationSpeed = 90f;
		float rotationAmount = 0f;

		while(rotationAmount < 90f){

			float rotationThisFrame = rotationSpeed*Time.deltaTime;
			//transform.Rotate(rotationThisFrame,0,0);
			transform.RotateAround(new Vector3(transform.position.x, transform.position.y, transform.position.z-0.3f), Vector3.right, rotationThisFrame);
			rotationAmount += rotationThisFrame;
			yield return null;
			
		}
	}
}
