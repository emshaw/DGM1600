using UnityEngine;

public class changeColor : MonoBehaviour {
	void Update() {
		if (Input.GetKeyDown(KeyCode.R))
			GetComponent<Renderer>().material.color = Color.red;
	if (Input.GetKeyDown(KeyCode.B))
			GetComponent<Renderer>().material.color = Color.blue;
	if (Input.GetKeyDown(KeyCode.G))
			GetComponent<Renderer>().material.color = Color.green;
	if (Input.GetKeyDown(KeyCode.Delete))
			GetComponent<Renderer>().material.color = Color.white;
	if (Input.GetKeyDown(KeyCode.Space))
			GetComponent<Renderer>().material.color = Color.black;
	if (Input.GetKeyDown(KeyCode.Return))
			GetComponent<Renderer>().material.color = Color.yellow;


	
	}

}