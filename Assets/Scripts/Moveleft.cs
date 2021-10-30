using UnityEngine;

public class Moveleft : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private Enemy enemy;
    private void Awake()
    {
        enemy = GetComponent<Enemy>();
    }
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World);
        if (transform.position.x < -12)
        {
            transform.position += new Vector3(24, 0, 0);
            ShowRandomSprite();
            enemy?.Respawn();
        }
    }

    private void ShowRandomSprite()
    {
        int index = UnityEngine.Random.Range(0, 3);
        int childCount = transform.childCount;
        for (int i = 0; i < childCount; i++)
        {
            Transform child = transform.GetChild(i);
            bool shouldShow = index == i;
            child.gameObject.SetActive(shouldShow);
        }
    }

    private void OnEnable()
    {
        ShowRandomSprite();
    }
}
