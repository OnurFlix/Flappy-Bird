using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Bird Birdscript;
    public GameObject Borular;
    public float height;
    public float time; 

     private void Start()
    {
        StartCoroutine(SpawnObject(time));
    } 

    public IEnumerator SpawnObject(float time)
    {
        while (!Birdscript.isGameOver)
        {
            Instantiate(Borular, new Vector3(3f, Random.Range(-height, height), 0f), Quaternion.identity);

            yield return new WaitForSeconds(time);
        }

    }
}
