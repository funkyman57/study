using UnityEngine;

public class Move : MonoBehaviour {
    public float speed = 10.0f;



	void Start () {
        Debug.Log("Start() called.");
    }

    void Update () {
        var dx = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
        var dz = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;
        transform.Translate(new Vector3(dx, 0, dz));
    }
}
