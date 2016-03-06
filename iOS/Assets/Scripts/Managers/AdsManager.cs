using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour {

	public string gameId; // Set this value from the inspector.
	public bool enableTestMode = true;

	void Start ()
	{
		Advertisement.Initialize ("1041968", true);

		StartCoroutine (ShowAdWhenReady ());
	}

	IEnumerator ShowAdWhenReady()
	{
		while (!Advertisement.isReady ())
			yield return null;

		Advertisement.Show ();
	}
}
