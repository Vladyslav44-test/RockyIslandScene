using UnityEngine;

public class Rock6Behavior : MonoBehaviour
{
    public float XRotation = 1;
    public float YRotation = 0;
    public float ZRotation = 0;
    public float DegreesPerSecond = 90;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 axis = new Vector3(XRotation, YRotation, ZRotation);
        transform.RotateAround(Vector3.zero, new Vector3(0, 1, 0), DegreesPerSecond * Time.deltaTime);
        transform.Rotate(axis, DegreesPerSecond * Time.deltaTime);
    }
}
