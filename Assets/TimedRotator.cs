using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedRotator : MonoBehaviour
{
    public float waitTime;
    public Vector3 rotationDelta;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > waitTime) {
            transform.Rotate(Time.deltaTime * rotationDelta);
        } else {
            time += Time.deltaTime;
        }
    }
}
