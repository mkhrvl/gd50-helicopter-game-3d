using UnityEngine;
using System.Collections;

public class CoinSpawner : MonoBehaviour {

	public GameObject[] prefabs;

	void Start () {

		StartCoroutine(SpawnCoins());
	}

	void Update () {

	}

	IEnumerator SpawnCoins() {
		while (true) {

			int coinsThisRow = Random.Range(1, 4);

			for (int i = 0; i < coinsThisRow; i++) {
				Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(26, Random.Range(-10, 10), 10), Quaternion.identity);
			}

			yield return new WaitForSeconds(Random.Range(1, 5));
		}
	}
}
