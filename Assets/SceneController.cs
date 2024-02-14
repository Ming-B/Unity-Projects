using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SceneController : MonoBehaviour {
    [SerializeField] private GameObject enemyPrefab;
    void Start(){
        SpawnEnemy(2);  
    }

    void Update() {

    }

    public void SpawnEnemy(int enemyCount) {
        for(int i = 0; i < enemyCount; i++){
            GameObject enemy = Instantiate(enemyPrefab) as GameObject;
            enemy.transform.position = new Vector3(0, 1, 0);
            float angle = Random.Range(0, 360);
            enemy.transform.Rotate(0, angle, 0);
          
        }
    }

}