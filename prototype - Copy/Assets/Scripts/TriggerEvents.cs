using UnityEngine;
using System.Collections;

public class TriggerEvents : MonoBehaviour
{
    public GameObject killbox;
   
    void OnCollisionEnter(Collision col)
        {
            if(col.gameObject.name == "killbox")
            {
            Destroy(this.gameObject);
            }
        }
}