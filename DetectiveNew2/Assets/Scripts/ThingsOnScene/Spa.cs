using UnityEngine;
//не активный игрок, активный изображение лёжа,
//затемнение, текст о криках на первом этаже, текст надо проверить, растемнение
public class Spa : MonoBehaviour { public GameObject button; public Animator anim;
    public void StartP() { button.SetActive(false); anim.SetTrigger("IsTriggered"); } }