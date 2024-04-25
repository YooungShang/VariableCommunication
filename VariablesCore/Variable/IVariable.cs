namespace VariablesCore.Variable;

/// <summary>
/// 变量接口
/// </summary>
public interface IVariable
{
    /// <summary>
    /// 变量名称
    /// </summary>
    string Name { get; }
    /// <summary>
    /// 变量地址
    /// </summary>
    int Address{ get; }
    /// <summary>
    /// 变量值
    /// </summary>
    object Value { get; }
    /// <summary>
    /// 值类型
    /// </summary>
    ValueType Type { get; }
    
}