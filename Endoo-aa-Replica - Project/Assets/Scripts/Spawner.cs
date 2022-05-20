using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject pinPrefab;
    public GameObject Instrukcje;

    public AudioSource spawnedPin;

    private void Start()
    {
        //GameObject.FindGameObjectWithTag("AudioManager").GetComponentInChildren(AudioClip("Beep");
    }
    void Update()
    {

        if (Input.GetButtonDown("Fire1") && !InGameMenu.GameIsPaused)
        {
            Destroy(Instrukcje.gameObject);
            SpawnPin();
        }

    }

    void SpawnPin()
    {
        spawnedPin.Play();
        Instantiate(pinPrefab, transform.position, transform.rotation);
    }
}
