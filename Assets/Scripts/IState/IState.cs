public interface IState
{
    /// <summary>
    /// 进入状态时调用。
    /// </summary>
    void Enter();

    /// <summary>
    /// 退出状态时调用。
    /// </summary>
    void Exit();
}