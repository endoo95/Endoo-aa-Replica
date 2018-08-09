using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {

    public float speed = 20f;
    public Rigidbody2D rb;

    private float rotatorSpeed;
    private bool isPinned = false;

    private void Update()
    {
        if(!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Circle" && col.tag != "Pin")
        {
            transform.SetParent(col.transform);
            Circle_Rotate.circleSpeed += 3f;
            isPinned = true;
            Score.scorePoints++;
        }
        else if (col.tag == "Pin")
        {
            GetComponent<SpriteRenderer>().color = Color.red;
            FindObjectOfType<GameManager>().GameEnded();
        }
    }

}
