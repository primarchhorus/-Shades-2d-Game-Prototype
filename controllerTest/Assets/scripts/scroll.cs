using UnityEngine;
using System.Collections;

public class scroll : MonoBehaviour {

	public float scrollSpeed;
	private Vector2 savedOffset;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	

	}

	public void scrollParrallaxRight() {

		float x = Mathf.Repeat (Time.time * scrollSpeed, 1);
		Vector2 offset = new Vector2 (x, 0);
		renderer.sharedMaterial.SetTextureOffset ("_MainTex", offset);

		}

	
	public void scrollParrallaxLeft() {
		float x = Mathf.Repeat (Time.time * (scrollSpeed*1), 1);
		Vector2 offset = new Vector2 (x*-1, 0);
		renderer.sharedMaterial.SetTextureOffset ("_MainTex", offset);
	
		
	}
}
