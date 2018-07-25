using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class rockSpitterController : MonoBehaviour {
	NavMeshAgent nav;
	public GameObject player;
	Animator anim;

	Vector3 anchor;
	// Use this for initialization
	void Start () {
		nav = GetComponent<NavMeshAgent>();
		anim = GetComponent<Animator> ();
		anchor = transform.position;
	}
	
	// Update is called once per fra me
	void Update () {
		Move();
	}

	void Move()
	{
		Vector3 target = player.transform.position;
		nav.stoppingDistance = 4f;

		if (Vector3.Distance (transform.position, target) > 7) 
		{
			target = anchor;
			nav.stoppingDistance = 0;
		}
			
		nav.SetDestination(target);

		anim.SetFloat ("movePercent", nav.velocity.magnitude / nav.speed);
	}
}
