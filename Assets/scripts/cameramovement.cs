using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    public float speed = (float)5 / 2;
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
