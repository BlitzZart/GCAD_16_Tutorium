using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowSpeed : MonoBehaviour {

    public OrcController orc;
    private Text text;


	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        if (orc != null) {
            text.text = (orc.Speed() * 100).ToString("0.0");
        }
	}
}
