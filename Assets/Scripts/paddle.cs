using UnityEngine;
using System.Collections;

public class paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("paddle collision");
    }
    void Update () {
       // print(Input.mousePosition.x / Screen.width);
	
	}

 
}
