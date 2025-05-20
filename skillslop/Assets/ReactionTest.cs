using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ReactionTest : MonoBehaviour
{
    [SerializeField] Button StartButton;
    [SerializeField] Button StopButton;
    [SerializeField] Button ContinueButton;
    // Start is called before the first frame update
    void Start()
    {
        StartButton.onClick.AddListener(ClickStartButton);
        StopButton.onClick.AddListener(ClickStopButton);
        ContinueButton.onClick.AddListener(ClickContinueButton);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void ClickStartButton()
    {
        Debug.Log("startButton");
    }

    private void ClickStopButton()
    {
        Debug.Log("stopButton");
    }

    private void ClickContinueButton()
    {
        Debug.Log("ContinueButton");
    }
}
        



