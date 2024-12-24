using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text timerText;

    private float timerTime;

    private void Awake()
    {
        timerTime = 0f;
    }

    private void Update()
    {
        timerTime += Time.deltaTime;

        timerText.text = Mathf.FloorToInt(timerTime).ToString();
    }
}
