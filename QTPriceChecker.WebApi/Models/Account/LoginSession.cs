//@CodeCopy
//MdStart
#if ACCOUNT_ON
namespace QTPriceChecker.WebApi.Models.Account
{
    /// <summary>
    /// This model represents a login session.
    /// </summary>
    public class LoginSession
    {
        /// <summary>
        /// Gets the property data.
        /// </summary>
        public int IdentityId { get; init; }
        /// <summary>
        /// Gets the property data.
        /// </summary>
        public string SessionToken { get; init; } = string.Empty;
        /// <summary>
        /// Gets the property data.
        /// </summary>
        public DateTime LoginTime { get; init; }
        /// <summary>
        /// Gets the property data.
        /// </summary>
        public string Name { get; init; } = string.Empty;
        /// <summary>
        /// Gets the property data.
        /// </summary>
        public string Email { get; init; } = string.Empty;
        /// <summary>
        /// Gets the property data.
        /// </summary>
        public string? OptionalInfo { get; init; }
        /// <summary>
        /// Gets the property data.
        /// </summary>
        public AccessRole[] Roles { get; init; } = Array.Empty<AccessRole>();

        /// <summary>
        /// Creates an instance of type LoginSession.
        /// </summary>
        /// <param name="source">The object from which the instance is created.</param>
        /// <returns>The created instance.</returns>
        public static LoginSession Create(Logic.Models.Account.LoginSession source)
        {
            return new LoginSession
            {
                IdentityId = source.IdentityId,
                SessionToken = source.SessionToken,
                LoginTime = source.LoginTime,
                Name = source.Name,
                Email = source.Email,
                OptionalInfo = source.OptionalInfo,
                Roles = source.Roles.Select(e => AccessRole.Create(e)).ToArray(),
            };
        }
    }
}
#endif
//MdEnd
