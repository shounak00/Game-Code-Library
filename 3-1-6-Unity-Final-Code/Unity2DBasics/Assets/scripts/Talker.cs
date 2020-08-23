using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Makes the game object talk
/// </summary>
public class Talker : MonoBehaviour
{
	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
        // temporary debugging code
        Vector3 position = transform.position;
        position.x = 1;

		// say something
        print("I'm the best game object ever");
	}

}
