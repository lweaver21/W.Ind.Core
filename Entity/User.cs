﻿namespace W.Ind.Core.Entity;

/// <summary>
/// Concrete core entity <see langword="class"/> that can be used as an <see cref="Microsoft.AspNetCore.Identity.IdentityUser{TKey}"/>
/// </summary>
/// <remarks>
/// <para>
/// Inherits from <see langword="abstract"/> <see cref="AuditUserBase{TKey}"/> which implements <see cref="IAuditable"/> and <see cref="IEntity{TKey}"/>
/// </para>
/// <para>
/// Implements <see cref="ISoftDelete"/>, which is the only property defined here
/// </para>
/// </remarks>
public class User : AuditUserBase<long>, ISoftDelete, IAuditable, IEntity<long>
{
    /// <summary>
    /// Default Constructor
    /// </summary>
    public User() { }

    /// <summary>
    /// <para>Implemented from <see cref="ISoftDelete"/></para>
    /// <para>Adds an <c>IsDeleted</c> flag to the <c>User</c> table</para>
    /// </summary>
    /// <remarks>
    /// See <see cref="ContextHelper.HandleSoftDelete(IEnumerable{Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry{ISoftDelete}})"/> for usage
    /// </remarks>
    public bool IsDeleted { get; set; }
}
