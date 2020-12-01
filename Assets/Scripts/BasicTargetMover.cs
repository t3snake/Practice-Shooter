using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTargetMover : MonoBehaviour
{

    public float spinSpeed = 180.0f;
    public float motionSpeed = 0.05f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
        float y = Mathf.Cos(Time.timeSinceLevelLoad) * motionSpeed;
        float z = 3 * Mathf.Sin(Time.timeSinceLevelLoad) * motionSpeed;
        transform.Translate(Vector3.up * y + Vector3.right * z);
        Debug.Log(Vector3.up);
        Debug.Log(z);
        Debug.Log(Vector3.up * z);
    }
}
