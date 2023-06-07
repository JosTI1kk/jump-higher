using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collider)
   {
           Destroy(collider.gameObject); //При столкновение с триггером уничтожаются объекты
           Debug.Log("Yay");
   }
}
