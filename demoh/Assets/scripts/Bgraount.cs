using UnityEngine;

public class Bgraount : MonoBehaviour
{
    [SerializeField] private float BackgroundSpeed = 2f; //Начальная скорость,которая меняется внутри проекта при желании

    //[Serializefield] - встречная функция юнити, позволяющая изменять значение переменной из испектора, а не из кода
    //private - объявление приватности переменной
    //float - тип переменой с плавущей точкой (В конце цифры обязательно неоюходимо дописать 'f', этого требует объявление типа)
    //speed - название переменной для скорости нашего объекта
    

    
    private void Update()   
    {
        transform.position -= new Vector3 (BackgroundSpeed * Time.deltaTime, 0, 0); //Умножается скорость на время
    }
}
