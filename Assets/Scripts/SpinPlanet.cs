using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPlanet : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] float spinSpeed = 1.5f;

    [SerializeField] bool isEarth;

    // Update is called once per frame
    private void Start()
    {
    }
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * spinSpeed, Space.Self);

        if (target != null)
        {
            transform.RotateAround(target.transform.position, Vector3.up, spinSpeed * Time.deltaTime);
        }
        if (isEarth)
        {
            float val = Mathf.PingPong(Time.time * (Time.deltaTime * 3), 1);
            GetComponent<Renderer>().material.SetFloat("_TexVal", val);
        }
    }
}
