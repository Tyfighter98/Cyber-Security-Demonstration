using UnityEngine;
using System.Collections;

public class RotateLock : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        rotate(5);
	}

    void rotate(int numOfCharacters){
        float rotation = 360 / numOfCharacters;
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            transform.Rotate(0, 0, -rotation);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            transform.Rotate(0, 0, rotation);
        }
    }
}
