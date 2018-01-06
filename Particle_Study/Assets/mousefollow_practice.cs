using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousefollow_practice : MonoBehaviour {

    [SerializeField] float speed = 8.0f;
    [SerializeField] float depth = 5.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = depth;

        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector3 position = Vector3.Lerp(this.transform.position, worldPosition, speed * Time.deltaTime);
        transform.position = position;
	}
}
