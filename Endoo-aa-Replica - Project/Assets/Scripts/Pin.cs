using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {

    public float speed = 30f;
    public Rigidbody2D rb;

    public AudioSource pinHit;
    public AudioSource pinToPin;

    private bool isPinned = false;
    private string _gameMode;
    private int _pinsCounter;
    private int _rouletteSwitchNumber;

    private void Awake()
    {
        _gameMode = PlayerPrefs.GetString("GameMode");
        _rouletteSwitchNumber = PlayerPrefs.GetInt("RouletteSwitchNumber");
        _pinsCounter = PlayerPrefs.GetInt("PinsCounter");
    }

    private void Start()
    {
        if(_rouletteSwitchNumber == 0)
        {
            _rouletteSwitchNumber = Mathf.RoundToInt(Random.Range(1f, 3f));
            PlayerPrefs.SetInt("RouletteSwitchNumber", _rouletteSwitchNumber);
        }
    }

    private void FixedUpdate()
    {
        if(!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Circle" && col.tag != "Pin")
        {
            //Base actions
            transform.SetParent(col.transform);
            isPinned = true;
            pinHit.Play();
            Score.scorePoints++;
            _pinsCounter++;
            PlayerPrefs.SetInt("PinsCounter", _pinsCounter);

            //Gamemode actions
            switch (_gameMode)
            {
                case "Standard":
                    Circle_Rotate.circleSpeed += 1.5f;
                    break;

                case "Roulette":
                    if(_pinsCounter != _rouletteSwitchNumber)
                    {
                        break;
                    }
                    else
                    {
                        _rouletteSwitchNumber = Mathf.RoundToInt(Random.Range(1f, 3f));
                        PlayerPrefs.SetInt("RouletteSwitchNumber", _rouletteSwitchNumber);

                        PlayerPrefs.SetInt("PinsCounter", 0);
                        if (Mathf.RoundToInt(Random.Range(1f, 10f)) < 5f)
                        {
                            Circle_Rotate.circleSpeed = 100f * (Random.Range(5f, 15f) / 10);
                            break;
                        }
                        else
                        {
                            Circle_Rotate.circleSpeed = 100f * (Random.Range(5f, 15f) / 10) * -1f;
                        }
                        break;
                    }

                case "NoSpin":
                    break;

                default:
                    break;
            }
        }
        else if (col.tag == "Pin")
        {
            pinToPin.Play();
            GetComponent<SpriteRenderer>().color = Color.red;
            FindObjectOfType<GameManager>().GameEnded();
        }
    }

}
