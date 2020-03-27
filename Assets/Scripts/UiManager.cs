using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{

    [SerializeField]
    private Slider inputSlider;

    public TMP_InputField inputField;

    public QuadCopter quadCopter;

    public TextMeshProUGUI altimeterDisplay;
    public Transform altimeter;

    public TextMeshProUGUI powerDisplay;

    public void OnSlider(float value)
    {
        quadCopter.height = value;
        inputField.text = Math.Round(value, 2).ToString();
    }

    private void Update()
    {
        powerDisplay.text = $"Afl: {Math.Round(quadCopter.power, 2)}";
        altimeterDisplay.text = $"Raunhæð: {Math.Round(altimeter.position.y, 2)}";
    }

    public void OnText(string value)
    {
        if (!int.TryParse(value, out int newHeight)) return;
        inputSlider.value = newHeight; // Calls OnSlider and thus changes everything correctly.
    }
}
