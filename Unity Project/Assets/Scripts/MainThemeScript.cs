using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainThemeScript : MonoBehaviour
{
    public GameObject mainTheme;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            Debug.Log("Niszczenie");
        }
        else
        {
            Debug.Log("ELSE");
        }
    }
}
