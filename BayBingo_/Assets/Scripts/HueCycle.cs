using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HueCycle : MonoBehaviour
{
    SpriteRenderer sprite;
    [SerializeField]
    public Color[] hue;
    [SerializeField]
    public float Speed = 0f;
    private int index;
    private float changer;
    [SerializeField]
    public float m_Hue;
    [SerializeField]
    public float m_Saturation;
    [SerializeField]
    public float m_Value;
    public Slider m_SliderHue, m_SliderSaturation, m_SliderValue;

    void Start()
    {
        //grabs sprite renderer from image
        sprite = GetComponent<SpriteRenderer>();
        //int Num = Random.Range(0, 255);

        //maximum and minimum values for the Sliders
        m_SliderHue.maxValue = 1;
        m_SliderSaturation.maxValue = 1;
        m_SliderValue.maxValue = 1;

        m_SliderHue.minValue = 0;
        m_SliderSaturation.minValue = 0;
        m_SliderValue.minValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (sprite != null)
        {
            Color newColor = new Color(1, 0, 1, 1);

            sprite.color = newColor;
        }*/

        sprite.material.color = Color.Lerp(sprite.material.color, hue[index], Speed * Time.deltaTime);

        changer = Mathf.Lerp(changer, 1f, Speed * Time.deltaTime);


        if (changer > 0.9f)
        {
            changer = 0;
            index++;

            index = (index > hue.Length) ? 0 : index;
        }

        //These are the Sliders that determine the amount of the hue, saturation and value in the Color
        //This didn't do anything
        m_Hue = m_SliderHue.value;
        m_Saturation = m_SliderSaturation.value;
        m_Value = m_SliderValue.value;

        //Create an RGB color from the HSV values from the Sliders
        //Change the Color of your GameObject to the new Color
        sprite.material.color = Color.HSVToRGB(m_Hue, m_Saturation, m_Value);
    }

}
