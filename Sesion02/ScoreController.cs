using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{

    TMP_Text scoreText;
    public static int scoreValue;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.FindWithTag("Score").GetComponent<TMP_Text>();
        scoreValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = $"Score: {scoreValue}"; 
    }

}
