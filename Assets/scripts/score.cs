using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public Text scoreText;
    private int points;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        scoreText.text = points.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        points++;
        scoreText.text = points.ToString();
        Debug.Log("point");
    }
}
