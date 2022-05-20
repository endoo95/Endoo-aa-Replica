using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle_Rotate : MonoBehaviour {

    public static float circleSpeed;

    private void Start()
    {
        circleSpeed = 125;
    }

    private void Update()
    {
        transform.Rotate(0f, 0f, circleSpeed * Time.deltaTime);
    }
}
