using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatlamaYokEdici : MonoBehaviour
{

    GeriSayımSayacı geriSayımSayaci;


    // Start is called before the first frame update
    void Start()
    {
        geriSayımSayaci = gameObject.AddComponent<GeriSayımSayacı>();
        geriSayımSayaci.ToplamSure = 1;
        geriSayımSayaci.Calistir();
    }

    // Update is called once per frame
    void Update()
    {
        if (geriSayımSayaci.Bitti)
        {
            Destroy(gameObject);
        }
    }
}
