using UnityEngine;
using System.Collections;

[RequireComponent(typeof(ParticleSystem))]
public class Shape : MonoBehaviour {

	[SerializeField, HideInInspector] 
	ParticleSystem particle;

	IEnumerator Start () 
	{
		particle = GetComponent<ParticleSystem>();

		while(true)
		{
			yield return new WaitWhile(()=> Input.anyKeyDown == false) ;
			yield return null;
			particle.startSize = 0.5f;

			yield return new WaitWhile(()=> Input.anyKeyDown == false) ;
			yield return null;
			particle.startSize = 2;
		}
	}
}