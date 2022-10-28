using UnityEngine;

public class GameManager : MonoBehaviour
{
    Map map;
    public GameObject player;
    Vector3 playerStartPos;

    /// <summary>
    /// �Q�[���{�̂��I������
    /// </summary>
    private void QuitGame()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            //Unity�G�f�B�^�[�̏ꍇ
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
            //���s�t�@�C���̏ꍇ
#if UNITY_STANDALONE
            Application.Quit();
#endif
        }
    }

    public void SetPlayerPos(Vector2 pos)
    {

    }

    private void Awake()
    {
        map=GameObject.FindObjectOfType<Map>();
        Vector2 pPos=map.Draw();
        playerStartPos = new Vector3(pPos.x,10f,pPos.y);
    }

    private void Start()
    {
        Instantiate(player, playerStartPos, Quaternion.identity);
    }



    void Update()
    {
        QuitGame();
    }
}
