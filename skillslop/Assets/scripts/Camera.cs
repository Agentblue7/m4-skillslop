using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1 : MonoBehaviour
{
    public GameObject button;
    private bool isRunning = false;
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        button.SetActive(false);
        StartCoroutine(RandomTimer());
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning)
        {
            timer += Time.deltaTime;
        }
    }
    private IEnumerator RandomTimer()
    {
        yield return new WaitForSeconds(UnityEngine.Random.Range(1f, 4f));
        button.SetActive(true);
        isRunning = true;
    }
}