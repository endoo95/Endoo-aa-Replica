using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InstructionsScript : MonoBehaviour {

    public int timer = 5;

	// Use this for initialization
	void Start () {
        StartCoroutine("InstructionTimer");
	}
	
	// Update is called once per frame
	void Update () {
        if (timer <= 0)
        {
            StopCoroutine("InstructionTimer");
            Destroy(gameObject);
        }
	}

    IEnumerator InstructionTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timer--;
        }
    }
}
