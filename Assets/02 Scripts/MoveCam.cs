using UnityEngine;

public class MoveCam : MonoBehaviour
{
    public float speed = 10.0f;
    public DirPad dirPad;

    //public GameObject Player;

    void Start()
    {
        Debug.Log("Start() called.");
    }

    void Update()
    {
        if (dirPad.dragging)
        {
            var dn = dirPad.dir.normalized * Time.deltaTime * speed; // 단위벡터로 만드는 nomalized
            transform.Translate(new Vector3(dn.x, dn.y, 0));
        }
        else
        {
            //Debug.LogFormat("Time.deltaTime = {0}", Time.deltaTime);
            var dx = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
            var dz = Input.GetAxis("Vertical") * Time.deltaTime * speed;
            transform.Translate(new Vector3(dx, dz, 0));
        }
    }
}