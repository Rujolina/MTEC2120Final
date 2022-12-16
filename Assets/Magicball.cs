using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magicball : MonoBehaviour
{
    public GameObject cube;


    private void OnMouseDown()
    {
        Debug.Log("Cick!");

    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(cube, new Vector3(54,25,25) , Quaternion.identity);
        }
        
    }
}
