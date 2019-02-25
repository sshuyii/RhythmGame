using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDestroy : MonoBehaviour
{
    private float Timer;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        Timer += 1;

        if (transform.localScale.x < 1)
        {
            transform.localScale += new Vector3(Time.deltaTime, Time.deltaTime, Time.deltaTime);
            print("Expanding");
        }

        if (Timer > 80)
        {
            Destroy(gameObject);
        }
    }
}
