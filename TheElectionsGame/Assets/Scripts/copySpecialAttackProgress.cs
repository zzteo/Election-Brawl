using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class copySpecialAttackProgress : MonoBehaviour
{
    // the script is used so when the game starts the second tv copies the values showed on the first tv
    public Slider slider;
    public Slider MainSlider;

    private void Update()
    {
        slider.value = MainSlider.value;
    }
}
