using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float axisX;
    public float axisY;
    public float amplitudeMove;




    private Rigidbody2D _rigidbody;
    private Animator _animator;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        UpdateAxis();


		
		
	}

    private void UpdateAxis()
    {
        axisX = Input.GetAxis("Horizontal");
        axisY = Input.GetAxis("Vertical");
    }
}
