using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int lap = 0;
    private int index = 0;
    public GameObject[] checkpoints;

    public void CheckpointReached(GameObject checkpoint)
    {
        if (checkpoints[index] == checkpoint)
        {
            checkpoint.GetComponent<Renderer>().material.color = Color.green;
            index++;
        }
    }
}
