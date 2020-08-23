using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Destroys C4 Teddy Bears
/// </summary>
public class Destroyer : MonoBehaviour
{
    [SerializeField]
    GameObject prefabExplosion;
	
    // timer support
    Timer explodeTimer;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        explodeTimer = gameObject.AddComponent<Timer>();
        explodeTimer.Duration = 1;
        explodeTimer.Run();
    }

	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
        // check for timer finished and restart
        if (explodeTimer.Finished)
        {
            explodeTimer.Run();

            // blow up C4 teddy bear
            GameObject teddyBear = GameObject.FindWithTag("C4TeddyBear");
            if (teddyBear != null)
            {
                Instantiate<GameObject>(prefabExplosion,
                    teddyBear.transform.position, Quaternion.identity);
                Destroy(teddyBear);
            }
        }
	}
}
