using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour {

    public int hp = 10;
    public Text hpText;

    void Start() {
        hpText.text = hp.ToString();
    }
	void Update () {
        if (hp <= 0)
        {
            Destroy(gameObject);
        }

        hpText.text = hp.ToString();
    }
	
}
