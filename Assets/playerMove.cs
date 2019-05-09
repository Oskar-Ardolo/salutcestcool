using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    private Rigidbody2D rb2d;
    Vector2 mvt = new Vector2();
    void Start() {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate() {
        if (Input.GetKey(KeyCode.UpArrow)) {
            mvt = Vector2.up;
            rb2d.AddForce(mvt * 20);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            mvt = Vector2.down;
            rb2d.AddForce(mvt * 20);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            mvt = Vector2.right;
            rb2d.AddForce(mvt * 20);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            mvt = Vector2.left;
            rb2d.AddForce(mvt * 20);
        }
    }

}
