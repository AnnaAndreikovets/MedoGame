using UnityEngine;
//�� �������� �����, �������� ����������� ���,
//����������, ����� � ������ �� ������ �����, ����� ���� ���������, �����������
public class Spa : MonoBehaviour { public GameObject button; public Animator anim;
    public void StartP() { button.SetActive(false); anim.SetTrigger("IsTriggered"); } }