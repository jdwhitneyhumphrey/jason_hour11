using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabCreator : MonoBehaviour
{
    public GameObject Figure;
    public Vector3 spawnValues;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 5; i++)
        {
            Vector3 spawnposition = new Vector3(Random.Range(-spawnValues.z, spawnValues.z), 1f, );
            GameObject gameobject = Instantiate<GameObject>(Figure, new Vector3(2f, 1f, 5f), Quaternion.identity);
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
