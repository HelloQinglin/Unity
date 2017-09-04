using UnityEngine;
using System.Collections;
//产生随机颜色
public class RandonColor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    float timer;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = RandomColor1();
            timer = 3;

        }

    }

    public Color RandomColor1()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Color color = new Color(r, g, b,0.3f);
        return color;
    }
}