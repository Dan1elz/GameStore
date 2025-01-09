namespace GameStore.Aplication.UseCases.AuthenticationContext.Authentification
{
    public class GetTokenToString
    {
        public static string Execute(string token)
        {
            if (string.IsNullOrEmpty(token) || !token.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
                throw new Exception("Token not found");

            // return token.Substring("Bearer ".Length).Trim();
            return token["Bearer ".Length..].Trim();
        }
    }
}
