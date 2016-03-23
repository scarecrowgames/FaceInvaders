using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour {

    public float tumble;

    private Vector3 rotSpeed;

    void Start ()
    {
        rotSpeed = Random.insideUnitSphere * tumble;
    }
    void Update()
    {
        GetComponent<Transform>().Rotate(rotSpeed * Time.deltaTime);
    }
}
