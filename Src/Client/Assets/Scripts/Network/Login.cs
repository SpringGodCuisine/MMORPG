using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Network;

public class Login : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NetClient.Instance.Init("127.0.0.1", 8000);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
