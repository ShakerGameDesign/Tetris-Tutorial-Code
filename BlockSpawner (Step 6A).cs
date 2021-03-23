using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour                       //"BlockSpawner" MUST match the name of the script you created for the spawner 'empty' for the code to work!
{
    public GameObject[] Tetrominoes;
    
    void Start()
    {
        NewTetromino();
    }

    public void NewTetromino()
    {
        Instantiate(Tetrominoes[Random.Range(0, Tetrominoes.Length)], transform.position, Quaternion.identity);
    }
}
