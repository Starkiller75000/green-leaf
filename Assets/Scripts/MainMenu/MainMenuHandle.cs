using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuHandle : MonoBehaviour {
    public Camera _mainCamera;
    public GameObject _gameStuff;
    public float _speedCamera = 1f;
    private bool _startGame = false;
    private GameObject _garbageCollector;
    private AudioSource _playButtonAudio;
    [SerializeField]
    private AudioClip _audioClip;

    void Start () {
        _mainCamera.orthographicSize = 12.5f;
        _gameStuff.SetActive (false);
        _garbageCollector = GameObject.Find("GarbageCollector(Clone)");
        _garbageCollector.SetActive(false);
        _playButtonAudio = GameObject.Find("ButtonPlay").GetComponent<AudioSource>();
    }
    void Update () {
        if (_startGame && _mainCamera.orthographicSize != 7.5f) {
            _mainCamera.orthographicSize = (_mainCamera.orthographicSize - _speedCamera * Time.deltaTime >= 7.5f ? _mainCamera.orthographicSize - _speedCamera * Time.deltaTime : 7.5f);
            GetComponent<CanvasGroup>().alpha = (_mainCamera.orthographicSize - 7.5f) / 5f; 
        } else if (_mainCamera.orthographicSize == 7.5f) {
            _gameStuff.SetActive (true);
            _garbageCollector.SetActive(true);
            gameObject.SetActive (false);
        }
    }

    public void PlayButton () {;
        _startGame = true;
        _playButtonAudio.PlayOneShot(_audioClip);
    }

}