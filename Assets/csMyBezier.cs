using UnityEngine;
using System.Collections;

public class csMyBezier : MonoBehaviour {

	public Bezier myBezier;
	private float t = 0f;
	
	void Start()
	{
		//myBezier = new Bezier( new Vector3( 0f, 0f, 0f ), Random.insideUnitSphere * 2f, Random.insideUnitSphere * 2f, new Vector3( -10f, 0f, -10f ) );
		myBezier = new Bezier( new Vector3( 0f, 0f, 0f ), new Vector3(-10f,0f,0f), new Vector3(0f,0f,0f), new Vector3( -10f, 0f, -10f ) );
	}
	void Update()
	{
		Vector3 vec = myBezier.GetPointAtTime( t );
		transform.position = vec;

		t += 0.01f;
		if( t > 1f )
			t = 0f;
		vec = myBezier.GetPointAtTime( t );
		transform.LookAt(vec);
	}
}
