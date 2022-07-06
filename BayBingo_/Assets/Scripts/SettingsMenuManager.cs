using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingsMenuManager : MonoBehaviour
{
    //Resolution[] resolutions;
    //public Dropdown resolutionDropdown;
    public Toggle FS;
    public List<ResItem> resolutions = new List<ResItem>();
    private int selectedResolution;
    public TMP_Text resLabel;
    void Start()
    {
        //resolutions = Screen.resolutions;

        FS.isOn = Screen.fullScreen;

        bool foundRes = false;
        for(int i = 0; i < resolutions.Count; i++)
        {
            if(Screen.width == resolutions[i].horizontal && Screen.height == resolutions[i].vertical)
            {
                foundRes = true;

                selectedResolution = i;

                UpdateResLabel();
            }
        }
        //if the player's screen doesn't have any of the listed resolutions
        if (!foundRes)
        {
            ResItem newRes = new ResItem(); 
            newRes.horizontal = Screen.width;
            newRes.vertical = Screen.height;

            resolutions.Add(newRes);
            selectedResolution = resolutions.Count - 1;

            UpdateResLabel();
        }

        //resolutionDropdown.ClearOptions();

        //List<string> options = new List<string>();

        //int currentResolutionIndex = 0;

        /*for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }*/

        /*resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();*/
    }

    /*public void ScreenSize(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }*/

    /*public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);

    }*/

    public void ResLeft()
    {
       //for the right left arrow to change resolutions
        selectedResolution--;

        if(selectedResolution < 0)
        {
            selectedResolution = 0;
        }

        UpdateResLabel();
    }

    public void ResRight()
    {
       //for right arrow
        selectedResolution++;

        if(selectedResolution > resolutions.Count - 1)
        {
            selectedResolution = resolutions.Count - 1; 
        }

        UpdateResLabel();
    }

    public void UpdateResLabel()
    {
        resLabel.text = resolutions[selectedResolution].horizontal.ToString() + " x " + resolutions[selectedResolution].vertical.ToString();
    }

    public void Apply()
    {
        //Screen.fullScreen = FS.isOn;

        Screen.SetResolution(resolutions[selectedResolution].horizontal, resolutions[selectedResolution].vertical, FS.isOn);
    }

    [System.Serializable]
    public class ResItem
    {
        public int horizontal, vertical;
    }
}
