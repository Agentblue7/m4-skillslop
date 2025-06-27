using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerToAndFro : MonoBehaviour
{
   
    [SerializeField] private float distance;
    [SerializeField] private GameObject player;
    [SerializeField] private Transform A;
    [SerializeField] private Transform B;
    
    Vector3 Direction;
    Vector3 differenceVectorAB;

    float t = 0;
    public float duration;

    bool AToB = true;

    // Start is called before the first frame update
    void Start()
    {
        differenceVectorAB = B.transform.position - A.transform.position;
        distance = differenceVectorAB.magnitude;
        Debug.Log(distance);

        Direction = differenceVectorAB.normalized;
        player.transform.position = A.transform.position;
        Debug.Log(Direction);

        duration = distance / 1;
    }

    void Update()
    {
        if (AToB)
        {
            differenceVectorAB = B.transform.position - A.transform.position;
        }
        else
        {
            differenceVectorAB = A.transform.position - B.transform.position;
        }

        Direction = differenceVectorAB.normalized;
        player.transform.position += Direction * Time.deltaTime;

        if (t > duration)
        {
            AToB = !AToB;
            t = 0;
        }
        t += Time.deltaTime;
    }
}