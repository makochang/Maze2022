using UnityEngine;

public class Map : MonoBehaviour
{
    //�}�b�v�f�[�^
    int[,] mapdata = {
        { 1, 2, 1, 2, 1, 2, 1, 2, 1 },
        { 3, 9, 0, 0, 0, 0, 0, 0, 3 },
        { 1, 2, 1, 2, 1, 0, 1, 2, 1 },
        { 3, 0, 0, 0, 0, 0, 0, 0, 3 },
        { 1, 0, 1, 0, 1, 2, 1, 0, 1 },
        { 3, 0, 0, 0, 3, 0, 0, 0, 3 },
        { 1, 2, 1, 2, 1, 0, 1, 0, 1 },
        { 3, 8, 0, 0, 0, 0, 3, 0, 3 },
        { 1, 2, 1, 2, 1, 2, 1, 2, 1 },
    };

    //�}�b�v�̃I�t�Z�b�g�l�i���_����ǂ̂��炢���炷�̂��j
    Vector2 offset = new Vector2(-1f, 1f);

    //�ǂ⏰�̃v���n�u
    public GameObject[] mapchip = new GameObject[4];

    public GameObject goalObject;

    /// <summary>
    /// �}�b�v��`�悷��
    /// </summary>
    public Vector2 Draw()
    {
        Vector2 playerPos = Vector2.zero;
        for (int i = 0; i < mapdata.GetLength(0); i++)
        {
            for (int j = 0; j < mapdata.GetLength(1); j++)
            {
                int index = mapdata[i, j];  //�}�b�v�f�[�^���Q�Ƃ���index�Ƃ���
                float x = j + offset.x;     //�������WX
                float z = -i + offset.y;    //�������WY

                //����}�b�v�̏���
                if (index >= mapchip.Length || index < 0)
                {
                    switch (index)
                    {
                        case 8:
                            playerPos = new Vector2(x, z);
                            break;
                        case 9:
                            Instantiate(goalObject, new Vector3(x, 0f, z), Quaternion.identity);
                            break;
                        default:
                            break;
                    }
                    index = 0;
                }

                //�}�b�v�I�u�W�F�N�g��z�u
                Instantiate(mapchip[index], new Vector3(x, 0f, z), Quaternion.identity);
            }
        }
        return playerPos;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
}
