using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_Dynamic : MonoBehaviour
{
    public GameObject[] checkPoint;
    [SerializeField] GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < checkPoint.Length; i++)
        {
            Instantiate(prefab, checkPoint[i].transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
