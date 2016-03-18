using UnityEngine;
using System.Collections;

public class TTT : MonoBehaviour {

	// Use this for initialization
	public GameObject entity_wall_cat;
	void Start () {
		entity_wall_cat.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void appear()
	{
		entity_wall_cat.SetActive (true);
	}
}
