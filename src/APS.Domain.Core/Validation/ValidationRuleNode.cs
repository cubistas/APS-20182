using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Domain.Core.Validation
{
    public partial class ValidationRule<TEntity>
    {
        public ValidationRule<TEntity> AddValidacao(Func<bool> func, string error)
        {
            if (!func.Invoke())
                _errors.Add(error);

            return this;
        }

        #region Length

        public ValidationRule<TEntity> Length(Func<TEntity, string> func, int min, int max, string mensagem)
        {
            var retorno = func.Invoke(entity);
            if (string.IsNullOrEmpty(retorno) || !(retorno.Length >= min && retorno.Length <= max))
                _errors.Add(mensagem);
            return this;
        }
        #endregion

        #region NotEmpty
        public ValidationRule<TEntity> NotEmpty<R>(Func<TEntity, R> func, string mensagem) where R : class
        {
            var r = func.Invoke(entity) as string;
            if (r == null)
            {
                _errors.Add(mensagem);
                return this;
            }

            if (string.IsNullOrEmpty(r))
                _errors.Add(mensagem);
            return this;
        }

        public ValidationRule<TEntity> NotEmpty<T>(Func<TEntity, IEnumerable<T>> func, string mensagem)
        {
            var r = func.Invoke(entity);
            if (r == null || r.Any())
                _errors.Add(mensagem);
            return this;
        }
        #endregion

        public ValidationRule<TEntity> NotNull<R>(Func<TEntity, R> func, string mensagem)
        {
            var r = func.Invoke(entity);
            if (r == null)
                _errors.Add(mensagem);
            return this;
        }
    }
}
