using UnityEngine;

public class Move : MonoBehaviour {
    public float speed = 10.0f;
    public DirPad dirPad;



    void Start () {
        Debug.Log("Start() called.");
    }

    void Update () {
        if (dirPad.dragging)
        {
            var dn = dirPad.dir.normalized * Time.deltaTime * speed;
            transform.Translate(new Vector3(dn.x, 0, dn.y));
        }
        else
        {
            var dx = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
            var dz = Input.GetAxis("Vertical") * Time.deltaTime * speed;
            transform.Translate(new Vector3(dx, 0, dz));
        }
    }
}
