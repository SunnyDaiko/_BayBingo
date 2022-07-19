using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagSwitcher : MonoBehaviour
{
    public string TagName;
    // Update is called once per frame
    void SecondTag()
    {
        BCTracker.Instance.Tracker();
        gameObject.tag = TagName;
    }
}
