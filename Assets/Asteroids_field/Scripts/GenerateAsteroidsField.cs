using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateAsteroidsField : MonoBehaviour
{
    public Transform[] asteroidPrefab;
    public float fieldRadius = 100;
    public int asteroidsCount = 500;


    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < asteroidsCount; i++)
        {
            Transform temp = Instantiate(asteroidPrefab[Random.Range(0,2)], Random.insideUnitSphere * fieldRadius, Random.rotation);
            temp.localScale = temp.localScale * Random.Range(2f, 5);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}