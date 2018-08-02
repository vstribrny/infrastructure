﻿using System.Threading;
using System.Threading.Tasks;
using Riganti.Utils.Infrastructure.Core;

namespace Riganti.Utils.Infrastructure.Services.Facades
{
    public interface ICrudDetailFacade<TDetailDTO, in TKey>
        where TDetailDTO : IEntity<TKey>
    {
        TDetailDTO InitializeNew();

        TDetailDTO GetDetail(TKey id);

        Task<TDetailDTO> GetDetailAsync(CancellationToken cancellationToken, TKey id);

        Task<TDetailDTO> GetDetailAsync(TKey id);

        TDetailDTO Save(TDetailDTO data);

        Task<TDetailDTO> SaveAsync(CancellationToken cancellationToken, TDetailDTO detail);

        Task<TDetailDTO> SaveAsync(TDetailDTO data);

        void Delete(TKey id);

        Task DeleteAsync(TKey id);

        Task DeleteAsync(CancellationToken cancellationToken, TKey id);
    }
}