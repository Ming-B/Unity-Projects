using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameoverScript : MonoBehaviour
{

    TextMeshProUGUI gameovertext; 
    RectTransform textRT;
    // Start is called before the first frame update
    void Start()
    {

        gameovertext = GameObject.Find("Game over Script").GetComponent<TextMeshProUGUI>();
        textRT = gameovertext.GetComponent<RectTransform>();
        textRT.anchoredPosition = new Vector2(-Screen.width/2f + textRT.sizeDelta.x/2f, Screen.height/2f - textRT.sizeDelta.y/2f);





        
    }

    // Update is called once per frame
    void Update()
    {

        textRT.anchoredPosition = new Vector2(0f, Mathf.Sin(Time.time)*(Screen.height/2f - textRT.sizeDelta.y/2f));
        
    }
}
