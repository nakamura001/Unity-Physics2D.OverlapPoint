using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Main : MonoBehaviour {
	public Text infoText;

	void Update () {
		Collider2D collider = null;
		if (Input.GetKey(KeyCode.Mouse0)) {
			Vector3 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			// public static Collider2D OverlapPoint(Vector2 point, int layerMask = DefaultRaycastLayers, float minDepth = -Mathf.Infinity, float maxDepth = Mathf.Infinity); 
			collider = Physics2D.OverlapPoint(new Vector2(point.x, point.y));
		}
		if (collider) {
			infoText.text = collider.name;
		} else {
			infoText.text = "No data";
		}
	}
}
