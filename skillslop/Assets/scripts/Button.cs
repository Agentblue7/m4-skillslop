using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class script2 : MonoBehaviour
{
    private script1 script;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        script = FindObjectOfType<script1>();
        text.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnClick()
    {
        text.enabled = true;
        float timerhere = script.timer * 1000;
        timerhere = Mathf.RoundToInt(timerhere);
        text.text = timerhere.ToString() + " ms";
    }
    private IEnumerator disabletimer()
    {
        yield return new WaitForSeconds(5);
        text.enabled = false;
    }
}