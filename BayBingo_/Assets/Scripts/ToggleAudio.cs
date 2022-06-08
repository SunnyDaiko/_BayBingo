using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleAudio : MonoBehaviour
{
    [SerializeField]
    private bool mEnable;

    public void Toggle()
    {
        if (mEnable)
            SoundManager.Instance.ToggleMusic();
    }
}
