using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InstructionsScript : MonoBehaviour {

    public int timer = 10;

	// Use this for initialization
	void Start () {
        StartCoroutine("InstructionTimer");
	}
	
	// Update is called once per frame
	void Update () {
        if (timer <= 0)
        {
            StopCoroutine("InstructionTimer");
            gameObject.SetActive(false);
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
