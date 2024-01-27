using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public float force = 200;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * (float)3 / 2 * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * force);
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        Debug.Log("You Lose");
    }
}
