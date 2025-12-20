using UnityEngine;
using UnityEngine.UI;

public class PositionData : MonoBehaviour
{
    public PositionManager manager;
    public ServoActuator axis0;
    public ServoActuator axis1;
    public ServoActuator axis2;

    //포지션의 순서 텍스트
    public Text idText;
    //포지션 데이터 텍스트
    public Text positionText_Axis0;
    public Text positionText_Axis1;
    public Text positionText_Axis2;
    //포지션 값
    private int _position_Axis0;
    private int _position_Axis1;
    private int _position_Axis2;

    //처음에 어떻게 표현되어야 하는지 초기화
    public void Init(int index, int position0, int position1, int position2)
    {
        _position_Axis0 = position0;
        _position_Axis1 = position1;
        _position_Axis2 = position2;
        idText.text = "P" + index.ToString("D3");
        positionText_Axis0.text = position0.ToString();
        positionText_Axis1.text = position1.ToString();
        positionText_Axis2.text = position2.ToString();
    }

    //순서가 변경될 때 호출
    public void ChangeIndex(int index)
    {
        idText.text = "P" + index.ToString("D3");
    }

    //삭제할 때 호출
    public void Delete(bool removeData)
    {
        if (removeData)
            manager.RemoveData(this);

        Destroy(gameObject);
    }

    public void Go()
    {
        axis0.Cmd_Positioning(_position_Axis0);
        axis1.Cmd_Positioning(_position_Axis1);
        axis2.Cmd_Positioning(_position_Axis2);
    }
}
