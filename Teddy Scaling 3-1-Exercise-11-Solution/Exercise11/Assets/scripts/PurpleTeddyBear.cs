using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Triples the width of the purple teddy bear
/// </summary>
public class PurpleTeddyBear : MonoBehaviour
{
	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
        // triple width
        Vector3 newScale = transform.localScale;
        newScale.x *= 3;
        transform.localScale = newScale;		
	}
}
