using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnekControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject snekPrefab;
    private List<GameObject> snek = new List<GameObject>();
    void Start()
    {
        snek.Add(Instantiate(snekPrefab));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
