using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// specification
public class GemSpawner : MonoBehaviour {

	public GameObject[] prefabs;

	void Start () {

		StartCoroutine(SpawnGem());
	}

	void Update () {

	}

	IEnumerator SpawnGem() {
		while (true) {

			Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(26, Random.Range(-10, 10), 10), Quaternion.identity);

			yield return new WaitForSeconds(Random.Range(10, 20));
		}
	}
}
