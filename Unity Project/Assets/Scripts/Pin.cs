using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {

    public float speed = 30f;
    public Rigidbody2D rb;

    public AudioSource pinHit;
    public AudioSource pinToPin;

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
            Circle_Rotate.circleSpeed += 1.5f;
            isPinned = true;
            Score.scorePoints++;
            pinHit.Play();
        }
        else if (col.tag == "Pin")
        {
            pinToPin.Play();
            GetComponent<SpriteRenderer>().color = Color.red;
            FindObjectOfType<GameManager>().GameEnded();
        }
    }

}
