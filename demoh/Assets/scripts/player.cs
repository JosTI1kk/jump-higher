using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class player : MonoBehaviour
{
    [Header("Settings")]

    [SerializeField] private GameObject DeathScreen; //экран при смерти

    [SerializeField] private float jumpVelocity = 20;//сила прыжка
        
    [SerializeField] private GameObject playerUI; //юзер интерфейса игрока

    private Animator animation;//импортируем компонент animator

    private Rigidbody2D rigidbody;

    private bool jump = false;//булевая переменная, провераряющая наличие земли под ногами

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();//объявляем компонент rigidbody при старте игры внутри персонажа
        animation = GetComponent<Animator>(); //объявляем компонент animator при старте игры внутри персонажа
        Time.timeScale = 1f; //время течет в игре в нормальной скорости
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.Space)&& jump == false)//проверка, нажата ли клавиша пробел и есть ли земля под ногами
        {
            rigidbody.velocity = new Vector3(0, jumpVelocity, 0); //меняем гравитацию игрока на значение силы прыжка
            animation.SetBool("Jump", true);//внутри аниматора передаем в булевую переменную Jump значение True
            jump = true; //переводим нашу переменную проверки прыжка в true
        }
    }

    private void OnCollisionEnter2D(Collision2D other)//метод для проверки на соприкосновение с коллайдером объекта
    {
        if(other.gameObject.tag == "LocationTemplate")//проверка на соприкосновение с землей у которой тег LocationTemplate
        {
            animation.SetBool("Jump", false);//отключаем аниацию прыжка
            jump = false; //при соприкосновении с полом обнуляется юулевая переменная нтобы не было двойного прыжка
        }

        if(other.gameObject.tag == "Obstacle")//проверка на соприкосновение с препятствием
        {
            DeathScreen.SetActive(true); //Включение экрана смерти при столкновение с предпяствием
            playerUI.SetActive(false);
            Time.timeScale = 0f;//остановка времени
        }
    }
}
