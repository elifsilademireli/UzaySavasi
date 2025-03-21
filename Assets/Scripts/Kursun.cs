using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kursun : MonoBehaviour
{
    GeriSayımSayacı geriSayimSayaci;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0,10), ForceMode2D.Impulse);
        geriSayimSayaci = gameObject.AddComponent<GeriSayımSayacı>();
        geriSayimSayaci.ToplamSure = 3;
        geriSayimSayaci.Calistir();

    }

    // Update is called once per frame
    void Update()
    {
        if (geriSayimSayaci.Bitti)
        {
            Destroy(gameObject);
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Asteroid")
        {
            Destroy(gameObject);
        }
    }
}
