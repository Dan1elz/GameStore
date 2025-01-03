﻿using GameStore.Domain.Entities.ClientContext;

namespace GameStore.Domain.Interfaces.Repository.ClientContext
{
    public interface ITokenRepository
    {
        Task Create(Token token);
        Task Dekete(Token token);
        Task<Token> GetToken(string value);
        Task<Token> GetTokenByID(Guid id);
    }
}
