using UnityEngine;

public class DirectionalLightBehavior : MonoBehaviour
{
    public float DegreesPerSecond = 90;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(1, 0, 0), DegreesPerSecond * Time.deltaTime);
    }
}
