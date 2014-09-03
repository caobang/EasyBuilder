namespace EasyBuilder.Core.ObjectContainers
{
    /// <summary>
    /// An enum to description the lifetime of a component.
    /// </summary>
    public enum LifeStyle
    {
        /// <summary>
        /// 多例
        /// </summary>
        Transient,
        /// <summary>
        /// 单例
        /// </summary>
        Singleton
    }
}