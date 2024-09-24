using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSapawner : MonoBehaviour
{

    //declare prefab as variable
    public GameObject Brick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(Brick);
    }
}
