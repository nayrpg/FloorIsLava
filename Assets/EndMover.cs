using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMover : MonoBehaviour
{
    public Vector3 positionDelta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (positionDelta * Time.deltaTime);
    }
}
