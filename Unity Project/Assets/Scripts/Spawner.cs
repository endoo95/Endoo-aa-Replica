using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject pinPrefab;
    public GameObject Instrukcje;

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
        Instantiate(pinPrefab, transform.position, transform.rotation);
    }
}
