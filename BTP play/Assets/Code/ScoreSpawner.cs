
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSpawner : MonoBehaviour
{
    public float time = 1;
    private void Start()
    {
        StartCoroutine(SpawnRandomPrefab());
    }

    private IEnumerator SpawnRandomPrefab()
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            Prog.Inst.pi.Score++;
        }
    }
}