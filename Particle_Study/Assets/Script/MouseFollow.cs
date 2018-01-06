using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour {

    [SerializeField] float mouseDepth = 5.0f;
    [SerializeField] float speed = 3.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = mouseDepth;

        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector3 position = Vector3.Lerp(transform.position, worldPosition,  speed * Time.deltaTime);
        transform.position = position;
	}
}
