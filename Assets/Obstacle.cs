using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour {
    public float speed;

    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();

        rb.velocity = new Vector2(-speed, 0.0f);
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("main");
    }
}
