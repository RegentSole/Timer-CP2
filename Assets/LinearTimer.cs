using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class SliderTimer : MonoBehaviour
{
    public Slider slider;
    public TMP_Text resourceText2;

    private void Update()
    {
        FillSlider();
    }

    private void FillSlider()
    {
        if (slider.value < 1)
        {
            slider.value += Time.deltaTime;
        }
        else
        {
            slider.value = 0;
            AddResource();
        }
    }

    private void AddResource()
    {
        int currentResource = int.Parse(resourceText2.text);
        resourceText2.text = (currentResource + 3).ToString();
    }
}