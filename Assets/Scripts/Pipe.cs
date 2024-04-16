using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed;
    public float distance;
    [SerializeField] private GameObject topSpire;
    [SerializeField] private GameObject bottomSpire;

    private float timer;

    private void Start()
    {
        topSpire.transform.localPosition = new Vector3(0, 5f + distance);
        bottomSpire.transform.localPosition = new Vector3(0, -5f - distance);
        timer = 0;
    }

    private void Update()
    {
        transform.position += new Vector3(-speed * 10, 0) * Time.deltaTime;

        timer += Time.deltaTime;

        if(timer > 10)
        {
            Destroy(gameObject);
        }
    }
}
