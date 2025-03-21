using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YokEdici : MonoBehaviour
{

    [SerializeField]
    GameObject patlamaPrefab;

    GeriSayımSayacı yokEdiciGeriSayım;

    // Start is called before the first frame update
    void Start()
    {
        yokEdiciGeriSayım= gameObject.AddComponent<GeriSayımSayacı>();
    }

    // Update is called once per frame
    void Update()
    {
        if (yokEdiciGeriSayım.Bitti)
        {
            Instantiate(patlamaPrefab,gameObject.transform.position,Quaternion.identity) ;
            Destroy(gameObject);

        }
    }

    public void AsteroidYokEdici(int sure)
    {
        yokEdiciGeriSayım.ToplamSure = sure;
        yokEdiciGeriSayım.Calistir();
    }
}
