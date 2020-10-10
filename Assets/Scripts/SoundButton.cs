using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundButton : MonoBehaviour {
    public GameObject _soundOn, _soundOff;
    public void ButtonSoundOn () {
        GlobalValues._sound = true;
        _soundOn.SetActive (false);
        _soundOff.SetActive (true);
        AudioListener.volume = 0f;
    }
    public void ButtonSoundOff () {
        GlobalValues._sound = false;
        _soundOn.SetActive (true);
        _soundOff.SetActive (false);
        AudioListener.volume = 1f;
    }
}