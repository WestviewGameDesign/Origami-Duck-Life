using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipes;
    private float timer;
    [SerializeField] private float timerCycle;

    private void Update()
    {
        timer += Time.deltaTime;

        if(timer >= timerCycle)
        {
            SpawnPipe();
            if (timerCycle >= 1)
                timerCycle *= 0.9f;
            timer = 0;
        }
    }

    private void SpawnPipe()
    {
        GameObject pipe = Instantiate(pipes, new Vector3(10, Random.Range(-3f, 3f)), Quaternion.identity);
        pipe.GetComponent<Pipe>().speed = 1 / timerCycle;
        pipe.GetComponent<Pipe>().distance = timerCycle;
    }
}
