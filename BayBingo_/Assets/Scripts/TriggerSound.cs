using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour
{
    [SerializeField]
    private AudioClip m_Source;
    void Start()
    {
        SoundManager.Instance.PlaySound(m_Source);
    }

}
